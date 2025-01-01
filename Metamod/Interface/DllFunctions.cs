using Metamod.Native.Common;
using Metamod.Native.Engine.PM;
using Metamod.Native.Engine;
using Metamod.Native.Game;
using Metamod.Struct.Common;
using Metamod.Struct.Engine;
using Metamod.Struct.Engine.PM;
using static Metamod.Native.Game.NativeDllFuncs;
using System.Runtime.InteropServices;
using Metamod.Enum.Metamod;

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


public class DllFunctions
{
    public static GameInitDelegate? pfnGameInit { get; set; }
    public static SpawnDelegate? pfnSpawn { get; set; }
    public static ThinkDelegate? pfnThink { get; set; }
    public static UseDelegate? pfnUse { get; set; }
    public static TouchDelegate? pfnTouch { get; set; }
    public static BlockedDelegate? pfnBlocked { get; set; }
    public static KeyValueDelegate? pfnKeyValue { get; set; }
    public static SaveDelegate? pfnSave { get; set; }
    public static RestoreDelegate? pfnRestore { get; set; }
    public static SetAbsBoxDelegate? pfnSetAbsBox { get; set; }
    public static SaveWriteFieldsDelegate? pfnSaveWriteFields { get; set; }
    public static SaveReadFieldsDelegate? pfnSaveReadFields { get; set; }
    public static SaveGlobalStateDelegate? pfnSaveGlobalState { get; set; }
    public static RestoreGlobalStateDelegate? pfnRestoreGlobalState { get; set; }
    public static ResetGlobalStateDelegate? pfnResetGlobalState { get; set; }
    public static ClientConnectDelegate? pfnClientConnect { get; set; }
    public static ClientDisconnectDelegate? pfnClientDisconnect { get; set; }
    public static ClientKillDelegate? pfnClientKill { get; set; }
    public static ClientPutInServerDelegate? pfnClientPutInServer { get; set; }
    public static DllClientCommandDelegate? pfnClientCommand { get; set; }
    public static ClientUserInfoChangedDelegate? pfnClientUserInfoChanged { get; set; }
    public static ServerActivateDelegate? pfnServerActivate { get; set; }
    public static ServerDeactivateDelegate? pfnServerDeactivate { get; set; }
    public static PlayerPreThinkDelegate? pfnPlayerPreThink { get; set; }
    public static PlayerPostThinkDelegate? pfnPlayerPostThink { get; set; }
    public static StartFrameDelegate? pfnStartFrame { get; set; }
    public static ParmsNewLevelDelegate? pfnParmsNewLevel { get; set; }
    public static ParmsChangeLevelDelegate? pfnParmsChangeLevel { get; set; }
    public static GetGameDescriptionDelegate? pfnGetGameDescription { get; set; }
    public static PlayerCustomizationDelegate? pfnPlayerCustomization { get; set; }
    public static SpectatorConnectDelegate? pfnSpectatorConnect { get; set; }
    public static SpectatorDisconnectDelegate? pfnSpectatorDisconnect { get; set; }
    public static SpectatorThinkDelegate? pfnSpectatorThink { get; set; }
    public static SysErrorDelegate? pfnSysError { get; set; }
    public static PMMoveDelegate? pfnPM_Move { get; set; }
    public static PMInitDelegate? pfnPM_Init { get; set; }
    public static PMFindTextureTypeDelegate? pfnPM_FindTextureType { get; set; }
    public static SetupVisibilityDelegate? pfnSetupVisibility { get; set; }
    public static UpdateClientDataDelegate? pfnUpdateClientData { get; set; }
    public static AddToFullPackDelegate? pfnAddToFullPack { get; set; }
    public static CreateBaselineDelegate? pfnCreateBaseline { get; set; }
    public static RegisterEncodersDelegate? pfnRegisterEncoders { get; set; }
    public static GetWeaponDataDelegate? pfnGetWeaponData { get; set; }
    public static CmdStartDelegate? pfnCmdStart { get; set; }
    public static CmdEndDelegate? pfnCmdEnd { get; set; }
    public static ConnectionlessPacketDelegate? pfnConnectionlessPacket { get; set; }
    public static GetHullBoundsDelegate? pfnGetHullBounds { get; set; }
    public static CreateInstancedBaselinesDelegate? pfnCreateInstancedBaselines { get; set; }
    public static InconsistentFileDelegate? pfnInconsistentFile { get; set; }
    public static AllowLagCompensationDelegate? pfnAllowLagCompensation { get; set; }

    internal static NativeGameInitDelegate nativeGameInitCaller = () =>
    {
        pfnGameInit?.Invoke();
    };

    internal static NativeSpawnDelegate nativeOnSpawnCaller = (nint pent) =>
    {
        return pfnSpawn?.Invoke(new Edict(pent)) ?? 0;
    };

    internal static NativeThinkDelegate nativeOnThinkCaller = (nint pent) =>
    {
        pfnThink?.Invoke(new Edict(pent));
    };

    internal static NativeUseDelegate nativeOnUseCaller = (nint pentUsed, nint pentOther) =>
    {
        pfnUse?.Invoke(new Edict(pentUsed), new Edict(pentOther));
    };

    internal static NativeTouchDelegate nativeOnTouchCaller = (nint pentTouched, nint pentOther) =>
    {
        pfnTouch?.Invoke(new Edict(pentTouched), new Edict(pentOther));
    };

    internal static NativeBlockedDelegate nativeOnBlockedCaller = (nint pentBlocked, nint pentOther) =>
    {
        pfnBlocked?.Invoke(new Edict(pentBlocked), new Edict(pentOther));
    };

    internal static NativeKeyValueDelegate nativeOnKeyValueCaller = (nint pentKeyvalue, nint pkvd) =>
    {
        pfnKeyValue?.Invoke(new Edict(pentKeyvalue), new KeyValueData(pkvd));
    };

    internal static NativeSaveDelegate nativeOnSaveCaller = (nint pent, nint pSaveData) =>
    {
        pfnSave?.Invoke(new Edict(pent), pSaveData);
    };

