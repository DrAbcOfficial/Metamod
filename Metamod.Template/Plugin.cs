using Metamod.Enum.Metamod;
using Metamod.Interface;
using Metamod.Interface.Events;
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
        if (interfaceVersion != _pluginInfo.InterfaceVersion)
            return false;
        return true;
    }
    public bool Meta_Attach(PluginLoadTime now, MetaGlobals pMGlobals, GameDllFuncs pGamedllFuncs)
    {
        MetaMod.EngineFuncs.AddServerCommand("cs_fuck", () =>
        {
            MetaMod.EngineFuncs.ServerPrint("Fuck World!\n");
            MetaMod.EngineFuncs.ServerPrint($"Plugin Info:\n" +
                $"{(nameof(MetaMod.PluginInfo.InterfaceVersion))}:{MetaMod.PluginInfo.InterfaceVersion}\n" +
                $"{(nameof(MetaMod.PluginInfo.Name))}:{MetaMod.PluginInfo.Name}\n" +
                $"{(nameof(MetaMod.PluginInfo.Version))}:{MetaMod.PluginInfo.Version}\n" +
                $"{(nameof(MetaMod.PluginInfo.Date))}:{MetaMod.PluginInfo.Date}\n" +
                $"{(nameof(MetaMod.PluginInfo.Author))}:{MetaMod.PluginInfo.Author}\n" +
                $"{(nameof(MetaMod.PluginInfo.Url))}:{MetaMod.PluginInfo.Url}\n" +
                $"{(nameof(MetaMod.PluginInfo.LogTag))}:{MetaMod.PluginInfo.LogTag}\n" +
                $"{(nameof(MetaMod.PluginInfo.Loadable))}:{MetaMod.PluginInfo.Loadable}\n" +
                $"{(nameof(MetaMod.PluginInfo.Unloadable))}:{MetaMod.PluginInfo.Unloadable}\n");
        });
        DLLEvents _entityapiEvents = new();
        _entityapiEvents.GameInit += () =>
        {
            MetaMod.EngineFuncs.ServerPrint("Game Initialized!\n");
        };
        _entityapiEvents.ServerActivate += (edictList, edictCount, clientMax) =>
        {
            MetaMod.EngineFuncs.ServerPrint("Server Activated!\n");
        };
        EngineEvents _engine = new();
        _engine.PrecacheModel += (model) =>
        {
            MetaMod.MetaGlobals.Result = MetaResult.MRES_IGNORED;
            MetaMod.EngineFuncs.ServerPrint($"Precached {model}!\n");
            return 998;
        };
        MetaMod.RegisterEvents(entityApi: _entityapiEvents, engineFunctions: _engine);
        return true;
    }

    public bool Meta_Detach(PluginLoadTime now, PluginUnloadReason reason)
    {
        return true;
    }
}
