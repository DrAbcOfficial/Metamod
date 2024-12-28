using Metamod.Enum.Metamod;
using Metamod.Native.Engine;
using Metamod.Native.Game;
using Metamod.Native.Metamod;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Metamod.Native;

internal class NativeInterface
{
#pragma warning disable CS8500 // 这会获取托管类型的地址、获取其大小或声明指向它的指针
    [UnmanagedCallersOnly(EntryPoint = "GiveFnptrsToDll")]
    internal unsafe static void Native_GiveFnptrsToDll(NativeEngineFuncs* pengfuncsFromEngine, NativeGlobalVars* pGlobals)
    {

    }
    [UnmanagedCallersOnly(EntryPoint = "Meta_Init", CallConvs = [typeof(CallConvCdecl)])]
    internal static void Native_Meta_Init()
    {

    }
    [UnmanagedCallersOnly(EntryPoint = "Meta_Query", CallConvs = [typeof(CallConvCdecl)])]
    internal unsafe static int Native_Meta_Query(byte* interfaceVersion, NativePluginInfo** plinfo, NativeMetaUtilFuncs* pMetaUtilFuncs)
    {
        string? version = Marshal.PtrToStringAnsi((nint)interfaceVersion) ?? throw new Exception("Interface version is null");
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
        PluginEntry.Plugin.Meta_Query(ifver, (nint)pMetaUtilFuncs);
        nint pl = Marshal.AllocHGlobal(Marshal.SizeOf(PluginEntry.PluginInfo.nativePluginInfo));
        Marshal.StructureToPtr(PluginEntry.PluginInfo.nativePluginInfo, pl, false);
        *plinfo = (NativePluginInfo*)pl;
        return 0;
    }
    [UnmanagedCallersOnly(EntryPoint = "Meta_Attach", CallConvs = [typeof(CallConvCdecl)])]
    internal unsafe static int Native_Meta_Attach(PluginLoadTime now, NativeMetaFuncs* pFunctionTable, NativeMetaGlobals* pMGlobals, NativeGameDllFuncs* pGamedllFuncs)
    {
        return 0;
    }

    [UnmanagedCallersOnly(EntryPoint = "Meta_Detach", CallConvs = [typeof(CallConvCdecl)])]
    internal static int Native_Meta_Detach(PluginLoadTime now, PluginUnloadReason reason)
    {
        return 0;
    }

    [UnmanagedCallersOnly(EntryPoint = "GetEntityAPI", CallConvs = [typeof(CallConvCdecl)])]
    internal unsafe static int Native_GetEntityAPI(NativeDllFuncs* pFunctionTable, int interfaceVersion)
    {
        return 0;
    }

    [UnmanagedCallersOnly(EntryPoint = "GetEntityAPI2", CallConvs = [typeof(CallConvCdecl)])]
    internal unsafe static int Native_GetEntityAPI2(NativeDllFuncs* pFunctionTable, int* interfaceVersion)
    {
        return 0;
    }

    [UnmanagedCallersOnly(EntryPoint = "GetNewDLLFunctions", CallConvs = [typeof(CallConvCdecl)])]
    internal unsafe static int Native_GetNewDLLFunctions(NativeNewDllFuncs* pNewFunctionTable, int* interfaceVersion)
    {
        return 0;
    }

    [UnmanagedCallersOnly(EntryPoint = "GetEntityAPI_Post", CallConvs = [typeof(CallConvCdecl)])]
    internal unsafe static int Native_GetEntityAPI_Post(NativeDllFuncs* pFunctionTable, int* interfaceVersion)
    {
        return 0;
    }

    [UnmanagedCallersOnly(EntryPoint = "GetEntityAPI2_Post", CallConvs = [typeof(CallConvCdecl)])]
    internal unsafe static int Native_GetEntityAPI2_Post(NativeDllFuncs* pFunctionTable, int* interfaceVersion)
    {
        return 0;
    }

    [UnmanagedCallersOnly(EntryPoint = "GetNewDLLFunctions_Post", CallConvs = [typeof(CallConvCdecl)])]
    internal unsafe static int Native_GetNewDLLFunctions_Post(NativeNewDllFuncs* pNewFunctionTable, int* interfaceVersion)
    {
        return 0;
    }

    [UnmanagedCallersOnly(EntryPoint = "GetEngineFunctions", CallConvs = [typeof(CallConvCdecl)])]
    internal unsafe static int Native_GetEngineFunctions(NativeEngineFuncs* pengfuncsFromEngine, int* interfaceVersion)
    {
        return 0;
    }

    [UnmanagedCallersOnly(EntryPoint = "GetEngineFunctions_Post", CallConvs = [typeof(CallConvCdecl)])]
    internal unsafe static int Native_GetEngineFunctions_Post(NativeEngineFuncs* pengfuncsFromEngine, int* interfaceVersion)
    {
        return 0;
    }
#pragma warning restore CS8500 // 这会获取托管类型的地址、获取其大小或声明指向它的指针
}
