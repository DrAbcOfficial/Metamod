using Metamod.Enum.Metamod;
using Metamod.Wrapper.Metamod;

namespace Metamod.Interface;

public interface IPlugin
{
    MetaPluginInfo GetPluginInfo();
    void Meta_Init();
    bool Meta_Query(InterfaceVersion interfaceVersion, MetaUtilFunctions pMetaUtilFuncs);
    bool Meta_Attach(PluginLoadTime now, MetaGlobals pMGlobals, MetaGameDLLFunctions pGamedllFuncs);
    bool Meta_Detach(PluginLoadTime now, PluginUnloadReason reason);
}
