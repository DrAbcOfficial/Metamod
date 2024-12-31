using Metamod.Enum.Metamod;
using Metamod.Native.Common;
using Metamod.Native.Engine;
using Metamod.Native.Engine.PM;
using System.Runtime.InteropServices;

namespace Metamod.Native.Game;

[StructLayout(LayoutKind.Sequential)]
public struct NativeDllFuncs
{
    internal GameInitDelegate pfnGameInit;
    internal SpawnDelegate pfnSpawn;
    internal ThinkDelegate pfnThink;
    internal UseDelegate pfnUse;
    internal TouchDelegate pfnTouch;
    internal BlockedDelegate pfnBlocked;
    internal KeyValueDelegate pfnKeyValue;
    internal SaveDelegate pfnSave;
    internal RestoreDelegate pfnRestore;
    internal SetAbsBoxDelegate pfnSetAbsBox;

    internal SaveWriteFieldsDelegate pfnSaveWriteFields;
    internal SaveReadFieldsDelegate pfnSaveReadFields;

    internal SaveGlobalStateDelegate pfnSaveGlobalState;
    internal RestoreGlobalStateDelegate pfnRestoreGlobalState;
    internal ResetGlobalStateDelegate pfnResetGlobalState;

    internal ClientConnectDelegate pfnClientConnect;
    internal ClientDisconnectDelegate pfnClientDisconnect;
    internal ClientKillDelegate pfnClientKill;
    internal ClientPutInServerDelegate pfnClientPutInServer;
    internal ClientCommandDelegate pfnClientCommand;
    internal ClientUserInfoChangedDelegate pfnClientUserInfoChanged;

    internal ServerActivateDelegate pfnServerActivate;
    internal ServerDeactivateDelegate pfnServerDeactivate;

    internal PlayerPreThinkDelegate pfnPlayerPreThink;
    internal PlayerPostThinkDelegate pfnPlayerPostThink;

    internal StartFrameDelegate pfnStartFrame;
    internal ParmsNewLevelDelegate pfnParmsNewLevel;
    internal ParmsChangeLevelDelegate pfnParmsChangeLevel;

    internal GetGameDescriptionDelegate pfnGetGameDescription;
    internal PlayerCustomizationDelegate pfnPlayerCustomization;
    internal SpectatorConnectDelegate pfnSpectatorConnect;
    internal SpectatorDisconnectDelegate pfnSpectatorDisconnect;
    internal SpectatorThinkDelegate pfnSpectatorThink;
    internal SysErrorDelegate pfnSysError;

    internal PMMoveDelegate pfnPMMove;
    internal PMInitDelegate pfnPMInit;
    internal PMFindTextureTypeDelegate pfnPMFindTextureType;
    internal SetupVisibilityDelegate pfnSetupVisibility;
    internal UpdateClientDataDelegate pfnUpdateClientData;
    internal AddToFullPackDelegate pfnAddToFullPack;
    internal CreateBaselineDelegate pfnCreateBaseline;
    internal RegisterEncodersDelegate pfnRegisterEncoders;
    internal GetWeaponDataDelegate pfnGetWeaponData;

    internal CmdStartDelegate pfnCmdStart;
    internal CmdEndDelegate pfnCmdEnd;

    internal ConnectionlessPacketDelegate pfnConnectionlessPacket;

    internal GetHullBoundsDelegate pfnGetHullBounds;
    internal CreateInstancedBaselinesDelegate pfnCreateInstancedBaselines;

    internal InconsistentFileDelegate pfnInconsistentFile;
    internal AllowLagCompensationDelegate pfnAllowLagCompensation;

#pragma warning disable CS8500 // 这会获取托管类型的地址、获取其大小或声明指向它的指针
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void GameInitDelegate();
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int SpawnDelegate(nint pent);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void ThinkDelegate(nint pent);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void UseDelegate(nint pentUsed, nint pentOther);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void TouchDelegate(nint pentTouched, nint pentOther);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void BlockedDelegate(nint pentBlocked, nint pentOther);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void KeyValueDelegate(nint pentKeyvalue, nint pkvd);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SaveDelegate(nint pent, nint pSaveData);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int RestoreDelegate(nint pent, nint pSaveData, int globalEntity);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetAbsBoxDelegate(nint pent);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SaveWriteFieldsDelegate(nint pSaveData, nint name, nint data, nint typeDescription, int count);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SaveReadFieldsDelegate(nint pSaveData, nint name, nint data, nint typeDescription, int count);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SaveGlobalStateDelegate(nint pSaveData);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void RestoreGlobalStateDelegate(nint pSaveData);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void ResetGlobalStateDelegate();

    //szRejectReason len 128
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate QBoolean ClientConnectDelegate(nint pEntity, nint pszName, nint pszAddress, nint szRejectReason);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void ClientDisconnectDelegate(nint pEntity);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void ClientKillDelegate(nint pEntity);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void ClientPutInServerDelegate(nint pEntity);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void ClientCommandDelegate(nint pEntity);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void ClientUserInfoChangedDelegate(nint pEntity, nint infobuffer);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void ServerActivateDelegate(nint pEdictList, int edictCount, int clientMax);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void ServerDeactivateDelegate();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void PlayerPreThinkDelegate(nint pEntity);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void PlayerPostThinkDelegate(nint pEntity);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void StartFrameDelegate();
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void ParmsNewLevelDelegate();
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void ParmsChangeLevelDelegate();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint GetGameDescriptionDelegate();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void PlayerCustomizationDelegate(nint pEntity, nint pCustom);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SpectatorConnectDelegate(nint pEntity);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SpectatorDisconnectDelegate(nint pEntity);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SpectatorThinkDelegate(nint pEntity);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SysErrorDelegate(nint error_string);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void PMMoveDelegate(nint ppmove, QBoolean server);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void PMInitDelegate(nint ppmove);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate byte PMFindTextureTypeDelegate(nint name);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetupVisibilityDelegate(nint pViewEntity, nint pClient, nint pvs, nint pas);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void UpdateClientDataDelegate(nint ent, int sendweapons, nint cd);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int AddToFullPackDelegate(nint state, int e, nint ent, nint host, int hostflags, int player, nint pSet);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void CreateBaselineDelegate(int player, int eindex, nint baseline, nint entity, int playermodelindex, nint player_mins, nint player_maxs);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void RegisterEncodersDelegate();
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int GetWeaponDataDelegate(nint player, nint info);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void CmdStartDelegate(nint player, nint cmd, uint random_seed);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void CmdEndDelegate(nint player);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int ConnectionlessPacketDelegate(nint net_from, nint args, nint response_buffer, nint response_buffer_size);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int GetHullBoundsDelegate(int hullnumber, nint mins, nint maxs);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void CreateInstancedBaselinesDelegate();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int InconsistentFileDelegate(nint player, nint filename, nint disconnect_message);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int AllowLagCompensationDelegate();
#pragma warning restore CS8500 // 这会获取托管类型的地址、获取其大小或声明指向它的指针
}
