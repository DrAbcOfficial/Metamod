using Metamod.Native.Game;
using Metamod.Native.Metamod;

namespace Metamod.Interface;

public delegate int GetEntityAPIDelegate(DllFunctions pFunctionTable, int interfaceVersion);
public delegate int GetEntityAPIPostDelegate(DllFunctions_Post pFunctionTable, int interfaceVersion);
public delegate int GetEntityAPI2Delegate(DllFunctions pFunctionTable, int interfaceVersion);
public delegate int GetEntityAPI2PostDelegate(DllFunctions_Post pFunctionTable, int interfaceVersion);
public delegate int GetNewDllFunctions(NewDllFunctions pFunctionTable, int interfaceVersion);
public delegate int GetNewDllPostFunctions(NewDllFunctions pFunctionTable, int interfaceVersion);
public delegate int GetEngineFunctions(IEngineFunctions pFunctionTable, int interfaceVersion);
public delegate int GetStudioBlendingInterfaceDelegate(IBlendingInterface pStudioBlendingInterface, int interfaceVersion);

#pragma warning disable CS8500 // 这会获取托管类型的地址、获取其大小或声明指向它的指针
public class MetaFunctions
{
    public static GetEntityAPIDelegate? pfnGetEntityAPI;
    public static GetEntityAPIPostDelegate? pfnGetEntityAPI_Post;
    public static GetEntityAPI2Delegate? pfnGetEntityAPI2;
    public static GetEntityAPI2Delegate? pfnGetENtityAPI2_Post;
    public static GetNewDllFunctions? pfnGetNewDllFunctions;
    public static GetNewDllPostFunctions? pfnGetNewDllFunctions_Post;
    public static GetEngineFunctions? pfnGetEngineFunctions;
    public static GetEngineFunctions? pfnGetEngineFunctions_Post;
    public static GetStudioBlendingInterfaceDelegate? pfnGetBlendingInterface;
    public static GetStudioBlendingInterfaceDelegate? pfnGetBlendingInterface_Post;

