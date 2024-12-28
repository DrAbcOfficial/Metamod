using Metamod.Interface;

namespace Metamod;

public static class Metamod
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
        set
        {
            pluginInterface = value;
        }
    }
}
