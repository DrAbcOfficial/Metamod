using Metamod.Native.Metamod;

namespace Metamod.Interface;

public delegate int GetEntityAPIDelegate(IDllFunctions pFunctionTable, int interfaceVersion);
public delegate int GetEntityAPI2Delegate(IDllFunctions pFunctionTable, int interfaceVersion);
public delegate int GetNewDllFunctions(INewDllFunctions pFunctionTable, int interfaceVersion);
public delegate int GetEngineFunctions(IEngineFunctions pFunctionTable, int interfaceVersion);
public delegate int GetStudioBlendingInterfaceDelegate(IBlendingInterface pStudioBlendingInterface, int  interfaceVersion);
public interface IMetaFunctions
{
    public GetEntityAPIDelegate? pfnGetEntityAPI { get; set; }
    public GetEntityAPIDelegate? pfnGetEntityAPI_Post { get;set; }
    public GetEntityAPI2Delegate? pfnGetEntityAPI2 { get; set; }
    public GetEntityAPI2Delegate? pfnGetENtityAPI2_Post { get; set; }
    public GetNewDllFunctions? pfnGetNewDllFunctions { get; set; }
    public GetNewDllFunctions? pfnGetNewDllFunctions_Post { get; set; }
    public GetEngineFunctions? pfnGetEngineFunctions { get; set; }
    public GetEngineFunctions? pfnGetEngineFunctions_Post { get; set; }
    public GetStudioBlendingInterfaceDelegate? pfnGetBlendingInterface { get; set; }
    public GetStudioBlendingInterfaceDelegate? pfnGetBlendingInterface_Post { get; set; }
}