    internal static NativeRestoreDelegate nativeOnRestoreCaller = (nint pent, nint pSaveData, int globalEntity) =>
    {
        return pfnRestore?.Invoke(new Edict(pent), pSaveData, globalEntity) ?? 0;
    };

    internal static NativeSetAbsBoxDelegate nativeOnSetAbsBoxCaller = (nint pent) =>
    {
        pfnSetAbsBox?.Invoke(new Edict(pent));
    };

    internal static NativeSaveWriteFieldsDelegate nativeOnSaveWriteFieldsCaller = (nint a, nint b, nint c, nint d, int max) =>
    {
        pfnSaveWriteFields?.Invoke(a, b, c, d, max);
    };

    internal static NativeSaveReadFieldsDelegate nativeOnSaveReadFieldsCaller = (nint a, nint b, nint c, nint d, int max) =>
    {
        pfnSaveReadFields?.Invoke(a, b, c, d, max);
    };

    internal static NativeSaveGlobalStateDelegate nativeOnSaveGlobalStateCaller = (nint pSaveData) =>
    {
        pfnSaveGlobalState?.Invoke(pSaveData);
    };

    internal static NativeRestoreGlobalStateDelegate nativeOnRestoreGlobalStateCaller = (nint pSaveData) =>
    {
        pfnRestoreGlobalState?.Invoke(pSaveData);
    };

    internal static NativeResetGlobalStateDelegate nativeOnResetGlobalStateCaller = () =>
    {
        pfnResetGlobalState?.Invoke();
    };

    internal static NativeClientConnectDelegate nativeOnClientConnectCaller = (nint pEntity, nint pszName, nint pszAddress, nint szRejectReason) =>
    {
        string reject = Marshal.PtrToStringUTF8(szRejectReason) ?? string.Empty;
        bool result = pfnClientConnect?.Invoke(new Edict(pEntity),
            Marshal.PtrToStringUTF8(pszName) ?? string.Empty, Marshal.PtrToStringUTF8(pszAddress) ?? string.Empty, ref reject) ?? false;
        byte[] rejectBytes = System.Text.Encoding.UTF8.GetBytes(reject);
        if (rejectBytes.Length > 127)
            Array.Resize(ref rejectBytes, 127);
        unsafe
        {
            byte* ppReject = (byte*)szRejectReason;
            Marshal.Copy(rejectBytes, 0, (IntPtr)ppReject, rejectBytes.Length);
            ppReject[rejectBytes.Length] = 0;
        }
        return result ? QBoolean.TRUE : QBoolean.FALSE;
    };

    internal static NativeClientDisconnectDelegate nativeOnClientDisconnectCaller = (nint pEntity) =>
    {
        pfnClientDisconnect?.Invoke(new Edict(pEntity));
    };

    internal static NativeClientKillDelegate nativeOnClientKillCaller = (nint pEntity) =>
    {
        pfnClientKill?.Invoke(new Edict(pEntity));
    };

    internal static NativeClientPutInServerDelegate nativeOnClientPutInServerCaller = (nint pEntity) =>
    {
        pfnClientPutInServer?.Invoke(new Edict(pEntity));
    };

    internal static NativeClientCommandDelegate nativeOnClientCommandCaller = (nint pEntity) =>
    {
        pfnClientCommand?.Invoke(new Edict(pEntity));
    };

    internal static NativeClientUserInfoChangedDelegate nativeOnClientUserInfoChangedCaller = (nint pEntity, nint infobuffer) =>
    {
        string str = Marshal.PtrToStringUTF8(infobuffer) ?? string.Empty;
        pfnClientUserInfoChanged?.Invoke(new Edict(pEntity), ref str);

    };

    internal static NativeServerActivateDelegate nativeOnServerActivateCaller = (nint pEdictList, int edictCount, int clientMax) =>
    {
        pfnServerActivate?.Invoke(new Edict(pEdictList), edictCount, clientMax);
    };

    internal static NativeServerDeactivateDelegate nativeOnServerDeactivateCaller = () =>
    {
        pfnServerDeactivate?.Invoke();
    };

    internal static NativePlayerPreThinkDelegate nativeOnPlayerPreThinkCaller = (nint pEntity) =>
    {
        pfnPlayerPreThink?.Invoke(new Edict(pEntity));
    };

    internal static NativePlayerPostThinkDelegate nativeOnPlayerPostThinkCaller = (nint pEntity) =>
    {
        pfnPlayerPostThink?.Invoke(new Edict(pEntity));
    };

    internal static NativeStartFrameDelegate nativeOnStartFrameCaller = () =>
    {
        pfnStartFrame?.Invoke();
    };

    internal static NativeParmsNewLevelDelegate nativeOnParmsNewLevelCaller = () =>
    {
        pfnParmsNewLevel?.Invoke();
    };

    internal static NativeParmsChangeLevelDelegate nativeOnParmsChangeLevelCaller = () =>
    {
        pfnParmsChangeLevel?.Invoke();
    };

    private static nint s_szGameDscription = Marshal.AllocHGlobal(sizeof(byte) * 256);
    internal static NativeGetGameDescriptionDelegate nativeOnGetGameDescriptionCaller = () =>
    {
        string description = pfnGetGameDescription?.Invoke() ?? string.Empty;
        byte[] descBytes = System.Text.Encoding.UTF8.GetBytes(description);
        if (descBytes.Length > 255)
            Array.Resize(ref descBytes, 255);
        Marshal.Copy(descBytes, 0, s_szGameDscription, descBytes.Length);
        return s_szGameDscription;
    };

    internal static NativePlayerCustomizationDelegate nativeOnPlayerCustomizationCaller = (nint pEntity, nint pCustom) =>
    {
        pfnPlayerCustomization?.Invoke(new Edict(pEntity), new Customization(pCustom));
    };

    internal static NativeSpectatorConnectDelegate nativeOnSpectatorConnectCaller = (nint pEntity) =>
    {
        pfnSpectatorConnect?.Invoke(new Edict(pEntity));
    };

