using Metamod.Struct.Common;
using Metamod.Struct.Engine;
using Metamod.Struct.Engine.PM;

namespace Metamod.Interface;

public delegate void GameInitDelegate();
public delegate int SpawnDelegate(Edict pent);
public delegate void ThinkDelegate(Edict pent);
public delegate void UseDelegate(Edict pentUsed, Edict pentOther);
public delegate void TouchDelegate(Edict pentTouched, Edict pentOther);
public delegate void BlockedDelegate(Edict pentBlocked, Edict pentOther);
public delegate void KeyValueDelegate(Edict pentKeyvalue, KeyValueData pkvd);
public delegate void SaveDelegate(Edict pent, nint pSaveData);
public delegate int RestoreDelegate(Edict pent, nint pSaveData, int globalEntity);
public delegate void SetAbsBoxDelegate(Edict pent);
public delegate void SaveWriteFieldsDelegate(nint a, nint b, nint c, nint d, int max);
public delegate void SaveReadFieldsDelegate(nint a, nint b, nint c, nint d, int max);
public delegate void SaveGlobalStateDelegate(nint pSaveData);
public delegate void RestoreGlobalStateDelegate(nint pSaveData);
public delegate void ResetGlobalStateDelegate();
public delegate bool ClientConnectDelegate(Edict pEntity, string pszName, string pszAddress, ref string szRejectReason);
public delegate void ClientDisconnectDelegate(Edict pEntity);
public delegate void ClientKillDelegate(Edict pEntity);
public delegate void ClientPutInServerDelegate(Edict pEntity);
public delegate void DllClientCommandDelegate(Edict pEntity);
public delegate void ClientUserInfoChangedDelegate(Edict pEntity, ref string infobuffer);
public delegate void ServerActivateDelegate(Edict pEdictList, int edictCount, int clientMax);
public delegate void ServerDeactivateDelegate();
public delegate void PlayerPreThinkDelegate(Edict pEntity);
public delegate void PlayerPostThinkDelegate(Edict pEntity);
public delegate void StartFrameDelegate();
public delegate void ParmsNewLevelDelegate();
public delegate void ParmsChangeLevelDelegate();
public delegate string GetGameDescriptionDelegate();
public delegate void PlayerCustomizationDelegate(Edict pEntity, Customization pCustom);
public delegate void SpectatorConnectDelegate(Edict pEntity);
public delegate void SpectatorDisconnectDelegate(Edict pEntity);
public delegate void SpectatorThinkDelegate(Edict pEntity);
public delegate void SysErrorDelegate(string error_string);
public delegate void PMMoveDelegate(PlayerMove pm, bool server);
public delegate void PMInitDelegate(PlayerMove pm);
public delegate int PMFindTextureTypeDelegate(string name);
public delegate void SetupVisibilityDelegate(Edict pViewEntity, Edict pClient, ref byte[] pvs, ref byte[] pas);
public delegate void UpdateClientDataDelegate(Edict ent, int sendweapons, ClientData cd);
public delegate int AddToFullPackDelegate(EntityState state, int e, Edict ent, Edict host, int hostflags, int player, byte[] pSet);
public delegate void CreateBaselineDelegate(int player, int eindex, EntityState baseline, Edict entity, int playermodelindex, Vector3f player_mins, Vector3f player_maxs);
public delegate void RegisterEncodersDelegate();
public delegate int GetWeaponDataDelegate(Edict player, WeaponData info);
public delegate void CmdStartDelegate(Edict plyer, UserCmd cmd, uint random_seed);
public delegate void CmdEndDelegate(Edict plyer);
public delegate int ConnectionlessPacketDelegate(NetAdr net_from, string args, ref string response_buffer, ref int response_buffer_size);
public delegate int GetHullBoundsDelegate(int hullnumber, ref Vector3f mins, ref Vector3f maxs);
public delegate void CreateInstancedBaselinesDelegate();
public delegate int InconsistentFileDelegate(Edict player, string filename, ref string disconnect_message);
public delegate int AllowLagCompensationDelegate();


