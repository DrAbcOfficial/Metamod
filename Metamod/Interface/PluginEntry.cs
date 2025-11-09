using Metamod.Enum.Metamod;
using Metamod.Native.Metamod;
using Metamod.Struct.Engine;
using Metamod.Struct.Metamod;
using System.Runtime.InteropServices;

namespace Metamod.Interface;

public abstract class PluginEntry
{
    protected static IPlugin? Interface;
    public static IPlugin GetPluginInterface()
    {
        if (Interface == null)
            throw new NullReferenceException(nameof(Interface));
        return Interface;
    }
    public static PluginInfo GetPluginInfo()
    {
        if (Interface == null)
            throw new NullReferenceException(nameof(Interface));
        return Interface.GetPluginInfo();
    }

    protected static void Native_GiveFnptrsToDll(nint pengfuncsFromEngine, nint pGlobals)
    {
        EngineFuncs engineFuncs = new(pengfuncsFromEngine);
        GlobalVars globalVars = new(pGlobals);
        Global._engineFuncs = engineFuncs;
        Global._globalVars = globalVars;
        Global._utility = new();

        var pinterface = GetPluginInterface();
        pinterface.GiveFnptrsToDll(engineFuncs, globalVars);
    }

    protected static void Native_Meta_Init()
    {

    }

    protected static int Native_Meta_Query(nint interfaceVersion, nint plinfo, nint pMetaUtilFuncs)
    {
        string? version = Marshal.PtrToStringAnsi(interfaceVersion) ?? throw new Exception("Interface version is null");
        var ifver = version switch
        {
            "1" => InterfaceVersion.V1,
            "2" => InterfaceVersion.V2,
            "3" => InterfaceVersion.V3,
            "4" => InterfaceVersion.V4,
            "5" => InterfaceVersion.V5,
            "5:1" => InterfaceVersion.V5_1,
            "5:2" => InterfaceVersion.V5_2,
            "5:3" => InterfaceVersion.V5_3,
            "5:4" => InterfaceVersion.V5_4,
            "5:5" => InterfaceVersion.V5_5,
            "5:6" => InterfaceVersion.V5_6,
            "5:7" => InterfaceVersion.V5_7,
            "5:8" => InterfaceVersion.V5_8,
            "5:9" => InterfaceVersion.V5_9,
            "5:10" => InterfaceVersion.V5_10,
            "5:11" => InterfaceVersion.V5_11,
            "5:12" => InterfaceVersion.V5_12,
            "5:13" => InterfaceVersion.V5_13,
            "5:14" => InterfaceVersion.V5_14,
            "5:15" => InterfaceVersion.V5_15,
            "5:16" => InterfaceVersion.V5_16,
            _ => throw new Exception("Unknown interface version"),
        };

        var pinterface = GetPluginInterface();
        var pinfo = GetPluginInfo();
        Global._pluginInfo = pinfo;
        Global._metaUtilFuncs = new MetaUtilFuncs(pMetaUtilFuncs);
        bool result = pinterface.Meta_Query(ifver, Global.MetaUtilFuncs);
        unsafe
        {
            nint ptr = Marshal.AllocHGlobal(sizeof(NativePluginInfo));
            *(NativePluginInfo**)plinfo = (NativePluginInfo*)ptr;
            (*(NativePluginInfo**)plinfo)->ifvers = Marshal.StringToHGlobalAnsi(pinfo.GetInterfaceVersionString());
            (*(NativePluginInfo**)plinfo)->name = Marshal.StringToHGlobalAnsi(pinfo.Name);
            (*(NativePluginInfo**)plinfo)->version = Marshal.StringToHGlobalAnsi(pinfo.Version);
            (*(NativePluginInfo**)plinfo)->date = Marshal.StringToHGlobalAnsi(pinfo.Date);
            (*(NativePluginInfo**)plinfo)->author = Marshal.StringToHGlobalAnsi(pinfo.Author);
            (*(NativePluginInfo**)plinfo)->url = Marshal.StringToHGlobalAnsi(pinfo.Url);
            (*(NativePluginInfo**)plinfo)->logtag = Marshal.StringToHGlobalAnsi(pinfo.LogTag);
            (*(NativePluginInfo**)plinfo)->loadable = (int)pinfo.Loadable;
            (*(NativePluginInfo**)plinfo)->unloadable = (int)pinfo.Unloadable;
            pinfo.NavitePtr = ptr;
        }
        return result ? 1 : 0;
    }

    protected static int Native_Meta_Attach(PluginLoadTime now, nint pFunctionTable, nint pMGlobals, nint pGamedllFuncs)
    {
        MetaGlobals metaGlobals = new(pMGlobals);
        GameDllFuncs gameDllFuncs = new(pGamedllFuncs);
        Global._metaGlobals = metaGlobals;
        Global._gameDllFuncs = gameDllFuncs;
        var pinterface = GetPluginInterface();
        bool result = pinterface.Meta_Attach(now, metaGlobals, gameDllFuncs);

        var original = Marshal.PtrToStructure<NativeMetaFuncs>(pFunctionTable);
        NativeMetaFuncs funcs = MetaFunctions.GetNative();
        original.pfnGetEntityAPI = funcs.pfnGetEntityAPI;
        original.pfnGetEntityAPI_Post = funcs.pfnGetEntityAPI_Post;
        original.pfnGetEntityAPI2 = funcs.pfnGetEntityAPI2;
        original.pfnGetEntityAPI2_Post = funcs.pfnGetEntityAPI2_Post;
        original.pfnGetNewDLLFunctions = funcs.pfnGetNewDLLFunctions;
        original.pfnGetNewDLLFunctions_Post = funcs.pfnGetNewDLLFunctions_Post;
        original.pfnGetEngineFunctions = funcs.pfnGetEngineFunctions;
        original.pfnGetEngineFunctions_Post = funcs.pfnGetEngineFunctions_Post;
        original.pfnGetStudioBlendingInterface = funcs.pfnGetStudioBlendingInterface;
        original.pfnGetStudioBlendingInterface_Post = funcs.pfnGetStudioBlendingInterface_Post;
        return result ? 1 : 0;
    }

    protected static int Native_Meta_Detach(PluginLoadTime now, PluginUnloadReason reason)
    {
        var pinterface = GetPluginInterface();
        bool result = pinterface.Meta_Detach(now, reason);
        return result ? 1 : 0;
    }
}