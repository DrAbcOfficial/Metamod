using Metamod.Native.Engine;
using Metamod.Native.Game;
using System.Runtime.InteropServices;

namespace Metamod.Native.Metamod;

// 定义委托
#pragma warning disable CS8500 // 这会获取托管类型的地址、获取其大小或声明指向它的指针
internal unsafe delegate int GetEntityApiDelegate(NativeDllFuncs* pFunctionTable, int interfaceVersion);
internal unsafe delegate int GetEntityApi2Delegate(NativeDllFuncs* pFunctionTable, int* interfaceVersion);
internal unsafe delegate int GetNewDllFunctionsDelegate(NativeNewDllFuncs* pFunctionTable, int* interfaceVersion);
internal unsafe delegate int GetEngineFunctionsDelegate(NativeEngineFuncs* pengfuncsFromEngine, int* interfaceVersion);
internal unsafe delegate int GetStudioBlendingInterfaceDelegate(NativeServerBlendInterface* pStudioBlendingInterface, int* interfaceVersion);
#pragma warning restore CS8500 // 这会获取托管类型的地址、获取其大小或声明指向它的指针
[StructLayout(LayoutKind.Sequential)]
internal struct NativeMetaFuncs
{
    internal GetEntityApiDelegate pfnGetEntityAPI;
    internal GetEntityApiDelegate pfnGetEntityAPI_Post;
    internal GetEntityApi2Delegate pfnGetEntityAPI2;
    internal GetEntityApi2Delegate pfnGetEntityAPI2_Post;
    internal GetNewDllFunctionsDelegate pfnGetNewDLLFunctions;
    internal GetNewDllFunctionsDelegate pfnGetNewDLLFunctions_Post;
    internal GetEngineFunctionsDelegate pfnGetEngineFunctions;
    internal GetEngineFunctionsDelegate pfnGetEngineFunctions_Post;
    internal GetStudioBlendingInterfaceDelegate pfnGetStudioBlendingInterface;
    internal GetStudioBlendingInterfaceDelegate pfnGetStudioBlendingInterface_Post;
}
