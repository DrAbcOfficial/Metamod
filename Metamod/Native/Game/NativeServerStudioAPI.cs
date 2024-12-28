﻿using System.Runtime.InteropServices;

namespace Metamod.Native.Game;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate nint Mem_CallocDelegate(int number, uint size);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate nint Cache_CheckDelegate(nint cacheUser);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal unsafe delegate void LoadCacheFileDelegate(byte* path, nint cacheUser);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate nint Mod_ExtradataDelegate(nint model);
[StructLayout(LayoutKind.Sequential)]
internal struct NativeServerStudioAPI
{
    internal Mem_CallocDelegate Mem_Calloc;
    internal Cache_CheckDelegate Cache_Check;
    internal LoadCacheFileDelegate LoadCacheFile;
    internal Mod_ExtradataDelegate Mod_Extradata;
}
