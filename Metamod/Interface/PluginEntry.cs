using Metamod.Enum.Metamod;
using Metamod.Native.Engine;
using Metamod.Native.Metamod;
using Metamod.Struct.Engine;
using Metamod.Struct.Metamod;
using Metamod.Helper;
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

    protected static PluginInfo? Info;
    public static PluginInfo GetPluginInfo()
    {
        if (Info == null)
            throw new NullReferenceException(nameof(Info));
        return Info;
    }

    //[UnmanagedCallersOnly(EntryPoint = "GiveFnptrsToDll")]
    //internal unsafe static void Native_GiveFnptrsToDll(NativeEngineFuncs* pengfuncsFromEngine, NativeGlobalVars* pGlobals)
    protected static void Native_GiveFnptrsToDll(nint pengfuncsFromEngine, nint pGlobals)
    {
        CEngineFuncs engineFuncs = new(pengfuncsFromEngine);
        CGlobalVars globalVars = new(pGlobals);
        Global.EngineFuncs = engineFuncs;
        Global.GlobalVars = globalVars;
        Global.Utility = new();

        var pinterface = GetPluginInterface();
        pinterface.GiveFnptrsToDll(engineFuncs, globalVars);
    }

    //[UnmanagedCallersOnly(EntryPoint = "Meta_Init", CallConvs = [typeof(CallConvCdecl)])]
    //internal static void Native_Meta_Init()
    protected static void Native_Meta_Init()
    {

    }

    //[UnmanagedCallersOnly(EntryPoint = "Meta_Query", CallConvs = [typeof(CallConvCdecl)])]
    //internal unsafe static int Native_Meta_Query(byte* interfaceVersion, NativePluginInfo** plinfo, NativeMetaUtilFuncs* pMetaUtilFuncs)
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
        Global.PluginInfo = pinfo;
        bool result = pinterface.Meta_Query(ifver, pMetaUtilFuncs);
        unsafe
        {
            nint ptr = Marshal.AllocHGlobal(sizeof(NativePluginInfo));
            * (NativePluginInfo**)plinfo = (NativePluginInfo*)ptr;
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

    //[UnmanagedCallersOnly(EntryPoint = "Meta_Attach", CallConvs = [typeof(CallConvCdecl)])]
    //internal unsafe static int Native_Meta_Attach(PluginLoadTime now, NativeMetaFuncs* pFunctionTable, NativeMetaGlobals* pMGlobals, NativeGameDllFuncs* pGamedllFuncs)
    protected static int Native_Meta_Attach(PluginLoadTime now, nint pFunctionTable, nint pMGlobals, nint pGamedllFuncs)
    {
        var pinterface = GetPluginInterface();
        bool result = pinterface.Meta_Attach(now, pFunctionTable, pMGlobals, pGamedllFuncs);
        return result ? 1 : 0;
    }

    //[UnmanagedCallersOnly(EntryPoint = "Meta_Detach", CallConvs = [typeof(CallConvCdecl)])]
    //internal static int Native_Meta_Detach(PluginLoadTime now, PluginUnloadReason reason)
    protected static int Native_Meta_Detach(PluginLoadTime now, PluginUnloadReason reason)
    {
        var pinterface = GetPluginInterface();
        bool result = pinterface.Meta_Detach(now, reason);
        return result ? 1 : 0;
    }

    //[UnmanagedCallersOnly(EntryPoint = "GetEntityAPI", CallConvs = [typeof(CallConvCdecl)])]
    //internal unsafe static int Native_GetEntityAPI(NativeDllFuncs* pFunctionTable, int interfaceVersion)
    protected static int Native_GetEntityAPI(nint pFunctionTable, int interfaceVersion)
    {
        var pinterface = GetPluginInterface();
        bool result = pinterface.GetEntityAPI(pFunctionTable, interfaceVersion);
        return result ? 1 : 0;
    }

    //[UnmanagedCallersOnly(EntryPoint = "GetEntityAPI2", CallConvs = [typeof(CallConvCdecl)])]
    //internal unsafe static int Native_GetEntityAPI2(NativeDllFuncs* pFunctionTable, int* interfaceVersion)
    protected static int Native_GetEntityAPI2(nint pFunctionTable, nint interfaceVersion)
    {
        int ifver = Marshal.ReadInt32(interfaceVersion);
        var pinterface = GetPluginInterface();
        bool result = pinterface.GetEntityAPI2(pFunctionTable, ifver);
        return result ? 1 : 0;
    }

    //[UnmanagedCallersOnly(EntryPoint = "GetNewDLLFunctions", CallConvs = [typeof(CallConvCdecl)])]
    //internal unsafe static int Native_GetNewDLLFunctions(NativeNewDllFuncs* pNewFunctionTable, int* interfaceVersion)
    protected static int Native_GetNewDLLFunctions(nint pNewFunctionTable, nint interfaceVersion)
    {
        int ifver = Marshal.ReadInt32(interfaceVersion);
        var pinterface = GetPluginInterface();
        bool result = pinterface.GetNewDLLFunctions(pNewFunctionTable, ifver);
        return result ? 1 : 0;
    }

    //[UnmanagedCallersOnly(EntryPoint = "GetEntityAPI_Post", CallConvs = [typeof(CallConvCdecl)])]
    //internal unsafe static int Native_GetEntityAPI_Post(NativeDllFuncs* pFunctionTable, int* interfaceVersion)
    protected static int Native_GetEntityAPI_Post(nint pFunctionTable, nint interfaceVersion)
    {
        int ifver = Marshal.ReadInt32(interfaceVersion);
        var pinterface = GetPluginInterface();
        bool result = pinterface.GetEntityAPI_Post(pFunctionTable, ifver);
        return result ? 1 : 0;
    }

    //[UnmanagedCallersOnly(EntryPoint = "GetEntityAPI2_Post", CallConvs = [typeof(CallConvCdecl)])]
    //internal unsafe static int Native_GetEntityAPI2_Post(NativeDllFuncs* pFunctionTable, int* interfaceVersion)
    protected static int Native_GetEntityAPI2_Post(nint pFunctionTable, nint interfaceVersion)
    {
        int ifver = Marshal.ReadInt32(interfaceVersion);
        var pinterface = GetPluginInterface();
        bool result = pinterface.GetEntityAPI2_Post(pFunctionTable, ifver);
        return result ? 1 : 0;
    }

    //[UnmanagedCallersOnly(EntryPoint = "GetNewDLLFunctions_Post", CallConvs = [typeof(CallConvCdecl)])]
    //internal unsafe static int Native_GetNewDLLFunctions_Post(NativeNewDllFuncs* pNewFunctionTable, int* interfaceVersion)
    protected static int Native_GetNewDLLFunctions_Post(nint pNewFunctionTable, nint interfaceVersion)
    {
        int ifver = Marshal.ReadInt32(interfaceVersion);
        var pinterface = GetPluginInterface();
        bool result = pinterface.GetNewDLLFunctions_Post(pNewFunctionTable, ifver);
        return result ? 1 : 0;
    }

    //[UnmanagedCallersOnly(EntryPoint = "GetEngineFunctions", CallConvs = [typeof(CallConvCdecl)])]
    //internal unsafe static int Native_GetEngineFunctions(NativeEngineFuncs* pengfuncsFromEngine, int* interfaceVersion)
    protected static int Native_GetEngineFunctions(nint pengfuncsFromEngine, nint interfaceVersion)
    {
        int ifver = Marshal.ReadInt32(interfaceVersion);
        var pinterface = GetPluginInterface();
        bool result = pinterface.GetEngineFunctions(pengfuncsFromEngine, ifver);
        return result ? 1 : 0;
    }

    //[UnmanagedCallersOnly(EntryPoint = "GetEngineFunctions_Post", CallConvs = [typeof(CallConvCdecl)])]
    //internal unsafe static int Native_GetEngineFunctions_Post(NativeEngineFuncs* pengfuncsFromEngine, int* interfaceVersion)
    protected static int Native_GetEngineFunctions_Post(nint pengfuncsFromEngine, nint interfaceVersion)
    {
        int ifver = Marshal.ReadInt32(interfaceVersion);
        var pinterface = GetPluginInterface();
        bool result = pinterface.GetEngineFunctions_Post(pengfuncsFromEngine, ifver);
        return result ? 1 : 0;
    }
}