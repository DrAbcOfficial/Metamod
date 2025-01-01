using Metamod.Enum.Metamod;
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
        public bool Meta_Attach(PluginLoadTime now, MetaGlobals pMGlobals, GameDllFuncs pGamedllFuncs)
        {
            //There's no function table as args, but you still need set it up here
            //No need set it from MetaFuncsions, its static
            DllFunctions_Post.pfnServerActivate = (Edict pEdictList, int edictCount, int clientMax) =>
            {
                Global.EngineFuncs.ServerPrint("World Fucker!\n");
            };
            DllFunctions_Post.pfnClientConnect = (Edict pEntity, string szName, string pszAddress, ref string szRejectReason) =>
            {
                Global.EngineFuncs.ServerPrint($"{szName} Just connected\n");
                return true;
            };
            


            Global.EngineFuncs.AddServerCommand("cs_fuck", () =>
            {
                Global.EngineFuncs.ServerPrint("Fuck World!\n");
            });
            return true;
        }
        public bool Meta_Detach(PluginLoadTime now, PluginUnloadReason reason)
        {
            return true;
        }
    }
}
