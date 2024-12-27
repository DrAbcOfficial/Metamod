using System.Runtime.InteropServices;

namespace Metamod.Struct.Engine;

internal struct EngineFuncsDelegate
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int PrecacheModelDelegate(nint s);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int PrecacheSoundDelegate(nint s);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetModelDelegate(nint e, nint m);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int ModelIndexDelegate(nint m);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int ModelFramesDelegate(int modelIndex);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetSizeDelegate(nint e, nint rgflMin, nint rgflMax);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void ChangeLevelDelegate(nint s1, nint s2);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void GetSpawnParmsDelegate(nint ent);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void SaveSpawnParmsDelegate(nint ent);
}