    internal static NativeSpectatorDisconnectDelegate nativeOnSpectatorDisconnectCaller = (nint pEntity) =>
    {
        pfnSpectatorDisconnect?.Invoke(new Edict(pEntity));
    };

    internal static NativeSpectatorThinkDelegate nativeOnSpectatorThinkCaller = (nint pEntity) =>
    {
        pfnSpectatorThink?.Invoke(new Edict(pEntity));
    };

    internal static NativeSysErrorDelegate nativeOnSysErrorCaller = (nint error_string) =>
    {
        string err = Marshal.PtrToStringUTF8(error_string) ?? string.Empty;
        pfnSysError?.Invoke(err);
    };

    internal static NativePMMoveDelegate nativeOnPM_MoveCaller = (nint pm, QBoolean server) =>
    {
        pfnPM_Move?.Invoke(new PlayerMove(pm), server == QBoolean.TRUE);
    };

    internal static NativePMInitDelegate nativeOnPM_InitCaller = (nint pm) =>
    {
        pfnPM_Init?.Invoke(new PlayerMove(pm));
    };

    internal static NativePMFindTextureTypeDelegate nativeOnPM_FindTextureTypeCaller = (nint name) =>
    {
        string n = Marshal.PtrToStringUTF8(name) ?? string.Empty;
        return pfnPM_FindTextureType?.Invoke(n) ?? 0;
    };

    private static nint ppvs = Marshal.AllocHGlobal(sizeof(byte) * 32);
    private static nint ppas = Marshal.AllocHGlobal(sizeof(byte) * 32);
    internal static NativeSetupVisibilityDelegate nativeOnSetupVisibilityCaller = (nint pViewEntity, nint pClient, nint pvs, nint pas) =>
    {
        byte[] mpvs = new byte[32];
        byte[] mpas = new byte[32];
        pfnSetupVisibility?.Invoke(new Edict(pViewEntity), new Edict(pClient), ref mpvs, ref mpas);
        Marshal.Copy(mpvs, 0, ppvs, mpvs.Length);
        Marshal.Copy(mpas, 0, ppas, mpas.Length);
        Marshal.WriteIntPtr(pvs, ppvs);
        Marshal.WriteIntPtr(pas, ppas);
    };

    internal static NativeUpdateClientDataDelegate nativeOnUpdateClientDataCaller = (nint ent, int sendweapons, nint cd) =>
    {
        pfnUpdateClientData?.Invoke(new Edict(ent), sendweapons, new ClientData(cd));
    };

    internal static NativeAddToFullPackDelegate nativeOnAddToFullPackCaller = (nint state, int e, nint ent, nint host, int hostflags, int player, nint pSet) =>
    {
        byte[] mbb = [Marshal.ReadByte(pSet)];
        return pfnAddToFullPack?.Invoke(new EntityState(state), e, new Edict(ent), new Edict(host), hostflags, player, mbb) ?? 0;
    };

    internal static NativeCreateBaselineDelegate nativeOnCreateBaselineCaller = (int player, int eindex, nint baseline, nint entity, int playermodelindex, nint player_mins, nint player_maxs) =>
    {
        pfnCreateBaseline?.Invoke(player, eindex, new EntityState(baseline), new Edict(entity), playermodelindex, new Vector3f(player_mins), new Vector3f(player_maxs));
    };

    internal static NativeRegisterEncodersDelegate nativeOnRegisterEncodersCaller = () =>
    {
        pfnRegisterEncoders?.Invoke();
    };

    internal static NativeGetWeaponDataDelegate nativeOnGetWeaponDataCaller = (nint player, nint info) =>
    {
        return pfnGetWeaponData?.Invoke(new Edict(player), new WeaponData(info)) ?? 0;
    };

    internal static NativeCmdStartDelegate nativeOnCmdStartCaller = (nint plyer, nint cmd, uint random_seed) =>
    {
        pfnCmdStart?.Invoke(new Edict(plyer), new UserCmd(cmd), random_seed);
    };

    internal static NativeCmdEndDelegate nativeOnCmdEndCaller = (nint plyer) =>
    {
        pfnCmdEnd?.Invoke(new Edict(plyer));
    };

    private static nint s_respondbuffer = Marshal.AllocHGlobal(sizeof(byte) * 256);
    internal static NativeConnectionlessPacketDelegate nativeOnConnectionlessPacketCaller = (nint net_from, nint args, nint response_buffer, nint response_buffer_size) =>
    {
        string aargs = Marshal.PtrToStringUTF8(args) ?? string.Empty;
        string mrespond = "";
        int respond_len = 0;
        int res = pfnConnectionlessPacket?.Invoke(new NetAdr(net_from), aargs, ref mrespond, ref respond_len) ?? 0;
        byte[] respond = System.Text.Encoding.UTF8.GetBytes(mrespond);
        if (respond.Length > 255)
            Array.Resize(ref respond, 255);
        Marshal.Copy(respond, 0, s_respondbuffer, respond.Length);
        response_buffer = s_respondbuffer;
        Marshal.WriteInt32(response_buffer_size, respond.Length);
        return res;
    };

    internal static NativeGetHullBoundsDelegate nativeOnGetHullBoundsCaller = (int hullnumber, nint mins, nint maxs) =>
    {
        var v1 = new Vector3f(mins);
        var v2 = new Vector3f(maxs);
        return pfnGetHullBounds?.Invoke(hullnumber, ref v1, ref v2) ?? 0;
    };

    internal static NativeCreateInstancedBaselinesDelegate nativeOnCreateInstancedBaselinesCaller = () =>
    {
        pfnCreateInstancedBaselines?.Invoke();
    };

    private static nint s_disconnect_message = Marshal.AllocHGlobal(sizeof(byte) * 256);
    internal static NativeInconsistentFileDelegate nativeOnInconsistentFileCaller = (nint player, nint filename, nint disconnect_message) =>
    {
        string mfilename =  Marshal.PtrToStringUTF8(filename) ?? string.Empty;
        string mdisconnect = "";
        int res = pfnInconsistentFile?.Invoke(new Edict(player), mfilename, ref mdisconnect) ?? 0;
        byte[] disconnect = System.Text.Encoding.UTF8.GetBytes(mdisconnect);
        if (disconnect.Length > 255)
            Array.Resize(ref disconnect, 255);
        Marshal.Copy(disconnect, 0, s_disconnect_message, disconnect.Length);
        disconnect_message = s_disconnect_message;
        return res ;
    };

