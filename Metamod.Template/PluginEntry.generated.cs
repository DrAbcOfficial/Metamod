

using Metamod.Enum.Metamod;
using Metamod.Interface;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace  Metamod.Template
{
    /// <summary>
    /// 自动生成的插件入口类
    /// 切在该文件中修改，可能会被覆盖，请在 Plugin.cs 中实现自定义逻辑
    /// 基于 T4 模板生成，包含所有必要的非托管调用包装
    /// </summary>
    public class AutoGenPluginEntry : PluginEntry
    {
        static AutoGenPluginEntry()
        {
            // 初始化插件接口实例
            Interface = new Plugin();
        }

        /// <summary>
        /// 非托管入口：GiveFnptrsToDll
        /// 转发到基类的 Native_GiveFnptrsToDll 实现
        /// </summary>
        [UnmanagedCallersOnly(EntryPoint = "GiveFnptrsToDll")]
        public static void UnmanagedGiveFnptrsToDll(nint pengfuncsFromEngine, nint pGlobals)
        {
            Native_GiveFnptrsToDll(pengfuncsFromEngine, pGlobals);
        }

        /// <summary>
        /// 非托管入口：Meta_Init
        /// 转发到基类的 Native_Meta_Init 实现
        /// </summary>
        [UnmanagedCallersOnly(EntryPoint = "Meta_Init", CallConvs = [typeof(CallConvCdecl)])]
        public static void UnmanagedMeta_Init()
        {
            Native_Meta_Init();
        }

        /// <summary>
        /// 非托管入口：Meta_Query
        /// 转发到基类的 Native_Meta_Query 实现
        /// </summary>
        [UnmanagedCallersOnly(EntryPoint = "Meta_Query", CallConvs = [typeof(CallConvCdecl)])]
        public static int UnmanagedMeta_Query(nint interfaceVersion, nint plinfo, nint pMetaUtilFuncs)
        {
            return Native_Meta_Query(interfaceVersion, plinfo, pMetaUtilFuncs);
        }

        /// <summary>
        /// 非托管入口：Meta_Attach
        /// 转发到基类的 Native_Meta_Attach 实现
        /// </summary>
        [UnmanagedCallersOnly(EntryPoint = "Meta_Attach", CallConvs = [typeof(CallConvCdecl)])]
        public static int UnmanagedMeta_Attach(PluginLoadTime now, nint pFunctionTable, nint pMGlobals, nint pGamedllFuncs)
        {
            return Native_Meta_Attach(now, pFunctionTable, pMGlobals, pGamedllFuncs);
        }

        /// <summary>
        /// 非托管入口：Meta_Detach
        /// 转发到基类的 Native_Meta_Detach 实现
        /// </summary>
        [UnmanagedCallersOnly(EntryPoint = "Meta_Detach", CallConvs = [typeof(CallConvCdecl)])]
        public static int UnmanagedMeta_Detach(PluginLoadTime now, PluginUnloadReason reason)
        {
            return Native_Meta_Detach(now, reason);
        }
    }
}