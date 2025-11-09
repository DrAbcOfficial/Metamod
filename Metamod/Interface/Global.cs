using Metamod.Helper;
using Metamod.Struct.Engine;
using Metamod.Struct.Metamod;

namespace Metamod.Interface
{
    public static class Global
    {
#pragma warning disable CS8618
        public static EngineFuncs EngineFuncs => _engineFuncs;
        public static GlobalVars GlobalVars => _globalVars;
        public static Utility Utility => _utility;
        public static MetaUtilFuncs MetaUtilFuncs => _metaUtilFuncs;
        public static PluginInfo PluginInfo => _pluginInfo;
        public static MetaGlobals MetaGlobals => _metaGlobals;
        public static GameDllFuncs GameDllFuncs => _gameDllFuncs;

        internal static EngineFuncs _engineFuncs;
        internal static GlobalVars _globalVars;
        internal static Utility _utility;
        internal static MetaUtilFuncs _metaUtilFuncs;
        internal static PluginInfo _pluginInfo;
        internal static MetaGlobals _metaGlobals;
        internal static GameDllFuncs _gameDllFuncs;
#pragma warning restore CS8618
    }
}
