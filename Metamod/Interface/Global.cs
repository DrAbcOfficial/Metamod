using Metamod.Helper;
using Metamod.Struct.Engine;
using Metamod.Struct.Metamod;

namespace Metamod.Interface
{
    public static class Global
    {
#pragma warning disable CS8618
        public static CEngineFuncs EngineFuncs;
        public static CGlobalVars GlobalVars;
        public static CUtility Utility;
        public static CMetaUtilFuncs MetaUtilFuncs;
        public static PluginInfo PluginInfo;
#pragma warning restore CS8618
    }
}
