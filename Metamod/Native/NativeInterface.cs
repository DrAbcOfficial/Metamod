using Metamod.Enum.Metamod;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Metamod.Native;

internal class NativeInterface
{
    [UnmanagedCallersOnly(EntryPoint = "GiveFnptrsToDll")]
    internal static void Native_GiveFnptrsToDll(nint pengfuncsFromEngine, nint pGlobals)
    {

    }
    [UnmanagedCallersOnly(EntryPoint = "Meta_Init", CallConvs = [typeof(CallConvCdecl)])]
    internal static void Native_Meta_Init()
    {

    }
    [UnmanagedCallersOnly(EntryPoint = "Meta_Query", CallConvs = [typeof(CallConvCdecl)])]
    internal static int Native_Meta_Query(nint interfaceVersion, nint plinfo, nint pMetaUtilFuncs)
    {
        return 0;
    }
    [UnmanagedCallersOnly(EntryPoint = "Meta_Attach", CallConvs = [typeof(CallConvCdecl)])]
    internal static int Native_Meta_Attach(PLUG_LOADTIME now, nint pFunctionTable, nint pMGlobals, nint pGamedllFuncs)
    {
        return 1;
    }

    [UnmanagedCallersOnly(EntryPoint = "Meta_Detach", CallConvs = [typeof(CallConvCdecl)])]
    internal static int Native_Meta_Detach(PLUG_LOADTIME now, PL_UNLOAD_REASON reason)
    {
        return 1;
    }

    [UnmanagedCallersOnly(EntryPoint = "GetEntityAPI", CallConvs = [typeof(CallConvCdecl)])]
    internal static int Native_GetEntityAPI(nint pFunctionTable, int interfaceVersion)
    {
        return 1;
    }

    [UnmanagedCallersOnly(EntryPoint = "GetEntityAPI2", CallConvs = [typeof(CallConvCdecl)])]
    internal static int Native_GetEntityAPI2(nint pFunctionTable, nint interfaceVersion)
    {
        return 1;
    }

    [UnmanagedCallersOnly(EntryPoint = "GetNewDLLFunctions", CallConvs = [typeof(CallConvCdecl)])]
    internal static int Native_GetNewDLLFunctions(nint pNewFunctionTable, nint interfaceVersion)
    {
        return 1;
    }

    [UnmanagedCallersOnly(EntryPoint = "GetEntityAPI_Post", CallConvs = [typeof(CallConvCdecl)])]
    internal static int Native_GetEntityAPI_Post(nint pFunctionTable, int interfaceVersion)
    {
        return 1;
    }

    [UnmanagedCallersOnly(EntryPoint = "GetEntityAPI2_Post", CallConvs = [typeof(CallConvCdecl)])]
    internal static int Native_GetEntityAPI2_Post(nint pFunctionTable, nint interfaceVersion)
    {
        return 1;
    }

    [UnmanagedCallersOnly(EntryPoint = "GetNewDLLFunctions_Post", CallConvs = [typeof(CallConvCdecl)])]
    internal static int Native_GetNewDLLFunctions_Post(nint pNewFunctionTable, nint interfaceVersion)
    {
        return 1;
    }

    [UnmanagedCallersOnly(EntryPoint = "GetEngineFunctions", CallConvs = [typeof(CallConvCdecl)])]
    internal static int Native_GetEngineFunctions(nint pengfuncsFromEngine, nint interfaceVersion)
    {
        return 1;
    }

    [UnmanagedCallersOnly(EntryPoint = "GetEngineFunctions_Post", CallConvs = [typeof(CallConvCdecl)])]
    internal static int Native_GetEngineFunctions_Post(nint pengfuncsFromEngine, nint interfaceVersion)
    {
        return 1;
    }
}
