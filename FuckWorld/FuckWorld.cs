using Metamod.Enum.Metamod;
using Metamod.Interface;
using Metamod.Struct.Engine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FuckWorld
{
    public class Plugin : IPlugin
    {
        private EngineFuncs pEngineFuncs;
        public void GiveFnptrsToDll(EngineFuncs pengfuncsFromEngine, nint pGlobals)
        {
            pEngineFuncs = pengfuncsFromEngine;
        }

        public void Meta_Init()
        {

        }
        public bool Meta_Query(InterfaceVersion interfaceVersion, nint pMetaUtilFuncs)
        {
            return true;
        }
        public bool Meta_Attach(PluginLoadTime now, nint pFunctionTable, nint pMGlobals, nint pGamedllFuncs)
        {
            pEngineFuncs.AddServerCommand("cs_fuck", ()=> {
                pEngineFuncs.ServerPrint("Fuck World!");
            } );
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

    public class FuckWorld : PluginEntry
    {
        static FuckWorld()
        {
            Interface = new Plugin();
            Info = new()
            {
                InterfaceVersion = InterfaceVersion.V5_16,
                Name = "C# Fuck World",
                Version = "1.0",
                Author = "Dr.Abc",
                Date = "2024/12/28",
                LogTag = "C#FUCK",
                Url = "github.com",
                Loadable = PluginLoadTime.PT_ANYTIME,
                Unloadable = PluginLoadTime.PT_ANYTIME
            };
        }

        [UnmanagedCallersOnly(EntryPoint = "GiveFnptrsToDll")]
        protected static new void Native_GiveFnptrsToDll(nint pengfuncsFromEngine, nint pGlobals)
        {
            PluginEntry.Native_GiveFnptrsToDll(pengfuncsFromEngine, pGlobals);
        }

        [UnmanagedCallersOnly(EntryPoint = "Meta_Init", CallConvs = [typeof(CallConvCdecl)])]
        protected static new void Native_Meta_Init()
        {
            PluginEntry.Native_Meta_Init();
        }

        [UnmanagedCallersOnly(EntryPoint = "Meta_Query", CallConvs = [typeof(CallConvCdecl)])]
        protected static new int Native_Meta_Query(nint interfaceVersion, nint plinfo, nint pMetaUtilFuncs)
        {
            return PluginEntry.Native_Meta_Query(interfaceVersion, plinfo, pMetaUtilFuncs);
        }

        [UnmanagedCallersOnly(EntryPoint = "Meta_Attach", CallConvs = [typeof(CallConvCdecl)])]
        protected static new int Native_Meta_Attach(PluginLoadTime now, nint pFunctionTable, nint pMGlobals, nint pGamedllFuncs)
        {
            return PluginEntry.Native_Meta_Attach(now, pFunctionTable, pMGlobals, pGamedllFuncs);
        }

        [UnmanagedCallersOnly(EntryPoint = "Meta_Detach", CallConvs = [typeof(CallConvCdecl)])]
        protected static new int Native_Meta_Detach(PluginLoadTime now, PluginUnloadReason reason)
        {
            return PluginEntry.Native_Meta_Detach(now, reason);
        }

        [UnmanagedCallersOnly(EntryPoint = "GetEntityAPI", CallConvs = [typeof(CallConvCdecl)])]
        protected static new int Native_GetEntityAPI(nint pFunctionTable, int interfaceVersion)
        {
            return PluginEntry.Native_GetEntityAPI(pFunctionTable, interfaceVersion);
        }

        [UnmanagedCallersOnly(EntryPoint = "GetEntityAPI2", CallConvs = [typeof(CallConvCdecl)])]
        protected static new int Native_GetEntityAPI2(nint pFunctionTable, nint interfaceVersion)
        {
            return PluginEntry.Native_GetEntityAPI2(pFunctionTable, interfaceVersion);
        }

        [UnmanagedCallersOnly(EntryPoint = "GetNewDLLFunctions", CallConvs = [typeof(CallConvCdecl)])]
        protected static new int Native_GetNewDLLFunctions(nint pNewFunctionTable, nint interfaceVersion)
        {
            return PluginEntry.Native_GetNewDLLFunctions(pNewFunctionTable, interfaceVersion);
        }

        [UnmanagedCallersOnly(EntryPoint = "GetEntityAPI_Post", CallConvs = [typeof(CallConvCdecl)])]
        protected static new int Native_GetEntityAPI_Post(nint pFunctionTable, nint interfaceVersion)
        {
            return PluginEntry.Native_GetEntityAPI_Post(pFunctionTable, interfaceVersion);
        }

        [UnmanagedCallersOnly(EntryPoint = "GetEntityAPI2_Post", CallConvs = [typeof(CallConvCdecl)])]
        protected static new int Native_GetEntityAPI2_Post(nint pFunctionTable, nint interfaceVersion)
        {
            return PluginEntry.Native_GetEntityAPI2_Post(pFunctionTable, interfaceVersion);
        }

        [UnmanagedCallersOnly(EntryPoint = "GetNewDLLFunctions_Post", CallConvs = [typeof(CallConvCdecl)])]
        protected static new int Native_GetNewDLLFunctions_Post(nint pNewFunctionTable, nint interfaceVersion)
        {
            return PluginEntry.Native_GetNewDLLFunctions_Post(pNewFunctionTable, interfaceVersion);
        }

        [UnmanagedCallersOnly(EntryPoint = "GetEngineFunctions", CallConvs = [typeof(CallConvCdecl)])]
        protected static new int Native_GetEngineFunctions(nint pengfuncsFromEngine, nint interfaceVersion)
        {
            return PluginEntry.Native_GetEngineFunctions(pengfuncsFromEngine, interfaceVersion);
        }

        [UnmanagedCallersOnly(EntryPoint = "GetEngineFunctions_Post", CallConvs = [typeof(CallConvCdecl)])]
        protected static new int Native_GetEngineFunctions_Post(nint pengfuncsFromEngine, nint interfaceVersion)
        {
            return PluginEntry.Native_GetEngineFunctions_Post(pengfuncsFromEngine, interfaceVersion);
        }
    }
}
