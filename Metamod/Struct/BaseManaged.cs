using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Metamod.Struct;

public abstract class BaseManaged<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors)] T> where T : struct
{
    internal T _native;
    private nint _ptr;
    internal bool _fromNative;

    internal BaseManaged()
    {
        _native = new T();
        _fromNative = false;
    }

    internal BaseManaged(T managed)
    {
        _native = managed;
        _fromNative = false;
    }

    internal BaseManaged(nint ptr)
    {
        SetupFromPtr(ptr);
    }

    // 确保分配了非托管内存（如果当前没有），并把当前托管数据写入非托管内存（第一次分配时）
    private void EnsureAllocated()
    {
        if (_ptr == IntPtr.Zero)
        {
            var size = Marshal.SizeOf<T>();
            _ptr = Marshal.AllocHGlobal(size);
            // 初始化非托管内存为当前托管值
            Marshal.StructureToPtr(_native, _ptr, false);
            _fromNative = false;
        }
    }

    // 返回非托管指针（保证已经将最新托管值写入非托管内存）
    internal nint GetUnmanagedPtr()
    {
        EnsureAllocated();
        // 每次请求指针时，把托管最新值写回非托管内存以保证同步
        Marshal.StructureToPtr(_native, _ptr, true);
        return _ptr;
    }

    // 新增：仅返回内部保存的非托管指针，不做任何写回（用于只读/按字段直接访问）
    internal nint GetRawUnmanagedPtr()
    {
        return _ptr;
    }

    // 把当前托管数据写回非托管内存（手动调用，适用于非-blittable 类型）
    internal void SyncToUnmanaged()
    {
        EnsureAllocated();
        Marshal.StructureToPtr(_native, _ptr, true);
        _fromNative = false;
    }

    // 从非托管内存读取最新值到托管副本
    internal void RefreshFromUnmanaged()
    {
        if (_ptr == IntPtr.Zero)
            throw new InvalidOperationException("No unmanaged pointer available to refresh from.");
        _native = Marshal.PtrToStructure<T>(_ptr);
        _fromNative = true;
    }

    // 返回托管副本（设置时自动写回非托管内存）
    internal T Managed
    {
        get => _native;
        set
        {
            _native = value;
            SyncToUnmanaged();
        }
    }

    // 针对 blittable（不包含引用类型）的 T：返回对非托管内存的引用，可直接对非托管内存就地修改（实时生效）
    // 若 T 包含引用类型则抛出异常（此时请使用 Managed + SyncToUnmanaged/RefreshFromUnmanaged）
    internal unsafe ref T GetUnmanagedRef()
    {
        // 检测是否包含引用或引用类型字段
        if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
            throw new InvalidOperationException("Type contains managed references; cannot map directly to unmanaged memory. Use Managed + SyncToUnmanaged/RefreshFromUnmanaged instead.");

        EnsureAllocated();
        // 直接把指针视作 T 的引用，修改将直接写到非托管内存（注意内存布局必须匹配）
        return ref Unsafe.AsRef<T>(_ptr.ToPointer());
    }

    internal void SetupFromPtr(nint ptr)
    {
        if (ptr == IntPtr.Zero)
            throw new ArgumentException("ptr cannot be zero.", nameof(ptr));
        _ptr = ptr;
        _native = Marshal.PtrToStructure<T>(ptr);
        _fromNative = true;
    }

    ~BaseManaged()
    {
        if (!_fromNative && _ptr != IntPtr.Zero)
            Marshal.FreeHGlobal(_ptr);
    }
}