public interface IDllFunctions
{
    public GameInitDelegate? pfnGameInit { get; set; }
    public SpawnDelegate? pfnSpawn { get; set; }
    public ThinkDelegate? pfnThink { get; set; }
    public UseDelegate? pfnUse { get; set; }
    public TouchDelegate? pfnTouch { get; set; }
    public BlockedDelegate? pfnBlocked { get; set; }
    public KeyValueDelegate? pfnKeyValue { get; set; }
    public SaveDelegate? pfnSave { get; set; }
    public RestoreDelegate? pfnRestore { get; set; }
    public SetAbsBoxDelegate? pfnSetAbsBox { get; set; }
    public SaveWriteFieldsDelegate? pfnSaveWriteFields { get; set; }
    public SaveReadFieldsDelegate? pfnSaveReadFields { get; set; }
    public SaveGlobalStateDelegate? pfnSaveGlobalState { get; set; }
    public RestoreGlobalStateDelegate? pfnRestoreGlobalState { get; set; }
    public ResetGlobalStateDelegate? pfnResetGlobalState { get; set; }
    public ClientConnectDelegate? pfnClientConnect { get; set; }
    public ClientDisconnectDelegate? pfnClientDisconnect { get; set; }
    public ClientKillDelegate? pfnClientKill { get; set; }
    public ClientPutInServerDelegate? pfnClientPutInServer { get; set; }
    public EngineClientCommandDelegate? pfnClientCommand { get; set; }
    public ClientUserInfoChangedDelegate? pfnClientUserInfoChanged { get; set; }
    public ServerActivateDelegate? pfnServerActivate { get; set; }
    public ServerDeactivateDelegate? pfnServerDeactivate { get; set; }
    public PlayerPreThinkDelegate? pfnPlayerPreThink { get; set; }
    public PlayerPostThinkDelegate? pfnPlayerPostThink { get; set; }
    public StartFrameDelegate? pfnStartFrame { get; set; }
    public ParmsNewLevelDelegate? pfnParmsNewLevel { get; set; }
    public ParmsChangeLevelDelegate? pfnParmsChangeLevel { get; set; }
    public GetGameDescriptionDelegate? pfnGetGameDescription { get; set; }
    public PlayerCustomizationDelegate? pfnPlayerCustomization { get; set; }
    public SpectatorConnectDelegate? pfnSpectatorConnect { get; set; }
    public SpectatorDisconnectDelegate? pfnSpectatorDisconnect { get; set; }
    public SpectatorThinkDelegate? pfnSpectatorThink { get; set; }
    public SysErrorDelegate? pfnSysError { get; set; }
    public PMMoveDelegate? pfnPM_Move { get; set; }
    public PMInitDelegate? pfnPM_Init { get; set; }
    public PMFindTextureTypeDelegate? pfnPM_FindTextureType { get; set; }
    public SetupVisibilityDelegate? pfnSetupVisibility { get; set; }
    public UpdateClientDataDelegate? pfnUpdateClientData { get; set; }
    public AddToFullPackDelegate? pfnAddToFullPack { get; set; }
    public CreateBaselineDelegate? pfnCreateBaseline { get; set; }
    public RegisterEncodersDelegate? pfnRegisterEncoders { get; set; }
    public GetWeaponDataDelegate? pfnGetWeaponData { get; set; }
    public CmdStartDelegate? pfnCmdStart { get; set; }
    public CmdEndDelegate? pfnCmdEnd { get; set; }
    public ConnectionlessPacketDelegate? pfnConnectionlessPacket { get; set; }
    public GetHullBoundsDelegate? pfnGetHullBounds { get; set; }
    public CreateInstancedBaselinesDelegate? pfnCreateInstancedBaselines { get; set; }
    public InconsistentFileDelegate? pfnInconsistentFile { get; set; }
    public AllowLagCompensationDelegate? pfnAllowLagCompensation { get; set; }
}