    internal static NativeGetEntityApiDelegate GetEntityApiWrapper = (nint pFunctionTable, int interfaceVersion) =>
    {
        int res = 0;
        unsafe
        {
            NativeDllFuncs nfuncs = DllFunctions.GetNative();
            NativeDllFuncs* funcs = (NativeDllFuncs*)pFunctionTable;

            funcs->pfnGameInit = nfuncs.pfnGameInit;
            funcs->pfnSpawn = nfuncs.pfnSpawn;
            funcs->pfnThink = nfuncs.pfnThink;
            funcs->pfnUse = nfuncs.pfnUse;
            funcs->pfnTouch = nfuncs.pfnTouch;
            funcs->pfnBlocked = nfuncs.pfnBlocked;
            funcs->pfnKeyValue = nfuncs.pfnKeyValue;
            funcs->pfnSave = nfuncs.pfnSave;
            funcs->pfnRestore = nfuncs.pfnRestore;
            funcs->pfnSetAbsBox = nfuncs.pfnSetAbsBox;
            funcs->pfnSaveWriteFields = nfuncs.pfnSaveWriteFields;
            funcs->pfnSaveReadFields = nfuncs.pfnSaveReadFields;
            funcs->pfnSaveGlobalState = nfuncs.pfnSaveGlobalState;
            funcs->pfnRestoreGlobalState = nfuncs.pfnRestoreGlobalState;
            funcs->pfnResetGlobalState = nfuncs.pfnResetGlobalState;
            funcs->pfnClientConnect = nfuncs.pfnClientConnect;
            funcs->pfnClientDisconnect = nfuncs.pfnClientDisconnect;
            funcs->pfnClientKill = nfuncs.pfnClientKill;
            funcs->pfnClientPutInServer = nfuncs.pfnClientPutInServer;
            funcs->pfnClientCommand = nfuncs.pfnClientCommand;
            funcs->pfnClientUserInfoChanged = nfuncs.pfnClientUserInfoChanged;
            funcs->pfnServerActivate = nfuncs.pfnServerActivate;
            funcs->pfnServerDeactivate = nfuncs.pfnServerDeactivate;
            funcs->pfnPlayerPreThink = nfuncs.pfnPlayerPreThink;
            funcs->pfnPlayerPostThink = nfuncs.pfnPlayerPostThink;
            funcs->pfnStartFrame = nfuncs.pfnStartFrame;
            funcs->pfnParmsNewLevel = nfuncs.pfnParmsNewLevel;
            funcs->pfnParmsChangeLevel = nfuncs.pfnParmsChangeLevel;
            funcs->pfnGetGameDescription = nfuncs.pfnGetGameDescription;
            funcs->pfnPlayerCustomization = nfuncs.pfnPlayerCustomization;
            funcs->pfnSpectatorConnect = nfuncs.pfnSpectatorConnect;
            funcs->pfnSpectatorDisconnect = nfuncs.pfnSpectatorDisconnect;
            funcs->pfnSpectatorThink = nfuncs.pfnSpectatorThink;
            funcs->pfnSysError = nfuncs.pfnSysError;
            funcs->pfnPMMove = nfuncs.pfnPMMove;
            funcs->pfnPMInit = nfuncs.pfnPMInit;
            funcs->pfnPMFindTextureType = nfuncs.pfnPMFindTextureType;
            funcs->pfnSetupVisibility = nfuncs.pfnSetupVisibility;
            funcs->pfnUpdateClientData = nfuncs.pfnUpdateClientData;
            funcs->pfnAddToFullPack = nfuncs.pfnAddToFullPack;
            funcs->pfnCreateBaseline = nfuncs.pfnCreateBaseline;
            funcs->pfnRegisterEncoders = nfuncs.pfnRegisterEncoders;
            funcs->pfnGetWeaponData = nfuncs.pfnGetWeaponData;
            funcs->pfnCmdStart = nfuncs.pfnCmdStart;
            funcs->pfnCmdEnd = nfuncs.pfnCmdEnd;
            funcs->pfnConnectionlessPacket = nfuncs.pfnConnectionlessPacket;
            funcs->pfnGetHullBounds = nfuncs.pfnGetHullBounds;
            funcs->pfnCreateInstancedBaselines = nfuncs.pfnCreateInstancedBaselines;
            funcs->pfnInconsistentFile = nfuncs.pfnInconsistentFile;
            funcs->pfnAllowLagCompensation = nfuncs.pfnAllowLagCompensation;

            res = 1;
        }
        return res;
    };
    internal static NativeGetEntityApiDelegate GetEntityApiPostWrapper = (nint pFunctionTable, int interfaceVersion) =>
    {
        int res = 0;
        unsafe
        {
            NativeDllFuncs nfuncs = DllFunctions_Post.GetNative();
            NativeDllFuncs* funcs = (NativeDllFuncs*)pFunctionTable;

            funcs->pfnGameInit = nfuncs.pfnGameInit;
            funcs->pfnSpawn = nfuncs.pfnSpawn;
            funcs->pfnThink = nfuncs.pfnThink;
            funcs->pfnUse = nfuncs.pfnUse;
            funcs->pfnTouch = nfuncs.pfnTouch;
            funcs->pfnBlocked = nfuncs.pfnBlocked;
            funcs->pfnKeyValue = nfuncs.pfnKeyValue;
            funcs->pfnSave = nfuncs.pfnSave;
            funcs->pfnRestore = nfuncs.pfnRestore;
            funcs->pfnSetAbsBox = nfuncs.pfnSetAbsBox;
            funcs->pfnSaveWriteFields = nfuncs.pfnSaveWriteFields;
            funcs->pfnSaveReadFields = nfuncs.pfnSaveReadFields;
            funcs->pfnSaveGlobalState = nfuncs.pfnSaveGlobalState;
            funcs->pfnRestoreGlobalState = nfuncs.pfnRestoreGlobalState;
            funcs->pfnResetGlobalState = nfuncs.pfnResetGlobalState;
            funcs->pfnClientConnect = nfuncs.pfnClientConnect;
            funcs->pfnClientDisconnect = nfuncs.pfnClientDisconnect;
            funcs->pfnClientKill = nfuncs.pfnClientKill;
            funcs->pfnClientPutInServer = nfuncs.pfnClientPutInServer;
            funcs->pfnClientCommand = nfuncs.pfnClientCommand;
            funcs->pfnClientUserInfoChanged = nfuncs.pfnClientUserInfoChanged;
            funcs->pfnServerActivate = nfuncs.pfnServerActivate;
            funcs->pfnServerDeactivate = nfuncs.pfnServerDeactivate;
            funcs->pfnPlayerPreThink = nfuncs.pfnPlayerPreThink;
            funcs->pfnPlayerPostThink = nfuncs.pfnPlayerPostThink;
            funcs->pfnStartFrame = nfuncs.pfnStartFrame;
            funcs->pfnParmsNewLevel = nfuncs.pfnParmsNewLevel;
            funcs->pfnParmsChangeLevel = nfuncs.pfnParmsChangeLevel;
            funcs->pfnGetGameDescription = nfuncs.pfnGetGameDescription;
            funcs->pfnPlayerCustomization = nfuncs.pfnPlayerCustomization;
            funcs->pfnSpectatorConnect = nfuncs.pfnSpectatorConnect;
            funcs->pfnSpectatorDisconnect = nfuncs.pfnSpectatorDisconnect;
            funcs->pfnSpectatorThink = nfuncs.pfnSpectatorThink;
            funcs->pfnSysError = nfuncs.pfnSysError;
            funcs->pfnPMMove = nfuncs.pfnPMMove;
            funcs->pfnPMInit = nfuncs.pfnPMInit;
            funcs->pfnPMFindTextureType = nfuncs.pfnPMFindTextureType;
            funcs->pfnSetupVisibility = nfuncs.pfnSetupVisibility;
            funcs->pfnUpdateClientData = nfuncs.pfnUpdateClientData;
            funcs->pfnAddToFullPack = nfuncs.pfnAddToFullPack;
            funcs->pfnCreateBaseline = nfuncs.pfnCreateBaseline;
            funcs->pfnRegisterEncoders = nfuncs.pfnRegisterEncoders;
            funcs->pfnGetWeaponData = nfuncs.pfnGetWeaponData;
            funcs->pfnCmdStart = nfuncs.pfnCmdStart;
            funcs->pfnCmdEnd = nfuncs.pfnCmdEnd;
            funcs->pfnConnectionlessPacket = nfuncs.pfnConnectionlessPacket;
            funcs->pfnGetHullBounds = nfuncs.pfnGetHullBounds;
            funcs->pfnCreateInstancedBaselines = nfuncs.pfnCreateInstancedBaselines;
            funcs->pfnInconsistentFile = nfuncs.pfnInconsistentFile;
            funcs->pfnAllowLagCompensation = nfuncs.pfnAllowLagCompensation;

            res = 1;
        }
        return res;
    };