    internal static NativeAllowLagCompensationDelegate nativeOnAllowLagCompensationCaller = () =>
    {
        return pfnAllowLagCompensation?.Invoke() ?? 0;
    };

    internal static NativeDllFuncs GetNative()
    {
#pragma warning disable CS8601 // 引用类型赋值可能为 null。
        return new NativeDllFuncs()
        {
            pfnGameInit = pfnGameInit == null ? null : nativeGameInitCaller,
            pfnSpawn = pfnSpawn == null ? null : nativeOnSpawnCaller,
            pfnThink = pfnThink == null ? null : nativeOnThinkCaller,
            pfnUse = pfnUse == null ? null : nativeOnUseCaller,
            pfnTouch = pfnTouch == null ? null : nativeOnTouchCaller,
            pfnBlocked = pfnBlocked == null ? null : nativeOnBlockedCaller,
            pfnKeyValue = pfnKeyValue == null ? null : nativeOnKeyValueCaller,
            pfnSave = pfnSave == null ? null : nativeOnSaveCaller,
            pfnRestore = pfnRestore == null ? null : nativeOnRestoreCaller,
            pfnSetAbsBox = pfnSetAbsBox == null ? null : nativeOnSetAbsBoxCaller,
            pfnSaveWriteFields = pfnSaveWriteFields == null ? null : nativeOnSaveWriteFieldsCaller,
            pfnSaveReadFields = pfnSaveReadFields == null ? null : nativeOnSaveReadFieldsCaller,
            pfnSaveGlobalState = pfnSaveGlobalState == null ? null : nativeOnSaveGlobalStateCaller,
            pfnRestoreGlobalState = pfnRestoreGlobalState == null ? null : nativeOnRestoreGlobalStateCaller,
            pfnResetGlobalState = pfnResetGlobalState == null ? null : nativeOnResetGlobalStateCaller,
            pfnClientConnect = pfnClientConnect == null ? null : nativeOnClientConnectCaller,
            pfnClientDisconnect = pfnClientDisconnect == null ? null : nativeOnClientDisconnectCaller,
            pfnClientKill = pfnClientKill == null ? null : nativeOnClientKillCaller,
            pfnClientPutInServer = pfnClientPutInServer == null ? null : nativeOnClientPutInServerCaller,
            pfnClientCommand = pfnClientCommand == null ? null : nativeOnClientCommandCaller,
            pfnClientUserInfoChanged = pfnClientUserInfoChanged == null ? null : nativeOnClientUserInfoChangedCaller,
            pfnServerActivate = pfnServerActivate == null ? null : nativeOnServerActivateCaller,
            pfnServerDeactivate = pfnServerDeactivate == null ? null : nativeOnServerDeactivateCaller,
            pfnPlayerPreThink = pfnPlayerPreThink == null ? null : nativeOnPlayerPreThinkCaller,
            pfnPlayerPostThink = pfnPlayerPostThink == null ? null : nativeOnPlayerPostThinkCaller,
            pfnStartFrame = pfnStartFrame == null ? null : nativeOnStartFrameCaller,
            pfnParmsNewLevel = pfnParmsNewLevel == null ? null : nativeOnParmsNewLevelCaller,
            pfnParmsChangeLevel = pfnParmsChangeLevel == null ? null : nativeOnParmsChangeLevelCaller,
            pfnGetGameDescription = pfnGetGameDescription == null ? null : nativeOnGetGameDescriptionCaller,
            pfnPlayerCustomization = pfnPlayerCustomization == null ? null : nativeOnPlayerCustomizationCaller,
            pfnSpectatorConnect = pfnSpectatorConnect == null ? null : nativeOnSpectatorConnectCaller,
            pfnSpectatorDisconnect = pfnSpectatorDisconnect == null ? null : nativeOnSpectatorDisconnectCaller,
            pfnSpectatorThink = pfnSpectatorThink == null ? null : nativeOnSpectatorThinkCaller,
            pfnSysError = pfnSysError == null ? null : nativeOnSysErrorCaller,
            pfnPMMove = pfnPM_Move == null ? null : nativeOnPM_MoveCaller,
            pfnPMInit = pfnPM_Init == null ? null : nativeOnPM_InitCaller,
            pfnPMFindTextureType = pfnPM_FindTextureType == null ? null : nativeOnPM_FindTextureTypeCaller,
            pfnSetupVisibility = pfnSetupVisibility == null ? null : nativeOnSetupVisibilityCaller,
            pfnUpdateClientData = pfnUpdateClientData == null ? null : nativeOnUpdateClientDataCaller,
            pfnAddToFullPack = pfnAddToFullPack == null ? null : nativeOnAddToFullPackCaller,
            pfnCreateBaseline = pfnCreateBaseline == null ? null : nativeOnCreateBaselineCaller,
            pfnRegisterEncoders = pfnRegisterEncoders == null ? null : nativeOnRegisterEncodersCaller,
            pfnGetWeaponData = pfnGetWeaponData == null ? null : nativeOnGetWeaponDataCaller,
            pfnCmdStart = pfnCmdStart == null ? null : nativeOnCmdStartCaller,
            pfnCmdEnd = pfnCmdEnd == null ? null : nativeOnCmdEndCaller,
            pfnConnectionlessPacket = pfnConnectionlessPacket == null ? null : nativeOnConnectionlessPacketCaller,
            pfnGetHullBounds = pfnGetHullBounds == null ? null : nativeOnGetHullBoundsCaller,
            pfnCreateInstancedBaselines = pfnCreateInstancedBaselines == null ? null : nativeOnCreateInstancedBaselinesCaller,
            pfnInconsistentFile = pfnInconsistentFile == null ? null : nativeOnInconsistentFileCaller,
            pfnAllowLagCompensation = pfnAllowLagCompensation == null ? null : nativeOnAllowLagCompensationCaller
        };
#pragma warning restore CS8601 // 引用类型赋值可能为 null。
    }
}

