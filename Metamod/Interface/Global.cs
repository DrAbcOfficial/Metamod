using Metamod.Helper;
using Metamod.Struct.Engine;

namespace Metamod.Interface
{
    public static class Global
    {
#pragma warning disable CS8618
        public static CEngineFuncs EngineFuncs;
        public static CGlobalVars GlobalVars;
        public static CUtility Utility;
#pragma warning restore CS8618
    }
}
