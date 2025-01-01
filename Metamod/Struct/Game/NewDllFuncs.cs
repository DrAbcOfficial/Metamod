using Metamod.Native.Game;
using Metamod.Struct.Engine;
using System.Runtime.InteropServices;

namespace Metamod.Struct.Game;

public class NewDllFuncs : BaseManaged<NativeNewDllFuncs>
{
    internal NewDllFuncs(nint ptr) : base(ptr) { }
    // Called right before the object's memory is freed. 
    // Calls its destructor.
    public void OnFreeEntPrivateData(Edict pEnt) => _native.pfnOnFreeEntPrivateData(pEnt.GetUnmanagedPtr());
    public void GameShutdown() => _native.pfnGameShutdown();
    public int ShouldCollide(Edict pentTouched, Edict pentOther) => _native.pfnShouldCollide(pentTouched.GetUnmanagedPtr(), pentOther.GetUnmanagedPtr());
    // Added 2005/08/11 (no SDK update):
    public void CvarValue(Edict pEnt, string value)
    {
        nint ns = Marshal.StringToHGlobalAnsi(value);
        _native.pfnCvarValue(pEnt.GetUnmanagedPtr(), ns);
        Marshal.FreeHGlobal(ns);
    }
    // Added 2005/11/21 (no SDK update):
    //    value is "Bad CVAR request" on failure (i.e that user is not connected or the cvar does not exist).
    //    value is "Bad Player" if invalid player edict.
    public void CvarValue2(Edict pEnt, int requestID, string cvarName, string value)
    {
        nint ns1 = Marshal.StringToHGlobalAnsi(cvarName);
        nint ns2 = Marshal.StringToHGlobalAnsi(value);
        _native.pfnCvarValue2(pEnt.GetUnmanagedPtr(), requestID, ns1, ns2);
        Marshal.FreeHGlobal(ns1);
        Marshal.FreeHGlobal(ns2);
    }
}
