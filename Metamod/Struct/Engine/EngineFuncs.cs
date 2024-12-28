using Metamod.Native.Engine;
using System.Runtime.InteropServices;

namespace Metamod.Struct.Engine;

public class EngineFuncs
{
    internal NativeEngineFuncs native;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void ServerCommandDelegate();
    public void AddServerCommand(string cmd_name, ServerCommandDelegate function)
    {
        nint func = Marshal.GetFunctionPointerForDelegate(function);
        nint cmd = Marshal.StringToHGlobalAnsi(cmd_name);
        unsafe
        {
            native.pfnAddServerCommand((byte*)cmd, func);
        }
        Marshal.FreeHGlobal(cmd);
    }

    public void ServerPrint(string msg)
    {
        nint nmsg = Marshal.StringToHGlobalAnsi(msg);
        unsafe
        {
            native.pfnServerPrint(nmsg);
        }
        Marshal.FreeHGlobal(nmsg);
    }
}
