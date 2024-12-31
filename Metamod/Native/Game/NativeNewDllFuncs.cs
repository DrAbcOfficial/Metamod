using System.Runtime.InteropServices;

namespace Metamod.Native.Game;

internal delegate void OnFreeEntPrivateDataDelegate(nint pEnt);
internal delegate void GameShutdownDelegate();
internal delegate int ShouldCollideDelegate(nint pentTouched, nint pentOther);
internal delegate void CvarValueDelegate(nint pEnt, nint value);
internal delegate void CvarValue2Delegate(nint pEnt, int requestID, nint cvarName, nint value);

[StructLayout(LayoutKind.Sequential)]
public struct NativeNewDllFuncs
{
    // Called right before the object's memory is freed. 
    // Calls its destructor.
    internal OnFreeEntPrivateDataDelegate pfnOnFreeEntPrivateData;
    internal GameShutdownDelegate pfnGameShutdown;
    internal ShouldCollideDelegate pfnShouldCollide;
    // Added 2005/08/11 (no SDK update):
    internal CvarValueDelegate pfnCvarValue;
    // Added 2005/11/21 (no SDK update):
    //    value is "Bad CVAR request" on failure (i.e that user is not connected or the cvar does not exist).
    //    value is "Bad Player" if invalid player edict.
    internal CvarValue2Delegate pfnCvarValue2;
}
