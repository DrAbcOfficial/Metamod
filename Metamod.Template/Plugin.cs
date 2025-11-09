using Metamod.Enum.Metamod;
using Metamod.Interface;
using Metamod.Struct.Engine;
using Metamod.Struct.Metamod;

namespace Metamod.Template;

public class Plugin : IPlugin
{
    private readonly static PluginInfo _pluginInfo = new()
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
    public void GiveFnptrsToDll(EngineFuncs pengfuncsFromEngine, GlobalVars pGlobals)
    {

    }

    public void Meta_Init()
    {

    }
    public bool Meta_Query(InterfaceVersion interfaceVersion, MetaUtilFuncs pMetaUtilFuncs)
    {
        return true;
    }
    public bool Meta_Attach(PluginLoadTime now, MetaGlobals pMGlobals, GameDllFuncs pGamedllFuncs)
    {
        Global.EngineFuncs.AddServerCommand("cs_fuck", () =>
        {
            Global.EngineFuncs.ServerPrint("Fuck World!\n");
            Global.EngineFuncs.ServerPrint($"Plugin Info:\n" +
                $"{(nameof(Global.PluginInfo.InterfaceVersion))}:{Global.PluginInfo.InterfaceVersion}\n" +
                $"{(nameof(Global.PluginInfo.Name))}:{Global.PluginInfo.Name}\n" +
                $"{(nameof(Global.PluginInfo.Version))}:{Global.PluginInfo.Version}\n" +
                $"{(nameof(Global.PluginInfo.Date))}:{Global.PluginInfo.Date}\n" +
                $"{(nameof(Global.PluginInfo.Author))}:{Global.PluginInfo.Author}\n" +
                $"{(nameof(Global.PluginInfo.Url))}:{Global.PluginInfo.Url}\n" +
                $"{(nameof(Global.PluginInfo.LogTag))}:{Global.PluginInfo.LogTag}\n" +
                $"{(nameof(Global.PluginInfo.Loadable))}:{Global.PluginInfo.Loadable}\n" +
                $"{(nameof(Global.PluginInfo.Unloadable))}:{Global.PluginInfo.Unloadable}\n");
        });
        return true;
    }
    public bool Meta_Detach(PluginLoadTime now, PluginUnloadReason reason)
    {
        return true;
    }
}
