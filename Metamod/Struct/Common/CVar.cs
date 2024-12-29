using Metamod.Native.Engine;
using System.Runtime.InteropServices;

namespace Metamod.Struct.Common;

public class CVar : BaseManaged<NativeCVar>
{
    private nint _nName = nint.Zero;
    private nint _nStr = nint.Zero;

    ~CVar()
    {
        if(_nName != nint.Zero)
            Marshal.FreeHGlobal(_nName);
        if (_nStr != nint.Zero)
            Marshal.FreeHGlobal(_nStr);
    }
    public string Name
    {
        get => Marshal.PtrToStringAnsi(_native.name) ?? string.Empty;
        set
        {
            if(_nName != nint.Zero)
                Marshal.FreeHGlobal(_nName);
            nint ns = Marshal.StringToHGlobalAnsi(value);
            _native.name = ns;
            _nName = ns;
        }
    }
    public string Str
    {
        get => Marshal.PtrToStringAnsi(_native.str) ?? string.Empty;
        set
        {
            if (_nStr != nint.Zero)
                Marshal.FreeHGlobal(_nStr);
            nint ns = Marshal.StringToHGlobalAnsi(value);
            _native.str = ns;
            _nStr = ns;
        }
    }
    public int Flags
    {
        get => _native.flags;
        set => _native.flags = value;
    }
    public float Value
    {
        get => _native.value;
        set => _native.value = value;
    }
    public nint Next
    {
        get => _native.next;
        set => _native.next = value;
    }
    public CVar(nint ptr) : base(ptr) { }
    public CVar() { }
}
