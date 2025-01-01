using Metamod.Enum.Metamod;
using Metamod.Native.Game;
using Metamod.Struct.Common;
using Metamod.Struct.Engine;
using Metamod.Struct.Engine.PM;
using System.Runtime.InteropServices;

namespace Metamod.Struct.Game;

public class DllFuncs : BaseManaged<NativeDllFuncs>
{
    internal DllFuncs(nint ptr) : base(ptr) { }
    // Initialize/shutdown the game (one-time call after loading of game .dll )
    public void GameInit() => _native.pfnGameInit();
    public int Spawn(Edict pent) => _native.pfnSpawn(pent.GetUnmanagedPtr());
    public void Think(Edict pent) => _native.pfnThink(pent.GetUnmanagedPtr());
    public void Use(Edict pentUsed, Edict pentOther) => _native.pfnUse(pentUsed.GetUnmanagedPtr(), pentOther.GetUnmanagedPtr());
    public void Touch(Edict pentTouched, Edict pentOther) => _native.pfnTouch(pentTouched.GetUnmanagedPtr(), pentOther.GetUnmanagedPtr());
    public void Blocked(Edict pentBlocked, Edict pentOther) => _native.pfnBlocked(pentBlocked.GetUnmanagedPtr(), pentOther.GetUnmanagedPtr());
    public void KeyValue(Edict pentKeyvalue, KeyValueData pkvd) => _native.pfnKeyValue(pentKeyvalue.GetUnmanagedPtr(), pkvd.GetUnmanagedPtr());

    public void Save(Edict pent, nint pSaveData) => _native.pfnSave(pent.GetUnmanagedPtr(), pSaveData);
    public int Restore(Edict pent, nint pSaveData, int globalEntity) => _native.pfnRestore(pent.GetUnmanagedPtr(), pSaveData, globalEntity);
    public void SetAbsBox(Edict pent) => _native.pfnSetAbsBox(pent.GetUnmanagedPtr());
    public void SveWriteFields(nint a, nint b, nint c, nint d, int max) => _native.pfnSaveWriteFields(a, b, c, d, max);
    public void SaveReadFields(nint a, nint b, nint c, nint d, int max) => _native.pfnSaveReadFields(a, b, c, d, max);
    public void SaveGlobalState(nint pSaveData) => _native.pfnSaveGlobalState(pSaveData);
    public void RestoreGlobalState(nint pSaveData) => _native.pfnRestoreGlobalState(pSaveData);
    public void ResetGlobalState() => _native.pfnResetGlobalState();
    public bool ClientConnect(Edict pEntity, string pszName, string pszAddress, ref string szRejectReason)
    {
        nint ns1 = Marshal.StringToHGlobalAnsi(pszName);
        nint ns2 = Marshal.StringToHGlobalAnsi(pszAddress);
        nint ns3 = Marshal.AllocHGlobal(128 * sizeof(byte));
        for (int i = 0; i < Math.Min(szRejectReason.Length, 128); i++)
        {
            Marshal.WriteByte(ns3, i, (byte)szRejectReason[i]);
        }
        bool res = _native.pfnClientConnect(pEntity.GetUnmanagedPtr(), ns1, ns2, ns3) == QBoolean.TRUE;
        szRejectReason = Marshal.PtrToStringUTF8(ns3) ?? string.Empty;
        Marshal.FreeHGlobal(ns3);
        Marshal.FreeHGlobal(ns2);
        Marshal.FreeHGlobal(ns1);
        return res;
    }
    public void ClientDisconnect(Edict pEntity) => _native.pfnClientDisconnect(pEntity.GetUnmanagedPtr());
    public void ClientKill(Edict pEntity) => _native.pfnClientKill(pEntity.GetUnmanagedPtr());
    public void ClientPutInServer(Edict pEntity) => _native.pfnClientPutInServer(pEntity.GetUnmanagedPtr());
    public void ClientCommand(Edict pEntity) => _native.pfnClientCommand(pEntity.GetUnmanagedPtr());
    public void ClientUserInfoChanged(Edict pEntity, ref string infobuffer)
    {
        nint ns = Marshal.StringToHGlobalAnsi(infobuffer);
        _native.pfnClientUserInfoChanged(pEntity.GetUnmanagedPtr(), ns);
        infobuffer = Marshal.PtrToStringUTF8(ns) ?? string.Empty;
        Marshal.FreeHGlobal(ns);
    }

