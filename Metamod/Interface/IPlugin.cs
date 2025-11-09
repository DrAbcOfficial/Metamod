using Metamod.Enum.Metamod;
using Metamod.Struct.Engine;
using Metamod.Struct.Metamod;

namespace Metamod.Interface;

public interface IPlugin
{
    PluginInfo GetPluginInfo();
    void GiveFnptrsToDll(EngineFuncs pengfuncsFromEngine, GlobalVars pGlobals);

    void Meta_Init();
    bool Meta_Query(InterfaceVersion interfaceVersion, MetaUtilFuncs pMetaUtilFuncs);
    bool Meta_Attach(PluginLoadTime now, MetaGlobals pMGlobals, GameDllFuncs pGamedllFuncs);
    bool Meta_Detach(PluginLoadTime now, PluginUnloadReason reason);
}
