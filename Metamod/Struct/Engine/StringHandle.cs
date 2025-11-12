using Metamod.Interface;
using Metamod.Native.Engine;
using System.Runtime.InteropServices;

namespace Metamod.Struct.Engine;

public class StringHandle : BaseManaged<NativeStringHandle>
{
    private nint _ptr = IntPtr.Zero;
    private bool _need_release = false;

    internal StringHandle() : base() 
    {
        _need_release = false;
    }
    internal StringHandle(NativeStringHandle str) : base(str) 
    { 
        _need_release = false; 
    }
    public StringHandle(string str) : base()
    {
        SetString(str);
    }

    public nint GetPtr()
    {
        return _ptr;
    }

    public void SetPtr(nint ptr)
    {
        if (_need_release)
        {
            Marshal.FreeHGlobal(_ptr);
        }
        _ptr = ptr;
        _need_release = false;
        _native.value = (int)(_ptr - MetaMod.GlobalVars.StringBase);

    }
    public void SetString(string str)
    {
        if (_need_release)
        {
            Marshal.FreeHGlobal(_ptr);
        }
        _ptr = Marshal.StringToHGlobalAnsi(str);
        _need_release = true;
        _native.value = (int)(_ptr - MetaMod.GlobalVars.StringBase);
    }

    public override string ToString()
    {
        return GetString();
    }

    public string GetString()
    {
        nint ptr = MetaMod.GlobalVars.StringBase + _native.value;
        return Marshal.PtrToStringUTF8(ptr) ?? string.Empty;
    }

    ~StringHandle()
    {
        if (_need_release)
        {
            Marshal.FreeHGlobal(_ptr);
        }
    }
}
