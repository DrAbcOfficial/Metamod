using Metamod.Native.Engine;
using System.Runtime.InteropServices;

namespace Metamod.Struct.Engine;

public class CEngineFuncs(nint ptr) : BaseManaged<NativeEngineFuncs>(ptr)
{
    public void PrecacheModel(string s)
    {
        nint ns = Marshal.StringToHGlobalAnsi(s);
        _native.pfnPrecacheModel(ns);
        Marshal.FreeHGlobal(ns);
    }

    public void PrecacheSound(string s)
    {
        nint ns = Marshal.StringToHGlobalAnsi(s);
        _native.pfnPrecacheSound(ns);
        Marshal.FreeHGlobal(ns);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void ServerCommandDelegate();
    public void AddServerCommand(string cmd_name, ServerCommandDelegate function)
    {
        nint func = Marshal.GetFunctionPointerForDelegate(function);
        nint cmd = Marshal.StringToHGlobalAnsi(cmd_name);
        unsafe
        {
            _native.pfnAddServerCommand((byte*)cmd, func);
        }
        Marshal.FreeHGlobal(cmd);
    }

    public void ServerPrint(string msg)
    {
        nint nmsg = Marshal.StringToHGlobalAnsi(msg);
        _native.pfnServerPrint(nmsg);
        Marshal.FreeHGlobal(nmsg);
    }
}
