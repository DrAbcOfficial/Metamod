using Metamod.Enum.Metamod;
using Metamod.Interface;
using Metamod.Interface.Events;
using Metamod.Wrapper.Metamod;

namespace Metamod.Template;

/// <summary>
/// Plugin entry point: the name must be Plugin and must inherit from the IPlugin interface.
/// </summary>
public class Plugin : IPlugin
{
    /// <summary>
    /// Plugin information: it is recommended to set it as static to maintain memory availability.
    /// </summary>
    private readonly static MetaPluginInfo _pluginInfo = new()
    {
        InterfaceVersion = InterfaceVersion.V5_16,
        Name = "Fuck World",
        Version = "1.0",
        Author = "Dr.Abc",
        Date = "2024/12/28",
        LogTag = "C#FUCK",
        Url = "github.com",
        Loadable = PluginLoadTime.PT_ANYTIME,
        Unloadable = PluginLoadTime.PT_ANYTIME
    };

    public MetaPluginInfo GetPluginInfo()
    {
        return _pluginInfo;
    }

    public void Meta_Init()
    {

    }

    public bool Meta_Query(InterfaceVersion interfaceVersion, MetaUtilFunctions pMetaUtilFuncs)
    {
        if (interfaceVersion != _pluginInfo.InterfaceVersion)
            return false;
        return true;
    }

    public bool Meta_Attach(PluginLoadTime now, MetaGlobals pMGlobals, MetaGameDLLFunctions pGamedllFuncs)
    {
        // Add Command
        MetaMod.EngineFuncs.AddServerCommand("fuck", () =>
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

        // Events
        DLLEvents _entityapiEvents = new();
        _entityapiEvents.GameInit += () =>
        {
            MetaMod.EngineFuncs.ServerPrint("Game Initialized!\n");
            MetaMod.MetaGlobals.Result = MetaResult.MRES_IGNORED;
        };
        // With Events, you can set more than one trigger
        _entityapiEvents.GameInit += () =>
        {
            MetaMod.EngineFuncs.ServerPrint("……And fuck the world!\n");
        };
        // Register
        MetaMod.RegisterEvents(entityApi: _entityapiEvents);
        return true;
    }

    public bool Meta_Detach(PluginLoadTime now, PluginUnloadReason reason)
    {
        return true;
    }
}
