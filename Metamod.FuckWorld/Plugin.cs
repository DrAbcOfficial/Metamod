﻿using Metamod.Enum.Metamod;
using Metamod.Interface;
using Metamod.Struct.Engine;
using Metamod.Struct.Metamod;

namespace Metamod.FuckWorld
{
    public class Plugin : IPlugin
    {
        public void GiveFnptrsToDll(CEngineFuncs pengfuncsFromEngine, CGlobalVars pGlobals)
        {

        }

        public void Meta_Init()
        {

        }
        public bool Meta_Query(InterfaceVersion interfaceVersion, CMetaUtilFuncs pMetaUtilFuncs)
        {
            return true;
        }
        public bool Meta_Attach(PluginLoadTime now, nint pFunctionTable, MetaGlobals pMGlobals, nint pGamedllFuncs)
        {
            Global.EngineFuncs.AddServerCommand("cs_fuck", () =>
            {
                Global.EngineFuncs.ServerPrint("Fuck World!");
            });
            return true;
        }
        public bool Meta_Detach(PluginLoadTime now, PluginUnloadReason reason)
        {
            return true;
        }

        public bool GetEntityAPI(nint pFunctionTable, int interfaceVersion)
        {
            return true;
        }
        public bool GetEntityAPI2(nint pFunctionTable, int interfaceVersion)
        {
            return true;
        }
        public bool GetNewDLLFunctions(nint pNewFunctionTable, int interfaceVersion)
        {
            return true;
        }
        public bool GetEntityAPI_Post(nint pFunctionTable, int interfaceVersion)
        {
            return true;
        }
        public bool GetEntityAPI2_Post(nint pFunctionTable, int interfaceVersion)
        {
            return true;
        }
        public bool GetNewDLLFunctions_Post(nint pNewFunctionTable, int interfaceVersion)
        {
            return true;
        }
        public bool GetEngineFunctions(nint pengfuncsFromEngine, int interfaceVersion)
        {
            return true;
        }
        public bool GetEngineFunctions_Post(nint pengfuncsFromEngine, int interfaceVersion)
        {
            return true;
        }
    }
}