    internal static NativeGetEntityApi2Delegate GetEntityApi2Wrapper = (nint pFunctionTable, nint interfaceVersion) =>
    {
        int res = 0;
        unsafe
        {
            NativeDllFuncs nfuncs = DllFunctions.GetNative();
            NativeDllFuncs* funcs = (NativeDllFuncs*)pFunctionTable;

            funcs->pfnGameInit = nfuncs.pfnGameInit;
            funcs->pfnSpawn = nfuncs.pfnSpawn;
            funcs->pfnThink = nfuncs.pfnThink;
            funcs->pfnUse = nfuncs.pfnUse;
            funcs->pfnTouch = nfuncs.pfnTouch;
            funcs->pfnBlocked = nfuncs.pfnBlocked;
            funcs->pfnKeyValue = nfuncs.pfnKeyValue;
            funcs->pfnSave = nfuncs.pfnSave;
            funcs->pfnRestore = nfuncs.pfnRestore;
            funcs->pfnSetAbsBox = nfuncs.pfnSetAbsBox;
            funcs->pfnSaveWriteFields = nfuncs.pfnSaveWriteFields;
            funcs->pfnSaveReadFields = nfuncs.pfnSaveReadFields;
            funcs->pfnSaveGlobalState = nfuncs.pfnSaveGlobalState;
            funcs->pfnRestoreGlobalState = nfuncs.pfnRestoreGlobalState;
            funcs->pfnResetGlobalState = nfuncs.pfnResetGlobalState;
            funcs->pfnClientConnect = nfuncs.pfnClientConnect;
            funcs->pfnClientDisconnect = nfuncs.pfnClientDisconnect;
            funcs->pfnClientKill = nfuncs.pfnClientKill;
            funcs->pfnClientPutInServer = nfuncs.pfnClientPutInServer;
            funcs->pfnClientCommand = nfuncs.pfnClientCommand;
            funcs->pfnClientUserInfoChanged = nfuncs.pfnClientUserInfoChanged;
            funcs->pfnServerActivate = nfuncs.pfnServerActivate;
            funcs->pfnServerDeactivate = nfuncs.pfnServerDeactivate;
            funcs->pfnPlayerPreThink = nfuncs.pfnPlayerPreThink;
            funcs->pfnPlayerPostThink = nfuncs.pfnPlayerPostThink;
            funcs->pfnStartFrame = nfuncs.pfnStartFrame;
            funcs->pfnParmsNewLevel = nfuncs.pfnParmsNewLevel;
            funcs->pfnParmsChangeLevel = nfuncs.pfnParmsChangeLevel;
            funcs->pfnGetGameDescription = nfuncs.pfnGetGameDescription;
            funcs->pfnPlayerCustomization = nfuncs.pfnPlayerCustomization;
            funcs->pfnSpectatorConnect = nfuncs.pfnSpectatorConnect;
            funcs->pfnSpectatorDisconnect = nfuncs.pfnSpectatorDisconnect;
            funcs->pfnSpectatorThink = nfuncs.pfnSpectatorThink;
            funcs->pfnSysError = nfuncs.pfnSysError;
            funcs->pfnPMMove = nfuncs.pfnPMMove;
            funcs->pfnPMInit = nfuncs.pfnPMInit;
            funcs->pfnPMFindTextureType = nfuncs.pfnPMFindTextureType;
            funcs->pfnSetupVisibility = nfuncs.pfnSetupVisibility;
            funcs->pfnUpdateClientData = nfuncs.pfnUpdateClientData;
            funcs->pfnAddToFullPack = nfuncs.pfnAddToFullPack;
            funcs->pfnCreateBaseline = nfuncs.pfnCreateBaseline;
            funcs->pfnRegisterEncoders = nfuncs.pfnRegisterEncoders;
            funcs->pfnGetWeaponData = nfuncs.pfnGetWeaponData;
            funcs->pfnCmdStart = nfuncs.pfnCmdStart;
            funcs->pfnCmdEnd = nfuncs.pfnCmdEnd;
            funcs->pfnConnectionlessPacket = nfuncs.pfnConnectionlessPacket;
            funcs->pfnGetHullBounds = nfuncs.pfnGetHullBounds;
            funcs->pfnCreateInstancedBaselines = nfuncs.pfnCreateInstancedBaselines;
            funcs->pfnInconsistentFile = nfuncs.pfnInconsistentFile;
            funcs->pfnAllowLagCompensation = nfuncs.pfnAllowLagCompensation;

            res = 1;
        }
        return res;
    };
    internal static NativeGetEntityApi2Delegate GetEntityApi2PostWrapper = (nint pFunctionTable, nint interfaceVersion) =>
    {
        int res = 0;
        unsafe
        {
            NativeDllFuncs nfuncs = DllFunctions_Post.GetNative();
            NativeDllFuncs* funcs = (NativeDllFuncs*)pFunctionTable;

            funcs->pfnGameInit = nfuncs.pfnGameInit;
            funcs->pfnSpawn = nfuncs.pfnSpawn;
            funcs->pfnThink = nfuncs.pfnThink;
            funcs->pfnUse = nfuncs.pfnUse;
            funcs->pfnTouch = nfuncs.pfnTouch;
            funcs->pfnBlocked = nfuncs.pfnBlocked;
            funcs->pfnKeyValue = nfuncs.pfnKeyValue;
            funcs->pfnSave = nfuncs.pfnSave;
            funcs->pfnRestore = nfuncs.pfnRestore;
            funcs->pfnSetAbsBox = nfuncs.pfnSetAbsBox;
            funcs->pfnSaveWriteFields = nfuncs.pfnSaveWriteFields;
            funcs->pfnSaveReadFields = nfuncs.pfnSaveReadFields;
            funcs->pfnSaveGlobalState = nfuncs.pfnSaveGlobalState;
            funcs->pfnRestoreGlobalState = nfuncs.pfnRestoreGlobalState;
            funcs->pfnResetGlobalState = nfuncs.pfnResetGlobalState;
            funcs->pfnClientConnect = nfuncs.pfnClientConnect;
            funcs->pfnClientDisconnect = nfuncs.pfnClientDisconnect;
            funcs->pfnClientKill = nfuncs.pfnClientKill;
            funcs->pfnClientPutInServer = nfuncs.pfnClientPutInServer;
            funcs->pfnClientCommand = nfuncs.pfnClientCommand;
            funcs->pfnClientUserInfoChanged = nfuncs.pfnClientUserInfoChanged;
            funcs->pfnServerActivate = nfuncs.pfnServerActivate;
            funcs->pfnServerDeactivate = nfuncs.pfnServerDeactivate;
            funcs->pfnPlayerPreThink = nfuncs.pfnPlayerPreThink;
            funcs->pfnPlayerPostThink = nfuncs.pfnPlayerPostThink;
            funcs->pfnStartFrame = nfuncs.pfnStartFrame;
            funcs->pfnParmsNewLevel = nfuncs.pfnParmsNewLevel;
            funcs->pfnParmsChangeLevel = nfuncs.pfnParmsChangeLevel;
            funcs->pfnGetGameDescription = nfuncs.pfnGetGameDescription;
            funcs->pfnPlayerCustomization = nfuncs.pfnPlayerCustomization;
            funcs->pfnSpectatorConnect = nfuncs.pfnSpectatorConnect;
            funcs->pfnSpectatorDisconnect = nfuncs.pfnSpectatorDisconnect;
            funcs->pfnSpectatorThink = nfuncs.pfnSpectatorThink;
            funcs->pfnSysError = nfuncs.pfnSysError;
            funcs->pfnPMMove = nfuncs.pfnPMMove;
            funcs->pfnPMInit = nfuncs.pfnPMInit;
            funcs->pfnPMFindTextureType = nfuncs.pfnPMFindTextureType;
            funcs->pfnSetupVisibility = nfuncs.pfnSetupVisibility;
            funcs->pfnUpdateClientData = nfuncs.pfnUpdateClientData;
            funcs->pfnAddToFullPack = nfuncs.pfnAddToFullPack;
            funcs->pfnCreateBaseline = nfuncs.pfnCreateBaseline;
            funcs->pfnRegisterEncoders = nfuncs.pfnRegisterEncoders;
            funcs->pfnGetWeaponData = nfuncs.pfnGetWeaponData;
            funcs->pfnCmdStart = nfuncs.pfnCmdStart;
            funcs->pfnCmdEnd = nfuncs.pfnCmdEnd;
            funcs->pfnConnectionlessPacket = nfuncs.pfnConnectionlessPacket;
            funcs->pfnGetHullBounds = nfuncs.pfnGetHullBounds;
            funcs->pfnCreateInstancedBaselines = nfuncs.pfnCreateInstancedBaselines;
            funcs->pfnInconsistentFile = nfuncs.pfnInconsistentFile;
            funcs->pfnAllowLagCompensation = nfuncs.pfnAllowLagCompensation;

            res = 1;
        }
        return res;
    };

