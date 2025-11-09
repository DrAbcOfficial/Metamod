using Metamod.Helper;
using Metamod.Struct.Engine;
using Metamod.Struct.Metamod;

namespace Metamod.Interface
{
    public static class Global
    {
#pragma warning disable CS8618
        public static readonly EngineFuncs EngineFuncs;
        public static readonly GlobalVars GlobalVars;
        public static readonly Utility Utility;
        public static readonly MetaUtilFuncs MetaUtilFuncs;
        public static readonly PluginInfo PluginInfo;
        public static readonly MetaGlobals MetaGlobals;
        public static readonly GameDllFuncs GameDllFuncs;
#pragma warning restore CS8618
    }
}
