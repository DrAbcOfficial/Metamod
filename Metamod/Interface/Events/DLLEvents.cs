using Metamod.Wrapper.Common;
using Metamod.Wrapper.Engine;
using Metamod.Wrapper.Engine.PM;

namespace Metamod.Interface.Events;

#region delegates
#region dll functions
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
public delegate byte PMFindTextureTypeDelegate(string name);
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
#endregion
#endregion

public class DLLEvents
{
    #region Events
    public event GameInitDelegate? GameInit;
    public event SpawnDelegate? Spawn;
    public event ThinkDelegate? Think;
    public event UseDelegate? Use;
    public event TouchDelegate? Touch;
    public event BlockedDelegate? Blocked;
    public event KeyValueDelegate? KeyValue;
    public event SaveDelegate? Save;
    public event RestoreDelegate? Restore;
    public event SetAbsBoxDelegate? SetAbsBox;
    public event SaveWriteFieldsDelegate? SaveWriteFields;
    public event SaveReadFieldsDelegate? SaveReadFields;
    public event SaveGlobalStateDelegate? SaveGlobalState;
    public event RestoreGlobalStateDelegate? RestoreGlobalState;
    public event ResetGlobalStateDelegate? ResetGlobalState;
    public event ClientConnectDelegate? ClientConnect;
    public event ClientDisconnectDelegate? ClientDisconnect;
    public event ClientKillDelegate? ClientKill;
    public event ClientPutInServerDelegate? ClientPutInServer;
    public event DllClientCommandDelegate? ClientCommand;
    public event ClientUserInfoChangedDelegate? ClientUserInfoChanged;
    public event ServerActivateDelegate? ServerActivate;
    public event ServerDeactivateDelegate? ServerDeactivate;
    public event PlayerPreThinkDelegate? PlayerPreThink;
    public event PlayerPostThinkDelegate? PlayerPostThink;
    public event StartFrameDelegate? StartFrame;
    public event ParmsNewLevelDelegate? ParmsNewLevel;
    public event ParmsChangeLevelDelegate? ParmsChangeLevel;
    public event GetGameDescriptionDelegate? GetGameDescription;
    public event PlayerCustomizationDelegate? PlayerCustomization;
    public event SpectatorConnectDelegate? SpectatorConnect;
    public event SpectatorDisconnectDelegate? SpectatorDisconnect;
    public event SpectatorThinkDelegate? SpectatorThink;
    public event SysErrorDelegate? SysError;
    public event PMMoveDelegate? PM_Move;
    public event PMInitDelegate? PM_Init;
    public event PMFindTextureTypeDelegate? PM_FindTextureType;
    public event SetupVisibilityDelegate? SetupVisibility;
    public event UpdateClientDataDelegate? UpdateClientData;
    public event AddToFullPackDelegate? AddToFullPack;
    public event CreateBaselineDelegate? CreateBaseline;
    public event RegisterEncodersDelegate? RegisterEncoders;
    public event GetWeaponDataDelegate? GetWeaponData;
    public event CmdStartDelegate? CmdStart;
    public event CmdEndDelegate? CmdEnd;
    public event ConnectionlessPacketDelegate? ConnectionlessPacket;
    public event GetHullBoundsDelegate? GetHullBounds;
    public event CreateInstancedBaselinesDelegate? CreateInstancedBaselines;
    public event InconsistentFileDelegate? InconsistentFile;
    public event AllowLagCompensationDelegate? AllowLagCompensation;
    #endregion
    #region Invoker
    internal void InvokeGameInit()
    {
        GameInit?.Invoke();
    }
    internal int InvokeSpawn(Edict pent)
    {
        if(Spawn != null)
            return Spawn.Invoke(pent);
        return 0;
    }
    internal void InvokeThink(Edict pent)
    {
        Think?.Invoke(pent);
    }
    internal void InvokeUse(Edict pentUsed, Edict pentOther)
    {
        Use?.Invoke(pentUsed, pentOther);
    }
    internal void InvokeTouch(Edict pentTouched, Edict pentOther)
    {
        Touch?.Invoke(pentTouched, pentOther);
    }
    internal void InvokeBlocked(Edict pentBlocked, Edict pentOther)
    {
        Blocked?.Invoke(pentBlocked, pentOther);
    }
    internal void InvokeKeyValue(Edict pentKeyvalue, KeyValueData pkvd)
    {
        KeyValue?.Invoke(pentKeyvalue, pkvd);
    }
    internal void InvokeSave(Edict pent, nint pSaveData)
    {
        Save?.Invoke(pent, pSaveData);
    }
    internal int InvokeRestore(Edict pent, nint pSaveData, int globalEntity)
    {
        if (Restore != null)
            return Restore.Invoke(pent, pSaveData, globalEntity);
        return 1;
    }
    internal void InvokeSetAbsBox(Edict pent)
    {
        SetAbsBox?.Invoke(pent);
    }
    internal void InvokeSaveWriteFields(nint a, nint b, nint c, nint d, int max)
    {
        SaveWriteFields?.Invoke(a, b, c, d, max);
    }
    internal void InvokeSaveReadFields(nint a, nint b, nint c, nint d, int max)
    {
        SaveReadFields?.Invoke(a, b, c, d, max);
    }
    internal void InvokeSaveGlobalState(nint pSaveData)
    {
        SaveGlobalState?.Invoke(pSaveData);
    }
    internal void InvokeRestoreGlobalState(nint pSaveData)
    {
        RestoreGlobalState?.Invoke(pSaveData);
    }
    internal void InvokeResetGlobalState()
    {
        ResetGlobalState?.Invoke();
    }
    internal bool InvokeClientConnect(Edict pEntity, string pszName, string pszAddress, ref string szRejectReason)
    {
        if (ClientConnect != null)
            return ClientConnect.Invoke(pEntity, pszName, pszAddress, ref szRejectReason);
        return true;
    }
    internal void InvokeClientDisconnect(Edict pEntity)
    {
        ClientDisconnect?.Invoke(pEntity);
    }
    internal void InvokeClientKill(Edict pEntity)
    {
        ClientKill?.Invoke(pEntity);
    }
    internal void InvokeClientPutInServer(Edict pEntity)
    {
        ClientPutInServer?.Invoke(pEntity);
    }
    internal void InvokeClientCommand(Edict pEntity)
    {
        ClientCommand?.Invoke(pEntity);
    }
    internal void InvokeClientUserInfoChanged(Edict pEntity, ref string infobuffer)
    {
        ClientUserInfoChanged?.Invoke(pEntity, ref infobuffer);
    }
    internal void InvokeServerActivate(Edict pEdictList, int edictCount, int clientMax)
    {
        ServerActivate?.Invoke(pEdictList, edictCount, clientMax);
    }
    internal void InvokeServerDeactivate()
    {
        ServerDeactivate?.Invoke();
    }
    internal void InvokePlayerPreThink(Edict pEntity)
    {
        PlayerPreThink?.Invoke(pEntity);
    }
    internal void InvokePlayerPostThink(Edict pEntity)
    {
        PlayerPostThink?.Invoke(pEntity);
    }
    internal void InvokeStartFrame()
    {
        StartFrame?.Invoke();
    }
    internal void InvokeParmsNewLevel()
    {
        ParmsNewLevel?.Invoke();
    }
    internal void InvokeParmsChangeLevel()
    {
        ParmsChangeLevel?.Invoke();
    }
    internal string InvokeGetGameDescription()
    {
        if (GetGameDescription != null)
            return GetGameDescription.Invoke();
        return string.Empty;
    }
    internal void InvokePlayerCustomization(Edict pEntity, Customization pCustom)
    {
        PlayerCustomization?.Invoke(pEntity, pCustom);
    }
    internal void InvokeSpectatorConnect(Edict pEntity)
    {
        SpectatorConnect?.Invoke(pEntity);
    }
    internal void InvokeSpectatorDisconnect(Edict pEntity)
    {
        SpectatorDisconnect?.Invoke(pEntity);
    }
    internal void InvokeSpectatorThink(Edict pEntity)
    {
        SpectatorThink?.Invoke(pEntity);
    }
    internal void InvokeSysError(string error_string)
    {
        SysError?.Invoke(error_string);
    }
    internal void InvokePM_Move(PlayerMove pm, bool server)
    {
        PM_Move?.Invoke(pm, server);
    }
    internal void InvokePM_Init(PlayerMove pm)
    {
        PM_Init?.Invoke(pm);
    }
    internal byte InvokePM_FindTextureType(string name)
    {
        if (PM_FindTextureType != null)
            return PM_FindTextureType.Invoke(name);
        return 0;
    }
    internal void InvokeSetupVisibility(Edict pViewEntity, Edict pClient, ref byte[] pvs, ref byte[] pas)
    {
        SetupVisibility?.Invoke(pViewEntity, pClient, ref pvs, ref pas);
    }
    internal void InvokeUpdateClientData(Edict ent, int sendweapons, ClientData cd)
    {
        UpdateClientData?.Invoke(ent, sendweapons, cd);
    }
    internal int InvokeAddToFullPack(EntityState state, int e, Edict ent, Edict host, int hostflags, int player, byte[] pSet)
    {
        if (AddToFullPack != null)
            return AddToFullPack.Invoke(state, e, ent, host, hostflags, player, pSet);
        return 0;
    }
    internal void InvokeCreateBaseline(int player, int eindex, EntityState baseline, Edict entity, int playermodelindex, Vector3f player_mins, Vector3f player_maxs)
    {
        CreateBaseline?.Invoke(player, eindex, baseline, entity, playermodelindex, player_mins, player_maxs);
    }
    internal void InvokeRegisterEncoders()
    {
        RegisterEncoders?.Invoke();
    }
    internal int InvokeGetWeaponData(Edict player, WeaponData info)
    {
        if (GetWeaponData != null)
            return GetWeaponData.Invoke(player, info);
        return 0;
    }
    internal void InvokeCmdStart(Edict plyer, UserCmd cmd, uint random_seed)
    {
        CmdStart?.Invoke(plyer, cmd, random_seed);
    }
    internal void InvokeCmdEnd(Edict plyer)
    {
        CmdEnd?.Invoke(plyer);
    }
    internal int InvokeConnectionlessPacket(NetAdr net_from, string args, ref string response_buffer, ref int response_buffer_size)
    {
        if (ConnectionlessPacket != null)
            return ConnectionlessPacket.Invoke(net_from, args, ref response_buffer, ref response_buffer_size);
        return 0;
    }
    internal int InvokeGetHullBounds(int hullnumber, ref Vector3f mins, ref Vector3f maxs)
    {
        if (GetHullBounds != null)
            return GetHullBounds.Invoke(hullnumber, ref mins, ref maxs);
        return 0;
    }
    internal void InvokeCreateInstancedBaselines()
    {
        CreateInstancedBaselines?.Invoke();
    }
    internal int InvokeInconsistentFile(Edict player, string filename, ref string disconnect_message)
    {
        return InconsistentFile?.Invoke(player, filename, ref disconnect_message) ?? 0;
    }
    internal int InvokeAllowLagCompensation()
    {
        if (AllowLagCompensation != null)
            return AllowLagCompensation.Invoke();
        return 0;
    }
    #endregion
    #region Null Checker
    internal bool IsGameInitNull => GameInit == null;
    internal bool IsSpawnNull => Spawn == null;
    internal bool IsThinkNull => Think == null;
    internal bool IsUseNull => Use == null;
    internal bool IsTouchNull => Touch == null;
    internal bool IsBlockedNull => Blocked == null;
    internal bool IsKeyValueNull => KeyValue == null;
    internal bool IsSaveNull => Save == null;
    internal bool IsRestoreNull => Restore == null;
    internal bool IsSetAbsBoxNull => SetAbsBox == null;
    internal bool IsSaveWriteFieldsNull => SaveWriteFields == null;
    internal bool IsSaveReadFieldsNull => SaveReadFields == null;
    internal bool IsSaveGlobalStateNull => SaveGlobalState == null;
    internal bool IsRestoreGlobalStateNull => RestoreGlobalState == null;
    internal bool IsResetGlobalStateNull => ResetGlobalState == null;
    internal bool IsClientConnectNull => ClientConnect == null;
    internal bool IsClientDisconnectNull => ClientDisconnect == null;
    internal bool IsClientKillNull => ClientKill == null;
    internal bool IsClientPutInServerNull => ClientPutInServer == null;
    internal bool IsClientCommandNull => ClientCommand == null;
    internal bool IsClientUserInfoChangedNull => ClientUserInfoChanged == null;
    internal bool IsServerActivateNull => ServerActivate == null;
    internal bool IsServerDeactivateNull => ServerDeactivate == null;
    internal bool IsPlayerPreThinkNull => PlayerPreThink == null;
    internal bool IsPlayerPostThinkNull => PlayerPostThink == null;
    internal bool IsStartFrameNull => StartFrame == null;
    internal bool IsParmsNewLevelNull => ParmsNewLevel == null;
    internal bool IsParmsChangeLevelNull => ParmsChangeLevel == null;
    internal bool IsGetGameDescriptionNull => GetGameDescription == null;
    internal bool IsPlayerCustomizationNull => PlayerCustomization == null;
    internal bool IsSpectatorConnectNull => SpectatorConnect == null;
    internal bool IsSpectatorDisconnectNull => SpectatorDisconnect == null;
    internal bool IsSpectatorThinkNull => SpectatorThink == null;
    internal bool IsSysErrorNull => SysError == null;
    internal bool IsPM_MoveNull => PM_Move == null;
    internal bool IsPM_InitNull => PM_Init == null;
    internal bool IsPM_FindTextureTypeNull => PM_FindTextureType == null;
    internal bool IsSetupVisibilityNull => SetupVisibility == null;
    internal bool IsUpdateClientDataNull => UpdateClientData == null;
    internal bool IsAddToFullPackNull => AddToFullPack == null;
    internal bool IsCreateBaselineNull => CreateBaseline == null;
    internal bool IsRegisterEncodersNull => RegisterEncoders == null;
    internal bool IsGetWeaponDataNull => GetWeaponData == null;
    internal bool IsCmdStartNull => CmdStart == null;
    internal bool IsCmdEndNull => CmdEnd == null;
    internal bool IsConnectionlessPacketNull => ConnectionlessPacket == null;
    internal bool IsGetHullBoundsNull => GetHullBounds == null;
    internal bool IsCreateInstancedBaselinesNull => CreateInstancedBaselines == null;
    internal bool IsInconsistentFileNull => InconsistentFile == null;
    internal bool IsAllowLagCompensationNull => AllowLagCompensation == null;
    #endregion
}