public class DllFunctions_Post
{
    public static GameInitDelegate? pfnGameInit { get; set; }
    public static SpawnDelegate? pfnSpawn { get; set; }
    public static ThinkDelegate? pfnThink { get; set; }
    public static UseDelegate? pfnUse { get; set; }
    public static TouchDelegate? pfnTouch { get; set; }
    public static BlockedDelegate? pfnBlocked { get; set; }
    public static KeyValueDelegate? pfnKeyValue { get; set; }
    public static SaveDelegate? pfnSave { get; set; }
    public static RestoreDelegate? pfnRestore { get; set; }
    public static SetAbsBoxDelegate? pfnSetAbsBox { get; set; }
    public static SaveWriteFieldsDelegate? pfnSaveWriteFields { get; set; }
    public static SaveReadFieldsDelegate? pfnSaveReadFields { get; set; }
    public static SaveGlobalStateDelegate? pfnSaveGlobalState { get; set; }
    public static RestoreGlobalStateDelegate? pfnRestoreGlobalState { get; set; }
    public static ResetGlobalStateDelegate? pfnResetGlobalState { get; set; }
    public static ClientConnectDelegate? pfnClientConnect { get; set; }
    public static ClientDisconnectDelegate? pfnClientDisconnect { get; set; }
    public static ClientKillDelegate? pfnClientKill { get; set; }
    public static ClientPutInServerDelegate? pfnClientPutInServer { get; set; }
    public static DllClientCommandDelegate? pfnClientCommand { get; set; }
    public static ClientUserInfoChangedDelegate? pfnClientUserInfoChanged { get; set; }
    public static ServerActivateDelegate? pfnServerActivate { get; set; }
    public static ServerDeactivateDelegate? pfnServerDeactivate { get; set; }
    public static PlayerPreThinkDelegate? pfnPlayerPreThink { get; set; }
    public static PlayerPostThinkDelegate? pfnPlayerPostThink { get; set; }
    public static StartFrameDelegate? pfnStartFrame { get; set; }
    public static ParmsNewLevelDelegate? pfnParmsNewLevel { get; set; }
    public static ParmsChangeLevelDelegate? pfnParmsChangeLevel { get; set; }
    public static GetGameDescriptionDelegate? pfnGetGameDescription { get; set; }
    public static PlayerCustomizationDelegate? pfnPlayerCustomization { get; set; }
    public static SpectatorConnectDelegate? pfnSpectatorConnect { get; set; }
    public static SpectatorDisconnectDelegate? pfnSpectatorDisconnect { get; set; }
    public static SpectatorThinkDelegate? pfnSpectatorThink { get; set; }
    public static SysErrorDelegate? pfnSysError { get; set; }
    public static PMMoveDelegate? pfnPM_Move { get; set; }
    public static PMInitDelegate? pfnPM_Init { get; set; }
    public static PMFindTextureTypeDelegate? pfnPM_FindTextureType { get; set; }
    public static SetupVisibilityDelegate? pfnSetupVisibility { get; set; }
    public static UpdateClientDataDelegate? pfnUpdateClientData { get; set; }
    public static AddToFullPackDelegate? pfnAddToFullPack { get; set; }
    public static CreateBaselineDelegate? pfnCreateBaseline { get; set; }
    public static RegisterEncodersDelegate? pfnRegisterEncoders { get; set; }
    public static GetWeaponDataDelegate? pfnGetWeaponData { get; set; }
    public static CmdStartDelegate? pfnCmdStart { get; set; }
    public static CmdEndDelegate? pfnCmdEnd { get; set; }
    public static ConnectionlessPacketDelegate? pfnConnectionlessPacket { get; set; }
    public static GetHullBoundsDelegate? pfnGetHullBounds { get; set; }
    public static CreateInstancedBaselinesDelegate? pfnCreateInstancedBaselines { get; set; }
    public static InconsistentFileDelegate? pfnInconsistentFile { get; set; }
    public static AllowLagCompensationDelegate? pfnAllowLagCompensation { get; set; }

    internal static NativeGameInitDelegate nativeGameInitCaller = () =>
    {
        pfnGameInit?.Invoke();
    };

    internal static NativeSpawnDelegate nativeOnSpawnCaller = (nint pent) =>
    {
        return pfnSpawn?.Invoke(new Edict(pent)) ?? 0;
    };

    internal static NativeThinkDelegate nativeOnThinkCaller = (nint pent) =>
    {
        pfnThink?.Invoke(new Edict(pent));
    };

    internal static NativeUseDelegate nativeOnUseCaller = (nint pentUsed, nint pentOther) =>
    {
        pfnUse?.Invoke(new Edict(pentUsed), new Edict(pentOther));
    };

    internal static NativeTouchDelegate nativeOnTouchCaller = (nint pentTouched, nint pentOther) =>
    {
        pfnTouch?.Invoke(new Edict(pentTouched), new Edict(pentOther));
    };

    internal static NativeBlockedDelegate nativeOnBlockedCaller = (nint pentBlocked, nint pentOther) =>
    {
        pfnBlocked?.Invoke(new Edict(pentBlocked), new Edict(pentOther));
    };

    internal static NativeKeyValueDelegate nativeOnKeyValueCaller = (nint pentKeyvalue, nint pkvd) =>
    {
        pfnKeyValue?.Invoke(new Edict(pentKeyvalue), new KeyValueData(pkvd));
    };

    internal static NativeSaveDelegate nativeOnSaveCaller = (nint pent, nint pSaveData) =>
    {
        pfnSave?.Invoke(new Edict(pent), pSaveData);
    };

    internal static NativeRestoreDelegate nativeOnRestoreCaller = (nint pent, nint pSaveData, int globalEntity) =>
    {
        return pfnRestore?.Invoke(new Edict(pent), pSaveData, globalEntity) ?? 0;
    };

