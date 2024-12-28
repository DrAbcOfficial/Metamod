﻿using Metamod.Enum.Metamod;

namespace Metamod.Interface;

public interface IPlugin
{
    void GiveFnptrsToDll(nint pengfuncsFromEngine, nint pGlobals);

    void Meta_Init();
    bool Meta_Query(InterfaceVersion interfaceVersion, nint pMetaUtilFuncs);
    bool Meta_Attach(PluginLoadTime now, nint pFunctionTable, nint pMGlobals, nint pGamedllFuncs);
    bool Meta_Detach(PluginLoadTime now, PluginUnloadReason reason);

    bool GetEntityAPI(nint pFunctionTable, InterfaceVersion interfaceVersion);
    bool GetEntityAPI2(nint pFunctionTable, InterfaceVersion interfaceVersion);
    bool GetNewDLLFunctions(nint pNewFunctionTable, InterfaceVersion interfaceVersion);
    bool GetEntityAPI_Post(nint pFunctionTable, InterfaceVersion interfaceVersion);
    bool GetEntityAPI2_Post(nint pFunctionTable, InterfaceVersion interfaceVersion);
    bool GetNewDLLFunctions_Post(nint pNewFunctionTable, InterfaceVersion interfaceVersion);
    bool GetEngineFunctions(nint pengfuncsFromEngine, InterfaceVersion interfaceVersion);
    bool GetEngineFunctions_Post(nint pengfuncsFromEngine, InterfaceVersion interfaceVersion);
}
