using Metamod.Enum.Metamod;
using Metamod.Interface;
using Metamod.Struct.Engine;
using Metamod.Struct.Metamod;

namespace Metamod.Template;

public class Plugin : IPlugin
{
    private readonly PluginInfo _pluginInfo = new()
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
    public PluginInfo GetPluginInfo()
    {
        return _pluginInfo;
    }
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
        DllFunctions_Post.pfnServerActivate = (pEdictList, edictCount, clientMax) =>
        {
            Global.EngineFuncs.ServerPrint("World Fucker!\n");
        };
        DllFunctions_Post.pfnClientConnect = (Edict pEntity, string pszName, string pszAddress, ref string szRejectReason) =>
        {
            Global.EngineFuncs.ServerPrint($"{pszName} Just came to fuck this world.\n");
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
