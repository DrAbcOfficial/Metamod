using Metamod.Enum.Metamod;
using Metamod.Interface;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Metamod.FuckWorld
{
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
        public static void S_GiveFnptrsToDll(nint pengfuncsFromEngine, nint pGlobals)
        {
            Native_GiveFnptrsToDll(pengfuncsFromEngine, pGlobals);
        }

        [UnmanagedCallersOnly(EntryPoint = "Meta_Init", CallConvs = [typeof(CallConvCdecl)])]
        public static void S_Meta_Init()
        {
            Native_Meta_Init();
        }

        [UnmanagedCallersOnly(EntryPoint = "Meta_Query", CallConvs = [typeof(CallConvCdecl)])]
        public static int S_Meta_Query(nint interfaceVersion, nint plinfo, nint pMetaUtilFuncs)
        {
            return Native_Meta_Query(interfaceVersion, plinfo, pMetaUtilFuncs);
        }

        [UnmanagedCallersOnly(EntryPoint = "Meta_Attach", CallConvs = [typeof(CallConvCdecl)])]
        public static int S_Meta_Attach(PluginLoadTime now, nint pFunctionTable, nint pMGlobals, nint pGamedllFuncs)
        {
            return Native_Meta_Attach(now, pFunctionTable, pMGlobals, pGamedllFuncs);
        }

        [UnmanagedCallersOnly(EntryPoint = "Meta_Detach", CallConvs = [typeof(CallConvCdecl)])]
        public static int S_Meta_Detach(PluginLoadTime now, PluginUnloadReason reason)
        {
            return Native_Meta_Detach(now, reason);
        }
    }
}