    internal static NativeSetAbsBoxDelegate nativeOnSetAbsBoxCaller = (nint pent) =>
    {
        pfnSetAbsBox?.Invoke(new Edict(pent));
    };

    internal static NativeSaveWriteFieldsDelegate nativeOnSaveWriteFieldsCaller = (nint a, nint b, nint c, nint d, int max) =>
    {
        pfnSaveWriteFields?.Invoke(a, b, c, d, max);
    };

    internal static NativeSaveReadFieldsDelegate nativeOnSaveReadFieldsCaller = (nint a, nint b, nint c, nint d, int max) =>
    {
        pfnSaveReadFields?.Invoke(a, b, c, d, max);
    };

    internal static NativeSaveGlobalStateDelegate nativeOnSaveGlobalStateCaller = (nint pSaveData) =>
    {
        pfnSaveGlobalState?.Invoke(pSaveData);
    };

    internal static NativeRestoreGlobalStateDelegate nativeOnRestoreGlobalStateCaller = (nint pSaveData) =>
    {
        pfnRestoreGlobalState?.Invoke(pSaveData);
    };

    internal static NativeResetGlobalStateDelegate nativeOnResetGlobalStateCaller = () =>
    {
        pfnResetGlobalState?.Invoke();
    };

    internal static NativeClientConnectDelegate nativeOnClientConnectCaller = (nint pEntity, nint pszName, nint pszAddress, nint szRejectReason) =>
    {
        string reject = Marshal.PtrToStringUTF8(szRejectReason) ?? string.Empty;
        bool result = pfnClientConnect?.Invoke(new Edict(pEntity),
            Marshal.PtrToStringUTF8(pszName) ?? string.Empty, Marshal.PtrToStringUTF8(pszAddress) ?? string.Empty, ref reject) ?? false;
        byte[] rejectBytes = System.Text.Encoding.UTF8.GetBytes(reject);
        if (rejectBytes.Length > 127)
            Array.Resize(ref rejectBytes, 127);
        unsafe
        {
            byte* ppReject = (byte*)szRejectReason;
            Marshal.Copy(rejectBytes, 0, (IntPtr)ppReject, rejectBytes.Length);
            ppReject[rejectBytes.Length] = 0;
        }
        return result ? QBoolean.TRUE : QBoolean.FALSE;
    };

    internal static NativeClientDisconnectDelegate nativeOnClientDisconnectCaller = (nint pEntity) =>
    {
        pfnClientDisconnect?.Invoke(new Edict(pEntity));
    };

    internal static NativeClientKillDelegate nativeOnClientKillCaller = (nint pEntity) =>
    {
        pfnClientKill?.Invoke(new Edict(pEntity));
    };

    internal static NativeClientPutInServerDelegate nativeOnClientPutInServerCaller = (nint pEntity) =>
    {
        pfnClientPutInServer?.Invoke(new Edict(pEntity));
    };

    internal static NativeClientCommandDelegate nativeOnClientCommandCaller = (nint pEntity) =>
    {
        pfnClientCommand?.Invoke(new Edict(pEntity));
    };

    internal static NativeClientUserInfoChangedDelegate nativeOnClientUserInfoChangedCaller = (nint pEntity, nint infobuffer) =>
    {
        string str = Marshal.PtrToStringUTF8(infobuffer) ?? string.Empty;
        pfnClientUserInfoChanged?.Invoke(new Edict(pEntity), ref str);

    };

    internal static NativeServerActivateDelegate nativeOnServerActivateCaller = (nint pEdictList, int edictCount, int clientMax) =>
    {
        pfnServerActivate?.Invoke(new Edict(pEdictList), edictCount, clientMax);
    };

    internal static NativeServerDeactivateDelegate nativeOnServerDeactivateCaller = () =>
    {
        pfnServerDeactivate?.Invoke();
    };

    internal static NativePlayerPreThinkDelegate nativeOnPlayerPreThinkCaller = (nint pEntity) =>
    {
        pfnPlayerPreThink?.Invoke(new Edict(pEntity));
    };

    internal static NativePlayerPostThinkDelegate nativeOnPlayerPostThinkCaller = (nint pEntity) =>
    {
        pfnPlayerPostThink?.Invoke(new Edict(pEntity));
    };

    internal static NativeStartFrameDelegate nativeOnStartFrameCaller = () =>
    {
        pfnStartFrame?.Invoke();
    };

    internal static NativeParmsNewLevelDelegate nativeOnParmsNewLevelCaller = () =>
    {
        pfnParmsNewLevel?.Invoke();
    };

    internal static NativeParmsChangeLevelDelegate nativeOnParmsChangeLevelCaller = () =>
    {
        pfnParmsChangeLevel?.Invoke();
    };

    private static nint s_szGameDscription = Marshal.AllocHGlobal(sizeof(byte) * 256);
    internal static NativeGetGameDescriptionDelegate nativeOnGetGameDescriptionCaller = () =>
    {
        string description = pfnGetGameDescription?.Invoke() ?? string.Empty;
        byte[] descBytes = System.Text.Encoding.UTF8.GetBytes(description);
        if (descBytes.Length > 255)
            Array.Resize(ref descBytes, 255);
        Marshal.Copy(descBytes, 0, s_szGameDscription, descBytes.Length);
        return s_szGameDscription;
    };

    internal static NativePlayerCustomizationDelegate nativeOnPlayerCustomizationCaller = (nint pEntity, nint pCustom) =>
    {
        pfnPlayerCustomization?.Invoke(new Edict(pEntity), new Customization(pCustom));
    };

    internal static NativeSpectatorConnectDelegate nativeOnSpectatorConnectCaller = (nint pEntity) =>
    {
        pfnSpectatorConnect?.Invoke(new Edict(pEntity));
    };

    internal static NativeSpectatorDisconnectDelegate nativeOnSpectatorDisconnectCaller = (nint pEntity) =>
    {
        pfnSpectatorDisconnect?.Invoke(new Edict(pEntity));
    };

