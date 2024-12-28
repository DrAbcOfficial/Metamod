using Metamod.Enum.Metamod;
using Metamod.Native.Common;
using Metamod.Native.Engine;
using Metamod.Native.Engine.PM;
using System.Runtime.InteropServices;

namespace Metamod.Native.Game;

[StructLayout(LayoutKind.Sequential)]
internal unsafe struct NativeDllFuncs
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


    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void GameInitDelegate();
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int SpawnDelegate(NativeEdict* pent);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void ThinkDelegate(NativeEdict* pent);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void UseDelegate(NativeEdict* pentUsed, NativeEdict* pentOther);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void TouchDelegate(NativeEdict* pentTouched, NativeEdict* pentOther);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void BlockedDelegate(NativeEdict* pentBlocked, NativeEdict* pentOther);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void KeyValueDelegate(NativeEdict* pentKeyvalue, NativeKeyValueData* pkvd);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SaveDelegate(NativeEdict* pent, NativeSaveStoreData* pSaveData);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int RestoreDelegate(NativeEdict* pent, NativeSaveStoreData* pSaveData, int globalEntity);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetAbsBoxDelegate(NativeEdict* pent);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SaveWriteFieldsDelegate(NativeSaveStoreData* pSaveData, byte* name, nint data, NativeTypeDescription* typeDescription, int count);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SaveReadFieldsDelegate(NativeSaveStoreData* pSaveData, byte* name, nint data, NativeTypeDescription* typeDescription, int count);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SaveGlobalStateDelegate(NativeSaveStoreData* pSaveData);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void RestoreGlobalStateDelegate(NativeSaveStoreData* pSaveData);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void ResetGlobalStateDelegate();

    //szRejectReason len 128
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate QBoolean ClientConnectDelegate(NativeEdict* pEntity, byte* pszName, byte* pszAddress, byte* szRejectReason);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void ClientDisconnectDelegate(NativeEdict* pEntity);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void ClientKillDelegate(NativeEdict* pEntity);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void ClientPutInServerDelegate(NativeEdict* pEntity);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void ClientCommandDelegate(NativeEdict* pEntity);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void ClientUserInfoChangedDelegate(NativeEdict* pEntity, byte* infobuffer);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void ServerActivateDelegate(NativeEdict* pEdictList, int edictCount, int clientMax);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void ServerDeactivateDelegate();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void PlayerPreThinkDelegate(NativeEdict* pEntity);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void PlayerPostThinkDelegate(NativeEdict* pEntity);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void StartFrameDelegate();
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void ParmsNewLevelDelegate();
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void ParmsChangeLevelDelegate();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate byte* GetGameDescriptionDelegate();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void PlayerCustomizationDelegate(NativeEdict* pEntity, NativeCustomization* pCustom);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SpectatorConnectDelegate(NativeEdict* pEntity);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SpectatorDisconnectDelegate(NativeEdict* pEntity);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SpectatorThinkDelegate(NativeEdict* pEntity);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SysErrorDelegate(byte* error_string);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void PMMoveDelegate(NativePlayerMove* ppmove, QBoolean server);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void PMInitDelegate(NativePlayerMove* ppmove);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate byte PMFindTextureTypeDelegate(byte* name);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetupVisibilityDelegate(NativeEdict* pViewEntity, NativeEdict* pClient, byte** pvs, byte** pas);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void UpdateClientDataDelegate(NativeEdict* ent, int sendweapons, NativeClientData* cd);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int AddToFullPackDelegate(NativeEntityState* state, int e, NativeEdict* ent, NativeEdict* host, int hostflags, int player, byte* pSet);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void CreateBaselineDelegate(int player, int eindex, NativeEntityState* baseline, NativeEdict* entity, int playermodelindex, NativeVector3f player_mins, NativeVector3f player_maxs);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void RegisterEncodersDelegate();
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int GetWeaponDataDelegate(NativeEdict* player, NativeWeaponData* info);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void CmdStartDelegate(NativeEdict* player, NativeUserCmd* cmd, uint random_seed);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void CmdEndDelegate(NativeEdict* player);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int ConnectionlessPacketDelegate(NativeNetAdr* net_from, byte* args, byte* response_buffer, int* response_buffer_size);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int GetHullBoundsDelegate(int hullnumber, float* mins, float* maxs);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void CreateInstancedBaselinesDelegate();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int InconsistentFileDelegate(NativeEdict* player, byte* filename, byte* disconnect_message);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int AllowLagCompensationDelegate();
}
