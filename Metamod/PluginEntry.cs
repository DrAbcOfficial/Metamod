using Metamod.Interface;
using Metamod.Struct.Metamod;

namespace Metamod;

public static class PluginEntry
{
    private static IPlugin? pluginInterface;
    public static IPlugin Plugin
    {
        get
        {
            if (pluginInterface == null)
                throw new Exception("Plugin interface is null!");
            return pluginInterface;
        }
        set => pluginInterface = value;
    }

    private static PluginInfo? pluginInfo;
    public static PluginInfo PluginInfo
    {
        get
        {
            if (pluginInfo == null)
                throw new Exception("Plugin info is null!");
            return pluginInfo;
        }
        set => pluginInfo = value;
    }
}