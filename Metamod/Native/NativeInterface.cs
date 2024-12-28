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
