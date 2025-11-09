using Metamod.Interface.Events;
using Metamod.Native.Game;
using Metamod.Native.Metamod;
using System.Runtime.InteropServices;

namespace Metamod.Interface;

public class MetaFunctions
{
    #region 内部函数
    private static DLLEvents? _entityApi = null;
    private static DLLEvents? _entityApi_Post = null;
    private static DLLEvents? _entityApi2 = null;
    private static DLLEvents? _entityApi2_Post = null;
    private static NewDLLEvents? _newDllFunctions = null;
    private static NewDLLEvents? _newDLLFunctions_Post = null;

    // 将托管 delegate 转为原生函数指针并按字段顺序写入到非托管结构内存中。
    // 注意：字段顺序必须与 NativeDllFuncs 的定义完全一致（指针大小顺序）。
    private static unsafe void LinkNativeDLLEvents(nint pFunctionTable, NativeDllFuncs source)
    {
        if (pFunctionTable == 0)
            throw new ArgumentNullException(nameof(pFunctionTable), "pFunctionTable is NULL in LinkNativeDLLEvents.");

        IntPtr* dest = (IntPtr*)pFunctionTable;
        int i = 0;

        dest[i++] = source.pfnGameInit == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnGameInit);
        dest[i++] = source.pfnSpawn == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnSpawn);
        dest[i++] = source.pfnThink == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnThink);
        dest[i++] = source.pfnUse == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnUse);
        dest[i++] = source.pfnTouch == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnTouch);
        dest[i++] = source.pfnBlocked == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnBlocked);
        dest[i++] = source.pfnKeyValue == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnKeyValue);
        dest[i++] = source.pfnSave == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnSave);
        dest[i++] = source.pfnRestore == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnRestore);
        dest[i++] = source.pfnSetAbsBox == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnSetAbsBox);
        dest[i++] = source.pfnSaveWriteFields == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnSaveWriteFields);
        dest[i++] = source.pfnSaveReadFields == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnSaveReadFields);
        dest[i++] = source.pfnSaveGlobalState == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnSaveGlobalState);
        dest[i++] = source.pfnRestoreGlobalState == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnRestoreGlobalState);
        dest[i++] = source.pfnResetGlobalState == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnResetGlobalState);
        dest[i++] = source.pfnClientConnect == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnClientConnect);
        dest[i++] = source.pfnClientDisconnect == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnClientDisconnect);
        dest[i++] = source.pfnClientKill == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnClientKill);
        dest[i++] = source.pfnClientPutInServer == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnClientPutInServer);
        dest[i++] = source.pfnClientCommand == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnClientCommand);
        dest[i++] = source.pfnClientUserInfoChanged == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnClientUserInfoChanged);
        dest[i++] = source.pfnServerActivate == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnServerActivate);
        dest[i++] = source.pfnServerDeactivate == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnServerDeactivate);
        dest[i++] = source.pfnPlayerPreThink == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnPlayerPreThink);
        dest[i++] = source.pfnPlayerPostThink == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnPlayerPostThink);
        dest[i++] = source.pfnStartFrame == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnStartFrame);
        dest[i++] = source.pfnParmsNewLevel == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnParmsNewLevel);
        dest[i++] = source.pfnParmsChangeLevel == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnParmsChangeLevel);
        dest[i++] = source.pfnGetGameDescription == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnGetGameDescription);
        dest[i++] = source.pfnPlayerCustomization == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnPlayerCustomization);
        dest[i++] = source.pfnSpectatorConnect == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnSpectatorConnect);
        dest[i++] = source.pfnSpectatorDisconnect == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnSpectatorDisconnect);
        dest[i++] = source.pfnSpectatorThink == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnSpectatorThink);
        dest[i++] = source.pfnSysError == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnSysError);
        dest[i++] = source.pfnPMMove == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnPMMove);
        dest[i++] = source.pfnPMInit == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnPMInit);
        dest[i++] = source.pfnPMFindTextureType == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnPMFindTextureType);
        dest[i++] = source.pfnSetupVisibility == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnSetupVisibility);
        dest[i++] = source.pfnUpdateClientData == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnUpdateClientData);
        dest[i++] = source.pfnAddToFullPack == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnAddToFullPack);
        dest[i++] = source.pfnCreateBaseline == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnCreateBaseline);
        dest[i++] = source.pfnRegisterEncoders == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnRegisterEncoders);
        dest[i++] = source.pfnGetWeaponData == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnGetWeaponData);
        dest[i++] = source.pfnCmdStart == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnCmdStart);
        dest[i++] = source.pfnCmdEnd == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnCmdEnd);
        dest[i++] = source.pfnConnectionlessPacket == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnConnectionlessPacket);
        dest[i++] = source.pfnGetHullBounds == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnGetHullBounds);
        dest[i++] = source.pfnCreateInstancedBaselines == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnCreateInstancedBaselines);
        dest[i++] = source.pfnInconsistentFile == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnInconsistentFile);
        dest[i++] = source.pfnAllowLagCompensation == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnAllowLagCompensation);
    }
    private static unsafe void LinkNativeNewDLLEvents(nint pFunctionTable, NativeNewDllFuncs source)
    {
        if (pFunctionTable == 0)
            throw new ArgumentNullException(nameof(pFunctionTable), "pFunctionTable is NULL in LinkNativeNewDLLEvents.");

        IntPtr* dest = (IntPtr*)pFunctionTable;
        int i = 0;

        dest[i++] = source.pfnOnFreeEntPrivateData == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnOnFreeEntPrivateData);
        dest[i++] = source.pfnGameShutdown == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnGameShutdown);
        dest[i++] = source.pfnShouldCollide == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnShouldCollide);
        dest[i++] = source.pfnCvarValue == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnCvarValue);
        dest[i++] = source.pfnCvarValue2 == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnCvarValue2);
    }

    internal static NativeGetEntityApiDelegate GetEntityApiWrapper = (pFunctionTable, interfaceVersion) =>
    {
        int res = 0;
        unsafe
        {
            if (_entityApi == null)
                throw new NullReferenceException("DLLEvents instance is null in GetEntityApiWrapper.");
            EntityAPINativeCaller._dllEvents = _entityApi;
            LinkNativeDLLEvents(pFunctionTable, EntityAPINativeCaller.GetDLLFunctionsNative());
            res = 1;
        }
        return res;
    };
    internal static NativeGetEntityApiDelegate GetEntityApiPostWrapper = (pFunctionTable, interfaceVersion) =>
    {
        int res = 0;
        unsafe
        {
            if (_entityApi_Post == null)
                throw new NullReferenceException("DLLEvents instance is null in GetEntityApiPostWrapper.");
            EntityAPIPostNativeCaller._dllEvents = _entityApi_Post;
            LinkNativeDLLEvents(pFunctionTable, EntityAPIPostNativeCaller.GetDLLFunctionsNative());
            res = 1;
        }
        return res;
    };
    internal static NativeGetEntityApi2Delegate GetEntityApi2Wrapper = (pFunctionTable, interfaceVersion) =>
    {
        int res = 0;
        unsafe
        {
            if (_entityApi2 == null)
                throw new NullReferenceException("DLLEvents instance is null in GetEntityApi2Wrapper.");
            EntityAPI2NativeCaller._dllEvents = _entityApi2;
            LinkNativeDLLEvents(pFunctionTable, EntityAPI2NativeCaller.GetDLLFunctionsNative());
            res = 1;
        }
        return res;
    };
    internal static NativeGetEntityApi2Delegate GetEntityApi2PostWrapper = (pFunctionTable, interfaceVersion) =>
    {
        int res = 0;
        unsafe
        {
            if (_entityApi2_Post == null)
                throw new NullReferenceException("DLLEvents instance is null in GetEntityApi2PostWrapper.");
            EntityAPI2PostNativeCaller._dllEvents = _entityApi2_Post;
            LinkNativeDLLEvents(pFunctionTable, EntityAPI2PostNativeCaller.GetDLLFunctionsNative());
            res = 1;
        }
        return res;
    };
    internal static NativeGetNewDllFunctionsDelegate GetNewDllFunctionsWrapper = (pFunctionTable, interfaceVersion) =>
    {
        int res = 0;
        unsafe
        {
            if (_newDllFunctions == null)
                throw new NullReferenceException("NewDLLEvents instance is null in GetNewDllFunctionsWrapper.");
            NewDLLFunctionsNativeCaller._newEvents = _newDllFunctions;
            LinkNativeNewDLLEvents(pFunctionTable, NewDLLFunctionsNativeCaller.GetNewDLLFunctionsNative());
            res = 1;
        }
        return res;
    };
    internal static NativeGetNewDllFunctionsDelegate GetNewDllFunctions_PostWrapper = (pFunctionTable, interfaceVersion) =>
    {
        int res = 0;
        unsafe
        {
            if (_newDLLFunctions_Post == null)
                throw new NullReferenceException("NewDLLEvents instance is null in GetNewDllFunctions_PostWrapper.");
            NewDLLFunctionsPostNativeCaller._newEvents = _newDLLFunctions_Post;
            LinkNativeNewDLLEvents(pFunctionTable, NewDLLFunctionsPostNativeCaller.GetNewDLLFunctionsNative());
            res = 1;
        }
        return res;
    };

    internal static NativeMetaFuncs? _native = null;

    internal static NativeMetaFuncs GetNative()
    {
        _native ??= new()
        {
            pfnGetEntityAPI = _entityApi == null ? null : GetEntityApiWrapper,
            pfnGetEntityAPI_Post = _entityApi_Post == null ? null : GetEntityApiPostWrapper,
            pfnGetEntityAPI2 = _entityApi2 == null ? null : GetEntityApi2Wrapper,
            pfnGetEntityAPI2_Post = _entityApi2_Post == null ? null : GetEntityApi2PostWrapper,
            pfnGetNewDLLFunctions = _newDllFunctions == null ? null : GetNewDllFunctionsWrapper,
            pfnGetNewDLLFunctions_Post = _newDLLFunctions_Post == null ? null : GetNewDllFunctions_PostWrapper,
            //TODO: Finish these wrappers
            pfnGetEngineFunctions = null,
            pfnGetEngineFunctions_Post = null,
            pfnGetStudioBlendingInterface = null,
            pfnGetStudioBlendingInterface_Post = null
        };
        return (NativeMetaFuncs)_native;
    }
    #endregion

    #region 对外函数
    public static void InitEntityApi(DLLEvents entityApi)
    {
        _entityApi = entityApi;
    }
    public static void InitEntityApi_Post(DLLEvents entityApiPost)
    {
        _entityApi_Post = entityApiPost;
    }
    public static void InitEntityApi2(DLLEvents entityApi2)
    {
        _entityApi2 = entityApi2;
    }
    public static void InitEntityApi2_Post(DLLEvents entityApi2Post)
    {
        _entityApi2_Post = entityApi2Post;
    }
    public static void InitNewDllFunctions(NewDLLEvents newDllFunctions)
    {
        _newDllFunctions = newDllFunctions;
    }
    public static void InitNewDllFunctions_Post(NewDLLEvents newDllFunctionsPost)
    {
        _newDLLFunctions_Post = newDllFunctionsPost;
    }
    #endregion
}