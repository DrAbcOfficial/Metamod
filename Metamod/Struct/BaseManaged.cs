using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Metamod.Struct;

public abstract class BaseManaged<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors)] T> where T : struct
{
    internal T _native;
    private nint _ptr;
    internal bool _fromNative;

    internal nint GetUnmanagedPtr()
    {
        if (_ptr == IntPtr.Zero)
            Marshal.StructureToPtr<T>(_native, _ptr, !_fromNative);
        return _ptr;
    }

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

    internal void SetupFromPtr(nint ptr)
    {
        _ptr = ptr;
        _native = Marshal.PtrToStructure<T>(ptr);
        _fromNative = true;
    }

    internal BaseManaged(nint ptr)
    {
        SetupFromPtr(ptr);
    }

    ~BaseManaged()
    {
        if (!_fromNative)
            Marshal.FreeHGlobal(_ptr);
    }
}
