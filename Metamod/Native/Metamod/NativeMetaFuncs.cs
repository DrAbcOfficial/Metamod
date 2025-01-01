﻿using Metamod.Native.Engine;
using Metamod.Native.Game;
using System.Runtime.InteropServices;

namespace Metamod.Native.Metamod;

// 定义委托

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate int NativeGetEntityApiDelegate(nint pFunctionTable, int interfaceVersion);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal unsafe delegate int NativeGetEntityApi2Delegate(nint pFunctionTable, nint interfaceVersion);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate int NativeGetNewDllFunctionsDelegate(nint pFunctionTable, nint interfaceVersion);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal unsafe delegate int NativeGetEngineFunctionsDelegate(NativeEngineFuncs* pengfuncsFromEngine, int* interfaceVersion);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal unsafe delegate int NativeGetStudioBlendingInterfaceDelegate(NativeServerBlendInterface* pStudioBlendingInterface, int* interfaceVersion);

[StructLayout(LayoutKind.Sequential)]
public struct NativeMetaFuncs
{
    internal NativeGetEntityApiDelegate pfnGetEntityAPI;
    internal NativeGetEntityApiDelegate pfnGetEntityAPI_Post;
    internal NativeGetEntityApi2Delegate pfnGetEntityAPI2;
    internal NativeGetEntityApi2Delegate pfnGetEntityAPI2_Post;
    internal NativeGetNewDllFunctionsDelegate pfnGetNewDLLFunctions;
    internal NativeGetNewDllFunctionsDelegate pfnGetNewDLLFunctions_Post;
    internal NativeGetEngineFunctionsDelegate pfnGetEngineFunctions;
    internal NativeGetEngineFunctionsDelegate pfnGetEngineFunctions_Post;
    internal NativeGetStudioBlendingInterfaceDelegate pfnGetStudioBlendingInterface;
    internal NativeGetStudioBlendingInterfaceDelegate pfnGetStudioBlendingInterface_Post;
}
