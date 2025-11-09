using Metamod.Interface.Events;
using Metamod.Native.Game;
using Metamod.Native.Metamod;

namespace Metamod.Interface;

#pragma warning disable CS8500 // 这会获取托管类型的地址、获取其大小或声明指向它的指针
public class MetaFunctions
{
    #region 内部函数
    private static DLLEvents? _entityApi = null;
    private static DLLEvents? _entityApi_Post = null;
    private static DLLEvents? _entityApi2 = null;
    private static DLLEvents? _entityApi2_Post = null;
    private static NewDLLEvents? _newDllFunctions = null;
    private static NewDLLEvents? _newDLLFunctions_Post = null;

    private static unsafe void LinkNativeDLLEvents(NativeDllFuncs* target, NativeDllFuncs source)
    {
        target->pfnGameInit = source.pfnGameInit;
        target->pfnSpawn = source.pfnSpawn;
        target->pfnThink = source.pfnThink;
        target->pfnUse = source.pfnUse;
        target->pfnTouch = source.pfnTouch;
        target->pfnBlocked = source.pfnBlocked;
        target->pfnKeyValue = source.pfnKeyValue;
        target->pfnSave = source.pfnSave;
        target->pfnRestore = source.pfnRestore;
        target->pfnSetAbsBox = source.pfnSetAbsBox;
        target->pfnSaveWriteFields = source.pfnSaveWriteFields;
        target->pfnSaveReadFields = source.pfnSaveReadFields;
        target->pfnSaveGlobalState = source.pfnSaveGlobalState;
        target->pfnRestoreGlobalState = source.pfnRestoreGlobalState;
        target->pfnResetGlobalState = source.pfnResetGlobalState;
        target->pfnClientConnect = source.pfnClientConnect;
        target->pfnClientDisconnect = source.pfnClientDisconnect;
        target->pfnClientKill = source.pfnClientKill;
        target->pfnClientPutInServer = source.pfnClientPutInServer;
        target->pfnClientCommand = source.pfnClientCommand;
        target->pfnClientUserInfoChanged = source.pfnClientUserInfoChanged;
        target->pfnServerActivate = source.pfnServerActivate;
        target->pfnServerDeactivate = source.pfnServerDeactivate;
        target->pfnPlayerPreThink = source.pfnPlayerPreThink;
        target->pfnPlayerPostThink = source.pfnPlayerPostThink;
        target->pfnStartFrame = source.pfnStartFrame;
        target->pfnParmsNewLevel = source.pfnParmsNewLevel;
        target->pfnParmsChangeLevel = source.pfnParmsChangeLevel;
        target->pfnGetGameDescription = source.pfnGetGameDescription;
        target->pfnPlayerCustomization = source.pfnPlayerCustomization;
        target->pfnSpectatorConnect = source.pfnSpectatorConnect;
        target->pfnSpectatorDisconnect = source.pfnSpectatorDisconnect;
        target->pfnSpectatorThink = source.pfnSpectatorThink;
        target->pfnSysError = source.pfnSysError;
        target->pfnPMMove = source.pfnPMMove;
        target->pfnPMInit = source.pfnPMInit;
        target->pfnPMFindTextureType = source.pfnPMFindTextureType;
        target->pfnSetupVisibility = source.pfnSetupVisibility;
        target->pfnUpdateClientData = source.pfnUpdateClientData;
        target->pfnAddToFullPack = source.pfnAddToFullPack;
        target->pfnCreateBaseline = source.pfnCreateBaseline;
        target->pfnRegisterEncoders = source.pfnRegisterEncoders;
        target->pfnGetWeaponData = source.pfnGetWeaponData;
        target->pfnCmdStart = source.pfnCmdStart;
        target->pfnCmdEnd = source.pfnCmdEnd;
        target->pfnConnectionlessPacket = source.pfnConnectionlessPacket;
        target->pfnGetHullBounds = source.pfnGetHullBounds;
        target->pfnCreateInstancedBaselines = source.pfnCreateInstancedBaselines;
        target->pfnInconsistentFile = source.pfnInconsistentFile;
        target->pfnAllowLagCompensation = source.pfnAllowLagCompensation;
    }
    private static unsafe void LinkNativeNewDLLEvents(NativeNewDllFuncs* target, NativeNewDllFuncs source)
    {
        target->pfnOnFreeEntPrivateData = source.pfnOnFreeEntPrivateData;
        target->pfnGameShutdown = source.pfnGameShutdown;
        target->pfnShouldCollide = source.pfnShouldCollide;
        target->pfnCvarValue = source.pfnCvarValue;
        target->pfnCvarValue2 = source.pfnCvarValue2;
    }

    internal static NativeGetEntityApiDelegate GetEntityApiWrapper = (pFunctionTable, interfaceVersion) =>
    {
        int res = 0;
        unsafe
        {
            if (_entityApi == null)
                throw new NullReferenceException("DLLEvents instance is null in GetEntityApiWrapper.");
            EntityAPINativeCaller._dllEvents = _entityApi;
            LinkNativeDLLEvents((NativeDllFuncs*)pFunctionTable, EntityAPINativeCaller.GetDLLFunctionsNative());
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
            LinkNativeDLLEvents((NativeDllFuncs*)pFunctionTable, EntityAPIPostNativeCaller.GetDLLFunctionsNative());
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
            LinkNativeDLLEvents((NativeDllFuncs*)pFunctionTable, EntityAPI2NativeCaller.GetDLLFunctionsNative());
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
            LinkNativeDLLEvents((NativeDllFuncs*)pFunctionTable, EntityAPI2PostNativeCaller.GetDLLFunctionsNative());
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
                throw new NullReferenceException("DLLEvents instance is null in GetEntityApi2PostWrapper.");
            NewDLLFunctionsNativeCaller._newEvents = _newDllFunctions;
            LinkNativeNewDLLEvents((NativeNewDllFuncs*)pFunctionTable, NewDLLFunctionsNativeCaller.GetNewDLLFunctionsNative());
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
                throw new NullReferenceException("DLLEvents instance is null in GetEntityApi2PostWrapper.");
            NewDLLFunctionsPostNativeCaller._newEvents = _newDllFunctions;
            LinkNativeNewDLLEvents((NativeNewDllFuncs*)pFunctionTable, NewDLLFunctionsPostNativeCaller.GetNewDLLFunctionsNative());
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
#pragma warning restore CS8500 // 这会获取托管类型的地址、获取其大小或声明指向它的指针