    internal static NativeSpectatorThinkDelegate nativeOnSpectatorThinkCaller = (nint pEntity) =>
    {
        pfnSpectatorThink?.Invoke(new Edict(pEntity));
    };

    internal static NativeSysErrorDelegate nativeOnSysErrorCaller = (nint error_string) =>
    {
        string err = Marshal.PtrToStringUTF8(error_string) ?? string.Empty;
        pfnSysError?.Invoke(err);
    };

    internal static NativePMMoveDelegate nativeOnPM_MoveCaller = (nint pm, QBoolean server) =>
    {
        pfnPM_Move?.Invoke(new PlayerMove(pm), server == QBoolean.TRUE);
    };

    internal static NativePMInitDelegate nativeOnPM_InitCaller = (nint pm) =>
    {
        pfnPM_Init?.Invoke(new PlayerMove(pm));
    };

    internal static NativePMFindTextureTypeDelegate nativeOnPM_FindTextureTypeCaller = (nint name) =>
    {
        string n = Marshal.PtrToStringUTF8(name) ?? string.Empty;
        return pfnPM_FindTextureType?.Invoke(n) ?? 0;
    };

    private static nint ppvs = Marshal.AllocHGlobal(sizeof(byte) * 32);
    private static nint ppas = Marshal.AllocHGlobal(sizeof(byte) * 32);
    internal static NativeSetupVisibilityDelegate nativeOnSetupVisibilityCaller = (nint pViewEntity, nint pClient, nint pvs, nint pas) =>
    {
        byte[] mpvs = new byte[32];
        byte[] mpas = new byte[32];
        pfnSetupVisibility?.Invoke(new Edict(pViewEntity), new Edict(pClient), ref mpvs, ref mpas);
        Marshal.Copy(mpvs, 0, ppvs, mpvs.Length);
        Marshal.Copy(mpas, 0, ppas, mpas.Length);
        Marshal.WriteIntPtr(pvs, ppvs);
        Marshal.WriteIntPtr(pas, ppas);
    };

    internal static NativeUpdateClientDataDelegate nativeOnUpdateClientDataCaller = (nint ent, int sendweapons, nint cd) =>
    {
        pfnUpdateClientData?.Invoke(new Edict(ent), sendweapons, new ClientData(cd));
    };

    internal static NativeAddToFullPackDelegate nativeOnAddToFullPackCaller = (nint state, int e, nint ent, nint host, int hostflags, int player, nint pSet) =>
    {
        byte[] mbb = [Marshal.ReadByte(pSet)];
        return pfnAddToFullPack?.Invoke(new EntityState(state), e, new Edict(ent), new Edict(host), hostflags, player, mbb) ?? 0;
    };

    internal static NativeCreateBaselineDelegate nativeOnCreateBaselineCaller = (int player, int eindex, nint baseline, nint entity, int playermodelindex, nint player_mins, nint player_maxs) =>
    {
        pfnCreateBaseline?.Invoke(player, eindex, new EntityState(baseline), new Edict(entity), playermodelindex, new Vector3f(player_mins), new Vector3f(player_maxs));
    };

    internal static NativeRegisterEncodersDelegate nativeOnRegisterEncodersCaller = () =>
    {
        pfnRegisterEncoders?.Invoke();
    };

    internal static NativeGetWeaponDataDelegate nativeOnGetWeaponDataCaller = (nint player, nint info) =>
    {
        return pfnGetWeaponData?.Invoke(new Edict(player), new WeaponData(info)) ?? 0;
    };

    internal static NativeCmdStartDelegate nativeOnCmdStartCaller = (nint plyer, nint cmd, uint random_seed) =>
    {
        pfnCmdStart?.Invoke(new Edict(plyer), new UserCmd(cmd), random_seed);
    };

    internal static NativeCmdEndDelegate nativeOnCmdEndCaller = (nint plyer) =>
    {
        pfnCmdEnd?.Invoke(new Edict(plyer));
    };

    private static nint s_respondbuffer = Marshal.AllocHGlobal(sizeof(byte) * 256);
    internal static NativeConnectionlessPacketDelegate nativeOnConnectionlessPacketCaller = (nint net_from, nint args, nint response_buffer, nint response_buffer_size) =>
    {
        string aargs = Marshal.PtrToStringUTF8(args) ?? string.Empty;
        string mrespond = "";
        int respond_len = 0;
        int res = pfnConnectionlessPacket?.Invoke(new NetAdr(net_from), aargs, ref mrespond, ref respond_len) ?? 0;
        byte[] respond = System.Text.Encoding.UTF8.GetBytes(mrespond);
        if (respond.Length > 255)
            Array.Resize(ref respond, 255);
        Marshal.Copy(respond, 0, s_respondbuffer, respond.Length);
        response_buffer = s_respondbuffer;
        Marshal.WriteInt32(response_buffer_size, respond.Length);
        return res;
    };

    internal static NativeGetHullBoundsDelegate nativeOnGetHullBoundsCaller = (int hullnumber, nint mins, nint maxs) =>
    {
        var v1 = new Vector3f(mins);
        var v2 = new Vector3f(maxs);
        return pfnGetHullBounds?.Invoke(hullnumber, ref v1, ref v2) ?? 0;
    };

    internal static NativeCreateInstancedBaselinesDelegate nativeOnCreateInstancedBaselinesCaller = () =>
    {
        pfnCreateInstancedBaselines?.Invoke();
    };

    private static nint s_disconnect_message = Marshal.AllocHGlobal(sizeof(byte) * 256);
    internal static NativeInconsistentFileDelegate nativeOnInconsistentFileCaller = (nint player, nint filename, nint disconnect_message) =>
    {
        string mfilename = Marshal.PtrToStringUTF8(filename) ?? string.Empty;
        string mdisconnect = "";
        int res = pfnInconsistentFile?.Invoke(new Edict(player), mfilename, ref mdisconnect) ?? 0;
        byte[] disconnect = System.Text.Encoding.UTF8.GetBytes(mdisconnect);
        if (disconnect.Length > 255)
            Array.Resize(ref disconnect, 255);
        Marshal.Copy(disconnect, 0, s_disconnect_message, disconnect.Length);
        disconnect_message = s_disconnect_message;
        return res;
    };

