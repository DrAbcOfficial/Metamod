using Metamod.Enum.Metamod;

namespace Metamod.Interface;

public interface IPlugin
{
    void GiveFnptrsToDll(nint pengfuncsFromEngine, nint pGlobals);

    void Meta_Init();
    bool Meta_Query(InterfaceVersion interfaceVersion, nint pMetaUtilFuncs);
    bool Meta_Attach(PluginLoadTime now, nint pFunctionTable, nint pMGlobals, nint pGamedllFuncs);
    bool Meta_Detach(PluginLoadTime now, PluginUnloadReason reason);

    bool GetEntityAPI(nint pFunctionTable, int interfaceVersion);
    bool GetEntityAPI2(nint pFunctionTable, int interfaceVersion);
    bool GetNewDLLFunctions(nint pNewFunctionTable, int interfaceVersion);
    bool GetEntityAPI_Post(nint pFunctionTable, int interfaceVersion);
    bool GetEntityAPI2_Post(nint pFunctionTable, int interfaceVersion);
    bool GetNewDLLFunctions_Post(nint pNewFunctionTable, int interfaceVersion);
    bool GetEngineFunctions(nint pengfuncsFromEngine, int interfaceVersion);
    bool GetEngineFunctions_Post(nint pengfuncsFromEngine, int interfaceVersion);
}
