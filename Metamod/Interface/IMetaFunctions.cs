using Metamod.Native.Game;
using Metamod.Native.Metamod;
using System.Runtime.InteropServices;

namespace Metamod.Interface;

public delegate int GetEntityAPIDelegate(IDllFunctions pFunctionTable, int interfaceVersion);
public delegate int GetEntityAPI2Delegate(IDllFunctions pFunctionTable, int interfaceVersion);
public delegate int GetNewDllFunctions(CNewDllFunctions pFunctionTable, int interfaceVersion);
public delegate int GetEngineFunctions(IEngineFunctions pFunctionTable, int interfaceVersion);
public delegate int GetStudioBlendingInterfaceDelegate(IBlendingInterface pStudioBlendingInterface, int interfaceVersion);
public interface IMetaFunctions
{
    public GetEntityAPIDelegate? pfnGetEntityAPI { get; set; }
    public GetEntityAPIDelegate? pfnGetEntityAPI_Post { get; set; }
    public GetEntityAPI2Delegate? pfnGetEntityAPI2 { get; set; }
    public GetEntityAPI2Delegate? pfnGetENtityAPI2_Post { get; set; }
    public GetNewDllFunctions? pfnGetNewDllFunctions { get; set; }
    public GetNewDllFunctions? pfnGetNewDllFunctions_Post { get; set; }
    public GetEngineFunctions? pfnGetEngineFunctions { get; set; }
    public GetEngineFunctions? pfnGetEngineFunctions_Post { get; set; }
    public GetStudioBlendingInterfaceDelegate? pfnGetBlendingInterface { get; set; }
    public GetStudioBlendingInterfaceDelegate? pfnGetBlendingInterface_Post { get; set; }
}

#pragma warning disable CS8500 // 这会获取托管类型的地址、获取其大小或声明指向它的指针
internal class CMetaFunctionsWrapper(IMetaFunctions inf)
{
    internal IMetaFunctions Interface = inf;

    internal NativeGetEntityApiDelegate GetEntityAPIWrapper = (nint pFunctionTable, int interfaceVersion) =>
    {
        unsafe
        {
            NativeDllFuncs* funcs = (NativeDllFuncs*)pFunctionTable;

        }
    };

    internal NativeGetNewDllFunctionsDelegate GetNewDllFunctionsWrapper = (nint pFunctionTable, nint interfaceVersion) =>
    {
        int res = 0;
        unsafe
        {
            NativeNewDllFuncs nfuncs = CNewDllFunctions.GetNativeTable();
            NativeNewDllFuncs* funcs = (NativeNewDllFuncs*)pFunctionTable;
            funcs->pfnOnFreeEntPrivateData = CNewDllFunctions.nativeOnFreeEntPrivateDataCaller;
            funcs->pfnGameShutdown = CNewDllFunctions.nativeGameShutdown;
            funcs->pfnShouldCollide = CNewDllFunctions.nativeShouldCollide;
            funcs->pfnCvarValue = CNewDllFunctions.nativeCvarValue;
            funcs->pfnCvarValue2 = CNewDllFunctions.nativeCvarValue2;
            res = 1;
        }
        return 0;
    };
}
#pragma warning restore CS8500 // 这会获取托管类型的地址、获取其大小或声明指向它的指针