    internal static NativeAllowLagCompensationDelegate nativeOnAllowLagCompensationCaller = () =>
    {
        return pfnAllowLagCompensation?.Invoke() ?? 0;
    };

    internal static NativeDllFuncs GetNative()
    {
#pragma warning disable CS8601 // 引用类型赋值可能为 null。
        return new NativeDllFuncs()
        {
            pfnGameInit = pfnGameInit == null ? null : nativeGameInitCaller,
            pfnSpawn = pfnSpawn == null ? null : nativeOnSpawnCaller,
            pfnThink = pfnThink == null ? null : nativeOnThinkCaller,
            pfnUse = pfnUse == null ? null : nativeOnUseCaller,
            pfnTouch = pfnTouch == null ? null : nativeOnTouchCaller,
            pfnBlocked = pfnBlocked == null ? null : nativeOnBlockedCaller,
            pfnKeyValue = pfnKeyValue == null ? null : nativeOnKeyValueCaller,
            pfnSave = pfnSave == null ? null : nativeOnSaveCaller,
            pfnRestore = pfnRestore == null ? null : nativeOnRestoreCaller,
            pfnSetAbsBox = pfnSetAbsBox == null ? null : nativeOnSetAbsBoxCaller,
            pfnSaveWriteFields = pfnSaveWriteFields == null ? null : nativeOnSaveWriteFieldsCaller,
            pfnSaveReadFields = pfnSaveReadFields == null ? null : nativeOnSaveReadFieldsCaller,
            pfnSaveGlobalState = pfnSaveGlobalState == null ? null : nativeOnSaveGlobalStateCaller,
            pfnRestoreGlobalState = pfnRestoreGlobalState == null ? null : nativeOnRestoreGlobalStateCaller,
            pfnResetGlobalState = pfnResetGlobalState == null ? null : nativeOnResetGlobalStateCaller,
            pfnClientConnect = pfnClientConnect == null ? null : nativeOnClientConnectCaller,
            pfnClientDisconnect = pfnClientDisconnect == null ? null : nativeOnClientDisconnectCaller,
            pfnClientKill = pfnClientKill == null ? null : nativeOnClientKillCaller,
            pfnClientPutInServer = pfnClientPutInServer == null ? null : nativeOnClientPutInServerCaller,
            pfnClientCommand = pfnClientCommand == null ? null : nativeOnClientCommandCaller,
            pfnClientUserInfoChanged = pfnClientUserInfoChanged == null ? null : nativeOnClientUserInfoChangedCaller,
            pfnServerActivate = pfnServerActivate == null ? null : nativeOnServerActivateCaller,
            pfnServerDeactivate = pfnServerDeactivate == null ? null : nativeOnServerDeactivateCaller,
            pfnPlayerPreThink = pfnPlayerPreThink == null ? null : nativeOnPlayerPreThinkCaller,
            pfnPlayerPostThink = pfnPlayerPostThink == null ? null : nativeOnPlayerPostThinkCaller,
            pfnStartFrame = pfnStartFrame == null ? null : nativeOnStartFrameCaller,
            pfnParmsNewLevel = pfnParmsNewLevel == null ? null : nativeOnParmsNewLevelCaller,
            pfnParmsChangeLevel = pfnParmsChangeLevel == null ? null : nativeOnParmsChangeLevelCaller,
            pfnGetGameDescription = pfnGetGameDescription == null ? null : nativeOnGetGameDescriptionCaller,
            pfnPlayerCustomization = pfnPlayerCustomization == null ? null : nativeOnPlayerCustomizationCaller,
            pfnSpectatorConnect = pfnSpectatorConnect == null ? null : nativeOnSpectatorConnectCaller,
            pfnSpectatorDisconnect = pfnSpectatorDisconnect == null ? null : nativeOnSpectatorDisconnectCaller,
            pfnSpectatorThink = pfnSpectatorThink == null ? null : nativeOnSpectatorThinkCaller,
            pfnSysError = pfnSysError == null ? null : nativeOnSysErrorCaller,
            pfnPMMove = pfnPM_Move == null ? null : nativeOnPM_MoveCaller,
            pfnPMInit = pfnPM_Init == null ? null : nativeOnPM_InitCaller,
            pfnPMFindTextureType = pfnPM_FindTextureType == null ? null : nativeOnPM_FindTextureTypeCaller,
            pfnSetupVisibility = pfnSetupVisibility == null ? null : nativeOnSetupVisibilityCaller,
            pfnUpdateClientData = pfnUpdateClientData == null ? null : nativeOnUpdateClientDataCaller,
            pfnAddToFullPack = pfnAddToFullPack == null ? null : nativeOnAddToFullPackCaller,
            pfnCreateBaseline = pfnCreateBaseline == null ? null : nativeOnCreateBaselineCaller,
            pfnRegisterEncoders = pfnRegisterEncoders == null ? null : nativeOnRegisterEncodersCaller,
            pfnGetWeaponData = pfnGetWeaponData == null ? null : nativeOnGetWeaponDataCaller,
            pfnCmdStart = pfnCmdStart == null ? null : nativeOnCmdStartCaller,
            pfnCmdEnd = pfnCmdEnd == null ? null : nativeOnCmdEndCaller,
            pfnConnectionlessPacket = pfnConnectionlessPacket == null ? null : nativeOnConnectionlessPacketCaller,
            pfnGetHullBounds = pfnGetHullBounds == null ? null : nativeOnGetHullBoundsCaller,
            pfnCreateInstancedBaselines = pfnCreateInstancedBaselines == null ? null : nativeOnCreateInstancedBaselinesCaller,
            pfnInconsistentFile = pfnInconsistentFile == null ? null : nativeOnInconsistentFileCaller,
            pfnAllowLagCompensation = pfnAllowLagCompensation == null ? null : nativeOnAllowLagCompensationCaller
        };
#pragma warning restore CS8601 // 引用类型赋值可能为 null。
    }
}