    public void ServerActivate(Edict pEdictList, int edictCount, int clientMax) => _native.pfnServerActivate(pEdictList.GetUnmanagedPtr(), edictCount, clientMax);
    public void ServerDeactivate() => _native.pfnServerDeactivate();

    public void PlayerPreThink(Edict pEntity) => _native.pfnPlayerPreThink(pEntity.GetUnmanagedPtr());
    public void PlayerPostThink(Edict pEntity) => _native.pfnPlayerPostThink(pEntity.GetUnmanagedPtr());

    public void StartFrame() => _native.pfnStartFrame();
    public void ParmsNewLevel() => _native.pfnParmsNewLevel();
    public void ParmsChangeLevel() => _native.pfnParmsChangeLevel();

    // Returns string describing current .dll.  E.g., TeamFotrress 2, Half-Life
    public string GetGameDescription()
    {
        nint ptr = _native.pfnGetGameDescription();
        return Marshal.PtrToStringUTF8(ptr) ?? string.Empty;
    }

    // Notify dll about a player customization.
    public void PlayerCustomization(Edict pEntity, Customization pCustom) => _native.pfnPlayerCustomization(pEntity.GetUnmanagedPtr(), pCustom.GetUnmanagedPtr());

    // Spectator funcs
    public void SpectatorConnect(Edict pEntity) => _native.pfnSpectatorConnect(pEntity.GetUnmanagedPtr());
    public void SpectatorDisconnect(Edict pEntity) => _native.pfnSpectatorDisconnect(pEntity.GetUnmanagedPtr());
    public void SpectatorThink(Edict pEntity) => _native.pfnSpectatorThink(pEntity.GetUnmanagedPtr());

    // Notify game .dll that engine is going to shut down.  Allows mod authors to set a breakpoint.
    public void SysError(string error_string)
    {
        nint ns = Marshal.StringToHGlobalAnsi(error_string);
        _native.pfnSysError(ns);
        Marshal.FreeHGlobal(ns);
    }

    public void PMMove(PlayerMove pm, bool server) => _native.pfnPMMove(pm.GetUnmanagedPtr(), server ? QBoolean.TRUE : QBoolean.FALSE);
    public void PMInit(PlayerMove pm) => _native.pfnPMInit(pm.GetUnmanagedPtr());

    public int PMFindTextureType(string name)
    {
        nint ns = Marshal.StringToHGlobalAnsi(name);
        int res = _native.pfnPMFindTextureType(ns);
        Marshal.FreeHGlobal(ns);
        return res;
    }

    public void SetupVisibility(Edict pViewEntity, Edict pClient, ref byte[] pvs, ref byte[] pas)
    {
        unsafe
        {
            fixed (byte* ppvs = pvs)
            {
                fixed (byte* ppas = pas)
                {
                    _native.pfnSetupVisibility(pViewEntity.GetUnmanagedPtr(), pClient.GetUnmanagedPtr(), (nint)(&ppvs), (nint)(&ppas));
                }
            }
        }
    }

    public void UpdateClientData(Edict ent, int sendweapons, ClientData cd) => _native.pfnUpdateClientData(ent.GetUnmanagedPtr(), sendweapons, cd.GetUnmanagedPtr());
    public int AddToFullPack(EntityState state, int e, Edict ent, Edict host, int hostflags, int player, byte[] pSet)
    {
        int res = 0;
        unsafe
        {
            fixed (byte* ppSet = pSet)
            {
                res = _native.pfnAddToFullPack(state.GetUnmanagedPtr(), e, ent.GetUnmanagedPtr(), host.GetUnmanagedPtr(), hostflags, player, (nint)(ppSet));
            }
        }
        return res;
    }

