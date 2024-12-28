﻿using Metamod.Native.Engine;
using System.Runtime.InteropServices;

namespace Metamod.Native.Game;

internal unsafe delegate void OnFreeEntPrivateDataDelegate(NativeEdict* pEnt);
internal unsafe delegate void GameShutdownDelegate();
internal unsafe delegate int ShouldCollideDelegate(NativeEdict* pentTouched, NativeEdict* pentOther);
internal unsafe delegate void CvarValueDelegate(NativeEdict* pEnt, byte* value);
internal unsafe delegate void CvarValue2Delegate(NativeEdict* pEnt, int requestID, byte* cvarName, byte* value);

[StructLayout(LayoutKind.Sequential)]
internal struct NativeNewDllFuncs
{
    // Called right before the object's memory is freed. 
    // Calls its destructor.
    OnFreeEntPrivateDataDelegate pfnOnFreeEntPrivateData;
    GameShutdownDelegate pfnGameShutdown;
    ShouldCollideDelegate pfnShouldCollide;
    // Added 2005/08/11 (no SDK update):
    CvarValueDelegate pfnCvarValue;
    // Added 2005/11/21 (no SDK update):
    //    value is "Bad CVAR request" on failure (i.e that user is not connected or the cvar does not exist).
    //    value is "Bad Player" if invalid player edict.
    CvarValue2Delegate pfnCvarValue2;
}