    internal static NativeGetNewDllFunctionsDelegate GetNewDllFunctionsWrapper = (nint pFunctionTable, nint interfaceVersion) =>
    {
        int res = 0;
        unsafe
        {
            NativeNewDllFuncs nfuncs = NewDllFunctions.GetNativeTable();
            NativeNewDllFuncs* funcs = (NativeNewDllFuncs*)pFunctionTable;
            funcs->pfnOnFreeEntPrivateData = nfuncs.pfnOnFreeEntPrivateData;
            funcs->pfnGameShutdown = nfuncs.pfnGameShutdown;
            funcs->pfnShouldCollide = nfuncs.pfnShouldCollide;
            funcs->pfnCvarValue = nfuncs.pfnCvarValue;
            funcs->pfnCvarValue2 = nfuncs.pfnCvarValue2;
            res = 1;
        }
        return res;
    };
    internal static NativeGetNewDllFunctionsDelegate GetNewDllFunctions_PostWrapper = (nint pFunctionTable, nint interfaceVersion) =>
    {
        int res = 0;
        unsafe
        {
            NativeNewDllFuncs nfuncs = NewDllFunctions_Post.GetNativeTable();
            NativeNewDllFuncs* funcs = (NativeNewDllFuncs*)pFunctionTable;
            funcs->pfnOnFreeEntPrivateData = nfuncs.pfnOnFreeEntPrivateData;
            funcs->pfnGameShutdown = nfuncs.pfnGameShutdown;
            funcs->pfnShouldCollide = nfuncs.pfnShouldCollide;
            funcs->pfnCvarValue = nfuncs.pfnCvarValue;
            funcs->pfnCvarValue2 = nfuncs.pfnCvarValue2;
            res = 1;
        }
        return res;
    };


