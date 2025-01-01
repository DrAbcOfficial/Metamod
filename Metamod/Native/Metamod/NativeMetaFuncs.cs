using Metamod.Native.Engine;
using Metamod.Native.Game;
using System.Runtime.InteropServices;

namespace Metamod.Native.Metamod;

// 定义委托
#pragma warning disable CS8500 // 这会获取托管类型的地址、获取其大小或声明指向它的指针
internal unsafe delegate int NativeGetEntityApiDelegate(NativeDllFuncs* pFunctionTable, int interfaceVersion);
internal unsafe delegate int NativeGetEntityApi2Delegate(NativeDllFuncs* pFunctionTable, int* interfaceVersion);
internal unsafe delegate int NativeGetNewDllFunctionsDelegate(NativeNewDllFuncs* pFunctionTable, int* interfaceVersion);
internal unsafe delegate int NativeGetEngineFunctionsDelegate(NativeEngineFuncs* pengfuncsFromEngine, int* interfaceVersion);
internal unsafe delegate int NativeGetStudioBlendingInterfaceDelegate(NativeServerBlendInterface* pStudioBlendingInterface, int* interfaceVersion);
#pragma warning restore CS8500 // 这会获取托管类型的地址、获取其大小或声明指向它的指针
[StructLayout(LayoutKind.Sequential)]
internal struct NativeMetaFuncs
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