    public void CreateBaseline(int player, int eindex, EntityState baseline, Edict entity, int playermodelindex, Vector3f player_mins, Vector3f player_maxs) => _native.pfnCreateBaseline(player, eindex, baseline.GetUnmanagedPtr(), entity.GetUnmanagedPtr(), playermodelindex, player_mins._native.ToNInt(), player_maxs._native.ToNInt());
    public void RegisterEncoders() => _native.pfnRegisterEncoders();
    public int GetWeaponData(Edict player, WeaponData info) => _native.pfnGetWeaponData(player.GetUnmanagedPtr(), info.GetUnmanagedPtr());
    public void CmdStart(Edict plyer, UserCmd cmd, uint random_seed) => _native.pfnCmdStart(plyer.GetUnmanagedPtr(), cmd.GetUnmanagedPtr(), random_seed);
    public void CmdEnd(Edict plyer) => _native.pfnCmdEnd(plyer.GetUnmanagedPtr());

    // Return 1 if the packet is valid.  Set response_buffer_size if you want to send a response packet.  Incoming, it holds the max
    //  size of the response_buffer, so you must zero it out if you choose not to respond.
    public int ConnectionlessPacket(NetAdr net_from, string args, ref string response_buffer, ref int response_buffer_size)
    {
        nint ns1 = Marshal.StringToHGlobalAnsi(args);
        nint ns2 = Marshal.AllocHGlobal(response_buffer_size);
        nint ni = Marshal.AllocHGlobal(sizeof(int));
        int res = _native.pfnConnectionlessPacket(net_from.GetUnmanagedPtr(), ns1, ns2, ni);
        response_buffer = Marshal.PtrToStringUTF8(ns2) ?? string.Empty;
        response_buffer_size = Marshal.ReadInt32(ni);
        Marshal.FreeHGlobal(ni);
        Marshal.FreeHGlobal(ns2);
        Marshal.FreeHGlobal(ns1);
        return res;
    }

    // Enumerates player hulls.  Returns 0 if the hull number doesn't exist, 1 otherwise
    public int GetHullBounds(int hullnumber, ref Vector3f mins, ref Vector3f maxs) => _fromNative ? _native.pfnGetHullBounds(hullnumber, mins._native.ToNInt(), maxs._native.ToNInt()) : 0;

    // Create baselines for certain "unplaced" items.
    public void CreateInstancedBaselines() => _native.pfnCreateInstancedBaselines();

    // One of the pfnForceUnmodified files failed the consistency check for the specified player
    // Return 0 to allow the client to continue, 1 to force immediate disconnection ( with an optional disconnect message of up to 256 characters )
    public int InconsistentFile(Edict player, string filename, ref string disconnect_message)
    {
        nint ns1 = Marshal.StringToHGlobalAnsi(filename);
        nint ns2 = Marshal.AllocHGlobal(256 * sizeof(byte));
        for (int i = 0; i < Math.Min(disconnect_message.Length, 256); i++)
        {
            Marshal.WriteByte(ns2, i, (byte)disconnect_message[i]);
        }
        int res = _native.pfnInconsistentFile(player.GetUnmanagedPtr(), ns1, ns2);
        disconnect_message = Marshal.PtrToStringUTF8(ns2) ?? string.Empty;
        Marshal.FreeHGlobal(ns2);
        Marshal.FreeHGlobal(ns1);
        return res;
    }

    // The game .dll should return 1 if lag compensation should be allowed ( could also just set
    //  the sv_unlag cvar.
    // Most games right now should return 0, until client-side weapon prediction code is written
    //  and tested for them.
    int AllowLagCompensation() => _native.pfnAllowLagCompensation();
}