    public static NativeMetaFuncs GetNative()
    {
#pragma warning disable CS8601 // 引用类型赋值可能为 null。
        return new()
        {
            pfnGetEntityAPI = pfnGetEntityAPI == null ? null : GetEntityApiWrapper,
            pfnGetEntityAPI_Post = GetEntityApiPostWrapper == null ? null : GetEntityApiPostWrapper,
            pfnGetEntityAPI2 = pfnGetEntityAPI2 == null ? null : GetEntityApi2Wrapper,
            pfnGetEntityAPI2_Post = pfnGetENtityAPI2_Post == null ? null : GetEntityApi2PostWrapper,
            pfnGetNewDLLFunctions = pfnGetNewDllFunctions == null ? null : GetNewDllFunctionsWrapper,
            pfnGetNewDLLFunctions_Post = pfnGetNewDllFunctions_Post == null ? null : GetNewDllFunctions_PostWrapper,
            pfnGetEngineFunctions = null,
            pfnGetEngineFunctions_Post = null,
            pfnGetStudioBlendingInterface = null,
            pfnGetStudioBlendingInterface_Post = null
        };
#pragma warning restore CS8601 // 引用类型赋值可能为 null。
    }
}
#pragma warning restore CS8500 // 这会获取托管类型的地址、获取其大小或声明指向它的指针