using Metamod.Enum.Common;
using Metamod.Native.Engine;
using Metamod.Struct.Common;
using System.Runtime.InteropServices;

namespace Metamod.Struct.Engine;

public class EngineFuncs(nint ptr) : BaseManaged<NativeEngineFuncs>(ptr)
{
    public void PrecacheModel(string s)
    {
        nint ns = Marshal.StringToHGlobalAnsi(s);
        _native.pfnPrecacheModel(ns);
        Marshal.FreeHGlobal(ns);
    }

    public void PrecacheSound(string s)
    {
        nint ns = Marshal.StringToHGlobalAnsi(s);
        _native.pfnPrecacheSound(ns);
        Marshal.FreeHGlobal(ns);
    }

    public void SetModel(Edict e, string m)
    {
        nint ns = Marshal.StringToHGlobalAnsi(m);
        _native.pfnSetModel(e.GetUnmanagedPtr(), ns);
        Marshal.FreeHGlobal(ns);
    }

    public int ModelIndex(string m)
    {
        nint ns = Marshal.StringToHGlobalAnsi(m);
        int ret = _native.pfnModelIndex(ns);
        Marshal.FreeHGlobal(ns);
        return ret;
    }

    public int ModelFrames(int modelIndex) => _native.pfnModelFrames(modelIndex);
    public void SetSize(Edict e, Vector3f min, Vector3f max) => _native.pfnSetSize(e.GetUnmanagedPtr(), min._native.ToNInt(), max._native.ToNInt());

    public void ChangeLevel(string s1, string s2)
    {
        nint ns1 = Marshal.StringToHGlobalAnsi(s1);
        nint ns2 = Marshal.StringToHGlobalAnsi(s2);
        _native.pfnChangeLevel(ns1, ns2);
        Marshal.FreeHGlobal(ns1);
        Marshal.FreeHGlobal(ns2);
    }

    public void GetSpawnParms(Edict ent) => _native.pfnGetSpawnParms(ent.GetUnmanagedPtr());
    public void SaveSpawnParms(Edict ent) => _native.pfnSaveSpawnParms(ent.GetUnmanagedPtr());
    public float VecToYaw(Vector3f vec) => _native.pfnVecToYaw(vec._native.ToNInt());
    public void VecToAngles(Vector3f vec, Vector3f angles) => _native.pfnVecToAngles((nint)vec._native.ToNInt(), angles._native.ToNInt());
    public void MoveToOrigin(Edict ent, Vector3f goal, float dist, int moveType) => _native.pfnMoveToOrigin(ent.GetUnmanagedPtr(), goal._native.ToNInt(), dist, moveType);
    public void ChangeYaw(Edict edict) => _native.pfnChangeYaw(edict.GetUnmanagedPtr());
    public void ChangePitch(Edict ent) => _native.pfnChangePitch(ent.GetUnmanagedPtr());
    public Edict FindEntityByString(Edict e, string field, string value)
    {
        nint ns1 = Marshal.StringToHGlobalAnsi(field);
        nint ns2 = Marshal.StringToHGlobalAnsi(value);
        Edict ret = new(_native.pfnFindEntityByString(e.GetUnmanagedPtr(), ns1, ns2));
        Marshal.FreeHGlobal(ns1);
        Marshal.FreeHGlobal(ns2);
        return ret;
    }
    public int GetEntityIllum(Edict ent) => _native.pfnGetEntityIllum(ent.GetUnmanagedPtr());
    public Edict FindEntityInSphere(Edict e, Vector3f origin, float radius) => new(_native.pfnFindEntityInSphere(e.GetUnmanagedPtr(), origin._native.ToNInt(), radius));
    public Edict FindClientInPVS(Edict e) => new(_native.pfnFindClientInPVS(e.GetUnmanagedPtr()));
    public Edict EntitiesInPVS(Edict e) => new(_native.pfnEntitiesInPVS(e.GetUnmanagedPtr()));
    public void MakeVectors(Vector3f vec) => _native.pfnMakeVectors(vec._native.ToNInt());
    public void AngleVectors(Vector3f vec, Vector3f forward, Vector3f right, Vector3f up) => _native.pfnAngleVectors(vec._native.ToNInt(), forward._native.ToNInt(), right._native.ToNInt(), up._native.ToNInt());
    public Edict CreateEntity() => new(_native.pfnCreateEntity());
    public void RemoveEntity(Edict e) => _native.pfnRemoveEntity(e.GetUnmanagedPtr());
    public Edict CreateNamedEntity(int className) => new(_native.pfnCreateNamedEntity(className));
    public void MakeStatic(Edict ent) => _native.pfnMakeStatic(ent.GetUnmanagedPtr());
    public int EntIsOnFloor(Edict ent) => _native.pfnEntIsOnFloor(ent.GetUnmanagedPtr());
    public int DropToFloor(Edict ent) => _native.pfnDropToFloor(ent.GetUnmanagedPtr());
    public int WalkMove(Edict ent, float yaw, float dist, int mode) => _native.pfnWalkMove(ent.GetUnmanagedPtr(), yaw, dist, mode);
    public void SetOrigin(Edict ent, Vector3f origin) => _native.pfnSetOrigin(ent.GetUnmanagedPtr(), origin._native.ToNInt());
    public void EmitSound(Edict ent, int channel, string sample, float volume, float attenuation, int fFlags, int pitch)
    {
        nint ns = Marshal.StringToHGlobalAnsi(sample);
        _native.pfnEmitSound(ent.GetUnmanagedPtr(), channel, ns, volume, attenuation, fFlags, pitch);
        Marshal.FreeHGlobal(ns);
    }
    public void EmitAmbientSound(Edict ent, Vector3f pos, string sample, float volume, float attenuation, int fFlags, int pitch)
    {
        nint ns = Marshal.StringToHGlobalAnsi(sample);
        _native.pfnEmitAmbientSound(ent.GetUnmanagedPtr(), pos._native.ToNInt(), ns, volume, attenuation, fFlags, pitch);
        Marshal.FreeHGlobal(ns);
    }
    public void TraceLine(Vector3f v1, Vector3f v2, int fNoMonsters, Edict pentToSkip, ref TraceResult ptr) =>
        _native.pfnTraceLine(v1._native.ToNInt(), v2._native.ToNInt(), fNoMonsters, pentToSkip.GetUnmanagedPtr(), ptr.GetUnmanagedPtr());
    public void TraceToss(Edict pent, Edict pentToIgnore, ref TraceResult ptr) =>
        _native.pfnTraceToss(pent.GetUnmanagedPtr(), pentToIgnore.GetUnmanagedPtr(), ptr.GetUnmanagedPtr());
    public int TraceMonsterHull(Edict pent, Vector3f v1, Vector3f v2, int fNoMonsters, Edict pentToSkip, ref TraceResult ptr) =>
        _native.pfnTraceMonsterHull(pent.GetUnmanagedPtr(), v1._native.ToNInt(), v2._native.ToNInt(), fNoMonsters, pentToSkip.GetUnmanagedPtr(), ptr.GetUnmanagedPtr());
    public void TraceHull(Vector3f v1, Vector3f v2, int fNoMonsters, int hullNumber, Edict pentToSkip, ref TraceResult ptr) =>
        _native.pfnTraceHull(v1._native.ToNInt(), v2._native.ToNInt(), fNoMonsters, hullNumber, pentToSkip.GetUnmanagedPtr(), ptr.GetUnmanagedPtr());
    public void TraceModel(Vector3f v1, Vector3f v2, int hullNumber, Edict pent, ref TraceResult ptr) =>
        _native.pfnTraceModel(v1._native.ToNInt(), v2._native.ToNInt(), hullNumber, pent.GetUnmanagedPtr(), ptr.GetUnmanagedPtr());
    public string TraceTexture(Edict pTextureEntity, Vector3f v1, Vector3f v2)
    {
        nint ptr = _native.pfnTraceTexture(pTextureEntity.GetUnmanagedPtr(), v1._native.ToNInt(), v2._native.ToNInt());
        return Marshal.PtrToStringUTF8(ptr) ?? string.Empty;
    }
    public void TraceSphere(Vector3f v1, Vector3f v2, int fNoMonsters, float radius, Edict pentToSkip, ref TraceResult ptr) =>
        _native.pfnTraceSphere(v1._native.ToNInt(), v2._native.ToNInt(), fNoMonsters, radius, pentToSkip.GetUnmanagedPtr(), ptr.GetUnmanagedPtr());
    public void GetAimVector(Edict ent, float speed, ref Vector3f vec) => _native.pfnGetAimVector(ent.GetUnmanagedPtr(), speed, vec._native.ToNInt());
    public void ServerCommand(string str)
    {
        nint ns = Marshal.StringToHGlobalAnsi(str);
        _native.pfnServerCommand(ns);
        Marshal.FreeHGlobal(ns);
    }
    public void ServerExecute() => _native.pfnServerExecute();
    public void ClientCommand(Edict ent, string str)
    {
        nint ns = Marshal.StringToHGlobalAnsi(str);
        _native.pfnClientCommand(ent.GetUnmanagedPtr(), ns);
        Marshal.FreeHGlobal(ns);
    }
    public void ParticleEffect(Vector3f org, Vector3f dir, float color, float count) => _native.pfnParticleEffect(org._native.ToNInt(), dir._native.ToNInt(), color, count);
    public void LightStyle(int style, string val)
    {
        nint ns = Marshal.StringToHGlobalAnsi(val);
        _native.pfnLightStyle(style, ns);
        Marshal.FreeHGlobal(ns);
    }
    public int DecalIndex(string name)
    {
        nint ns = Marshal.StringToHGlobalAnsi(name);
        int res = _native.pfnDecalIndex(ns);
        Marshal.FreeHGlobal(ns);
        return res;
    }
    public int PointContents(Vector3f vec) => _native.pfnPointContents(vec._native.ToNInt());
    public void MessageBegin(int msg_dest, int msg_type, Vector3f pOrigin, Edict ed) => _native.pfnMessageBegin(msg_dest, msg_type, pOrigin._native.ToNInt(), ed.GetUnmanagedPtr());
    public void MessageEnd() => _native.pfnMessageEnd();
    public void WriteByte(int iValue) => _native.pfnWriteByte(iValue);
    public void WriteChar(int iValue) => _native.pfnWriteChar(iValue);
    public void WriteShort(int iValue) => _native.pfnWriteShort(iValue);
    public void WriteLong(int iValue) => _native.pfnWriteLong(iValue);
    public void WriteAngle(float flValue) => _native.pfnWriteAngle(flValue);
    public void WriteCoord(float flValue) => _native.pfnWriteCoord(flValue);
    public void WriteString(string sz)
    {
        nint ns = Marshal.StringToHGlobalAnsi(sz);
        _native.pfnWriteString(ns);
        Marshal.FreeHGlobal(ns);
    }
    public void WriteEntity(int iValue) => _native.pfnWriteEntity(iValue);
    public void CVarRegister(CVar cvar) => _native.pfnCVarRegister(cvar.GetUnmanagedPtr());
    public float CVarGetFloat(string szVarName)
    {
        nint ns = Marshal.StringToHGlobalAnsi(szVarName);
        float res = _native.pfnCVarGetFloat(ns);
        Marshal.FreeHGlobal(ns);
        return res;
    }
    public string CVarGetString(string szVarName)
    {
        nint ns = Marshal.StringToHGlobalAnsi(szVarName);
        nint res = _native.pfnCVarGetString(ns);
        Marshal.FreeHGlobal(ns);
        return Marshal.PtrToStringUTF8(res) ?? string.Empty;
    }
    public void CVarSetFloat(string szVarName, float flValue)
    {
        nint ns = Marshal.StringToHGlobalAnsi(szVarName);
        _native.pfnCVarSetFloat(ns, flValue);
        Marshal.FreeHGlobal(ns);
    }
    public void CVarSetString(string szVarName, string szValue)
    {
        nint ns1 = Marshal.StringToHGlobalAnsi(szVarName);
        nint ns2 = Marshal.StringToHGlobalAnsi(szValue);
        _native.pfnCVarSetString(ns1, ns2);
        Marshal.FreeHGlobal(ns1);
        Marshal.FreeHGlobal(ns2);
    }
    public void AlertMessage(AlertType atype, string szFmt)
    {
        nint ns = Marshal.StringToHGlobalAnsi(szFmt);
        _native.pfnAlertMessage((int)atype, ns);
        Marshal.FreeHGlobal(ns);
    }
    public void EngineFprintf(nint pFile, string szFmt, params string[] p)
    {
        nint ns = Marshal.StringToHGlobalAnsi(string.Format(szFmt, p));
        _native.pfnEngineFprintf(pFile, ns);
        Marshal.FreeHGlobal(ns);
    }
    public nint PvAllocEntPrivateData(Edict ed, int size) => _native.pfnPvAllocEntPrivateData(ed.GetUnmanagedPtr(), size);
    public nint PvEntPrivateData(Edict ed) => _native.pfnPvEntPrivateData(ed.GetUnmanagedPtr());
    public void FreeEntPrivateData(Edict ed) => _native.pfnFreeEntPrivateData(ed.GetUnmanagedPtr());
    public string SzFromIndex(int iString)
    {
        nint ns = _native.pfnSzFromIndex(iString);
        return Marshal.PtrToStringUTF8(ns) ?? string.Empty;
    }
    public int AllocString(string szValue)
    {
        nint ns = Marshal.StringToHGlobalAnsi(szValue);
        return _native.pfnAllocString(ns);
    }
    public Entvars GetVarsOfEnt(Edict pEdict)
    {
        nint ptr = _native.pfnGetVarsOfEnt(pEdict.GetUnmanagedPtr());
        return new(ptr);
    }
    public Edict PEntityOfEntOffset(int iEntOffset) => new(_native.pfnPEntityOfEntOffset(iEntOffset));
    public int EntOffsetOfPEntity(Edict pEdict) => _native.pfnEntOffsetOfPEntity(pEdict.GetUnmanagedPtr());
    public int IndexOfEdict(Edict pEdict) => _native.pfnIndexOfEdict(pEdict.GetUnmanagedPtr());
    public Edict PEntityOfEntIndex(int iEntIndex) => new(_native.pfnPEntityOfEntIndex(iEntIndex));
    public Edict FindEntityByVars(Entvars pvars) => new(_native.pfnFindEntityByVars(pvars.GetUnmanagedPtr()));
    public nint GetModelPtr(Edict pEdict) => _native.pfnGetModelPtr(pEdict.GetUnmanagedPtr());
    public int RegUserMsg(string pszName, int iSize)
    {
        nint ns = Marshal.StringToHGlobalAnsi(pszName);
        int res = _native.pfnRegUserMsg(ns, iSize);
        Marshal.FreeHGlobal(ns);
        return res;
    }
    public void AnimationAutomove(Edict ent, float flTime) => _native.pfnAnimationAutomove(ent.GetUnmanagedPtr(), flTime);
    public void GetBonePosition(Edict ent, int iBone, ref Vector3f origin, ref Vector3f angles) => _native.pfnGetBonePosition(ent.GetUnmanagedPtr(), iBone, origin._native.ToNInt(), angles._native.ToNInt());
    public uint FunctionFromName(string pName)
    {
        nint ns = Marshal.StringToHGlobalAnsi(pName);
        uint res = _native.pfnFunctionFromName(ns);
        Marshal.FreeHGlobal(ns);
        return res;
    }
    public string NameForFunction(uint function) => Marshal.PtrToStringUTF8(_native.pfnNameForFunction(function)) ?? string.Empty;
    public void ClientPrintf(Edict ent, PrintType ptype, string szMsg)
    {
        nint ns = Marshal.StringToHGlobalAnsi(szMsg);
        _native.pfnClientPrintf(ent.GetUnmanagedPtr(), (int)ptype, ns);
        Marshal.FreeHGlobal(ns);
    }
    public void ServerPrint(string msg)
    {
        nint nmsg = Marshal.StringToHGlobalAnsi(msg);
        _native.pfnServerPrint(nmsg);
        Marshal.FreeHGlobal(nmsg);
    }
    public string Cmd_Args() => Marshal.PtrToStringUTF8(_native.pfnCmd_Args()) ?? string.Empty;
    public string Cmd_Argv(int argc) => Marshal.PtrToStringUTF8(_native.pfnCmd_Argv(argc)) ?? string.Empty;
    public int Cmd_Argc() => _native.pfnCmd_Argc();
    public void GetAttachment(Edict ent, int iAttachment, ref Vector3f origin, ref Vector3f angles) =>
        _native.pfnGetAttachment(ent.GetUnmanagedPtr(), iAttachment, origin._native.ToNInt(), angles._native.ToNInt());
    public void CRC32_Init(CRC32 pulCRC) => _native.pfnCRC32_Init(pulCRC.GetUnmanagedPtr());
    public void CRC32_ProcessBuffer(CRC32 pulCRC, nint buffer, int len) =>
        _native.pfnCRC32_ProcessBuffer(pulCRC.GetUnmanagedPtr(), buffer, len);
    public void CRC32_ProcessByte(CRC32 pulCRC, byte ch) =>
        _native.pfnCRC32_ProcessByte(pulCRC.GetUnmanagedPtr(), ch);
    public CRC32 CRC32_Final(CRC32 pulCRC) => new(_native.pfnCRC32_Final(pulCRC._native));
    public int RandomLong(int lLow, int lHigh) => _native.pfnRandomLong(lLow, lHigh);
    public float RandomFloat(float flLow, float flHigh) => _native.pfnRandomFloat(flLow, flHigh);
    public void SetView(Edict ent, Edict viewent) => _native.pfnSetView(ent.GetUnmanagedPtr(), viewent.GetUnmanagedPtr());
    public float Time() => _native.pfnTime();
    public void CrosshairAngle(Edict ent, float pitch, float yaw) => _native.pfnCrosshairAngle(ent.GetUnmanagedPtr(), pitch, yaw);
    public nint LoadFileForMe(string filename, out int pLength)
    {
        nint ns = Marshal.StringToHGlobalAnsi(filename);
        nint nl = Marshal.AllocHGlobal(sizeof(int));
        nint res = _native.pfnLoadFileForMe(ns, nl);
        Marshal.FreeHGlobal(ns);
        pLength = Marshal.ReadInt32(nl);
        Marshal.FreeHGlobal(nl);
        return res;
    }
    public void FreeFile(nint buffer) => _native.pfnFreeFile(buffer);
    public void EndSection(string szSectionName)
    {
        nint ns = Marshal.StringToHGlobalAnsi(szSectionName);
        _native.pfnEndSection(ns);
        Marshal.FreeHGlobal(ns);
    }
    public int CompareFileTime(string filename1, string filename2, out int iCompare)
    {
        nint ns1 = Marshal.StringToHGlobalAnsi(filename1);
        nint ns2 = Marshal.StringToHGlobalAnsi(filename2);
        nint ni = Marshal.AllocHGlobal(sizeof(int));
        int res = _native.pfnCompareFileTime(ns1, ns2, ni);
        Marshal.FreeHGlobal(ns1);
        Marshal.FreeHGlobal(ns2);
        iCompare = Marshal.ReadInt32(ni);
        Marshal.FreeHGlobal(ni);
        return res;
    }
    public string GetGameDir()
    {
        nint ns = Marshal.AllocHGlobal(sizeof(byte) * 256);
        _native.pfnGetGameDir(ns);
        string res = Marshal.PtrToStringUTF8(ns) ?? string.Empty;
        Marshal.FreeHGlobal(ns);
        return res;
    }
    public void CVar_RegisterVariable(CVar cvar) => _native.pfnCvar_RegisterVariable(cvar.GetUnmanagedPtr());
    public void FadeClientVolume(Edict ent, int fadePercent, int fadeOutSeconds, int holdTime, int fadeInSeconds) =>
        _native.pfnFadeClientVolume(ent.GetUnmanagedPtr(), fadePercent, fadeOutSeconds, holdTime, fadeInSeconds);
    public void SetClientMaxspeed(Edict ent, float fNewMaxspeed) => _native.pfnSetClientMaxspeed(ent.GetUnmanagedPtr(), fNewMaxspeed);
    public Edict CreateFakeClient(string netname)
    {
        nint ns = Marshal.StringToHGlobalAnsi(netname);
        Edict ret = new(_native.pfnCreateFakeClient(ns));
        Marshal.FreeHGlobal(ns);
        return ret;
    }
    public void RunPlayerMove(Edict fakeClient, Vector3f viewangles, float forwardmove, float sidemove, float upmove, ushort buttons, byte impulse, byte msec) =>
        _native.pfnRunPlayerMove(fakeClient.GetUnmanagedPtr(), viewangles._native.ToNInt(), forwardmove, sidemove, upmove, buttons, impulse, msec);
    public int NumberOfEntities() => _native.pfnNumberOfEntities();
    public string GetInfoKeyBuffer(Edict ent) => Marshal.PtrToStringUTF8(_native.pfnGetInfoKeyBuffer(ent.GetUnmanagedPtr())) ?? string.Empty;
    public string InfoKeyValue(string infobuffer, string key)
    {
        nint ns1 = Marshal.StringToHGlobalAnsi(infobuffer);
        nint ns2 = Marshal.StringToHGlobalAnsi(key);
        nint res = _native.pfnInfoKeyValue(ns1, ns2);
        Marshal.FreeHGlobal(ns1);
        Marshal.FreeHGlobal(ns2);
        return Marshal.PtrToStringUTF8(res) ?? string.Empty;
    }
    public void SetKeyValue(ref string infobuffer, string key, string value)
    {
        nint ns1 = Marshal.StringToHGlobalAnsi(infobuffer);
        nint ns2 = Marshal.StringToHGlobalAnsi(key);
        nint ns3 = Marshal.StringToHGlobalAnsi(value);
        _native.pfnSetKeyValue(ns1, ns2, ns3);
        infobuffer = Marshal.PtrToStringUTF8(ns1) ?? string.Empty;
        Marshal.FreeHGlobal(ns1);
        Marshal.FreeHGlobal(ns2);
        Marshal.FreeHGlobal(ns3);
    }
    public void SetClientKeyValue(int clientIndex, string infobuffer, string key, string value)
    {
        nint ns1 = Marshal.StringToHGlobalAnsi(infobuffer);
        nint ns2 = Marshal.StringToHGlobalAnsi(key);
        nint ns3 = Marshal.StringToHGlobalAnsi(value);
        _native.pfnSetClientKeyValue(clientIndex, ns1, ns2, ns3);
        Marshal.FreeHGlobal(ns1);
        Marshal.FreeHGlobal(ns2);
        Marshal.FreeHGlobal(ns3);
    }
    public bool IsMapValid(string filename)
    {
        nint ns = Marshal.StringToHGlobalAnsi(filename);
        int res = _native.pfnIsMapValid(ns);
        Marshal.FreeHGlobal(ns);
        return res != 0;
    }
    public void StaticDecal(Vector3f origin, int decalIndex, int entityIndex, int modelIndex) =>
        _native.pfnStaticDecal(origin._native.ToNInt(), decalIndex, entityIndex, modelIndex);
    public void PrecacheGeneric(string s)
    {
        nint ns = Marshal.StringToHGlobalAnsi(s);
        _native.pfnPrecacheGeneric(ns);
        Marshal.FreeHGlobal(ns);
    }
    public int GetPlayerUserId(Edict e) => _native.pfnGetPlayerUserId(e.GetUnmanagedPtr());
    public void BuildSoundMsg(Edict entity, int channel, string sample, float volume, float attenuation, int fFlags, int pitch, int msg_dest, int msg_type, Vector3f pOrigin, Edict ed)
    {
        nint ns = Marshal.StringToHGlobalAnsi(sample);
        _native.pfnBuildSoundMsg(entity.GetUnmanagedPtr(), channel, ns, volume, attenuation, fFlags, pitch, msg_dest, msg_type, pOrigin._native.ToNInt(), ed.GetUnmanagedPtr());
        Marshal.FreeHGlobal(ns);
    }
    public bool IsDedicatedServer() => _native.pfnIsDedicatedServer() != 0;
    public CVar CVarGetPointer(string szVarName)
    {
        nint ns = Marshal.StringToHGlobalAnsi(szVarName);
        nint res = _native.pfnCVarGetPointer(ns);
        Marshal.FreeHGlobal(ns);
        return new(res);
    }
    public uint GetPlayerWONId(Edict e) => _native.pfnGetPlayerWONId(e.GetUnmanagedPtr());
    public void Info_RemoveKey(ref string s, string key)
    {
        nint ns1 = Marshal.StringToHGlobalAnsi(s);
        nint ns2 = Marshal.StringToHGlobalAnsi(key);
        _native.pfnInfo_RemoveKey(ns1, ns2);
        s = Marshal.PtrToStringUTF8(ns1) ?? string.Empty;
        Marshal.FreeHGlobal(ns1);
        Marshal.FreeHGlobal(ns2);
    }
    public string GetPhysicsKeyValue(Edict ent, string key)
    {
        nint ns1 = Marshal.StringToHGlobalAnsi(key);
        nint res = _native.pfnGetPhysicsKeyValue(ent.GetUnmanagedPtr(), ns1);
        Marshal.FreeHGlobal(ns1);
        return Marshal.PtrToStringUTF8(res) ?? string.Empty;
    }
    public void SetPhysicsKeyValue(Edict ent, string key, string value)
    {
        nint ns1 = Marshal.StringToHGlobalAnsi(key);
        nint ns2 = Marshal.StringToHGlobalAnsi(value);
        _native.pfnSetPhysicsKeyValue(ent.GetUnmanagedPtr(), ns1, ns2);
        Marshal.FreeHGlobal(ns1);
        Marshal.FreeHGlobal(ns2);
    }
    public string GetPhysicsInfoString(Edict ent)
    {
        nint res = _native.pfnGetPhysicsInfoString(ent.GetUnmanagedPtr());
        return Marshal.PtrToStringUTF8(res) ?? string.Empty;
    }
    public ushort PrecacheEvent(int type, string psz)
    {
        nint ns = Marshal.StringToHGlobalAnsi(psz);
        ushort res = _native.pfnPrecacheEvent(type, ns);
        Marshal.FreeHGlobal(ns);
        return res;
    }
    public void PlaybackEvent(int flags, Edict ed, ushort eventindex, float delay, Vector3f origin, Vector3f angles, float fparam1, float fparam2, int iparam1, int iparam2, int bparam1, int bparam2)
        => _native.pfnPlaybackEvent(flags, ed.GetUnmanagedPtr(), eventindex, delay, origin._native.ToNInt(), angles._native.ToNInt(), fparam1, fparam2, iparam1, iparam2, bparam1, bparam2);

    public string SetFatPVS(Vector3f org)
    {
        nint ns = _native.pfnSetFatPVS(org._native.ToNInt());
        return Marshal.PtrToStringUTF8(ns) ?? string.Empty;
    }
    public string SetFatPAS(Vector3f org)
    {
        nint ns = _native.pfnSetFatPAS(org._native.ToNInt());
        return Marshal.PtrToStringUTF8(ns) ?? string.Empty;
    }
    public bool CheckVisibility(Edict entity, nint pset)
    {
        int res = _native.pfnCheckVisibility(entity.GetUnmanagedPtr(), pset);
        return res != 0;
    }
    public void DeltaSetField(nint pFields, string fieldName)
    {
        nint ns = Marshal.StringToHGlobalAnsi(fieldName);
        _native.pfnDeltaSetField(pFields, ns);
        Marshal.FreeHGlobal(ns);
    }
    public void DeltaUnsetField(nint pFields, string fieldName)
    {
        nint ns = Marshal.StringToHGlobalAnsi(fieldName);
        _native.pfnDeltaUnsetField(pFields, ns);
        Marshal.FreeHGlobal(ns);
    }
    public void DeltaAddEncoder(string name, nint callback)
    {
        nint ns = Marshal.StringToHGlobalAnsi(name);
        _native.pfnDeltaAddEncoder(ns, callback);
        Marshal.FreeHGlobal(ns);
    }
    public int GetCurrentPlayer() => _native.pfnGetCurrentPlayer();
    public int CanSkipPlayer(Edict player) => _native.pfnCanSkipPlayer(player.GetUnmanagedPtr());
    public int DeltaFindField(nint pFields, string fieldName)
    {
        nint ns = Marshal.StringToHGlobalAnsi(fieldName);
        int res = _native.pfnDeltaFindField(pFields, ns);
        Marshal.FreeHGlobal(ns);
        return res;
    }
    public void DeltaSetFieldByIndex(nint pFields, int fieldNumber)
        => _native.pfnDeltaSetFieldByIndex(pFields, fieldNumber);
    public void DeltaUnsetFieldByIndex(nint pFields, int fieldNumber)
        => _native.pfnDeltaUnsetFieldByIndex(pFields, fieldNumber);
    public void SetGroupMask(int mask, int op) => _native.pfnSetGroupMask(mask, op);
    public int CreateInstancedBaseline(int classname, EntityState baseline)
        => _native.pfnCreateInstancedBaseline(classname, baseline.GetUnmanagedPtr());
    public void Cvar_DirectSet(CVar cvar, string value)
    {
        nint ns = Marshal.StringToHGlobalAnsi(value);
        _native.pfnCvar_DirectSet(cvar.GetUnmanagedPtr(), ns);
        Marshal.FreeHGlobal(ns);
    }
    public void ForceUnmodified(ForceType type, Vector3f mins, Vector3f maxs, string filename)
    {
        nint ns = Marshal.StringToHGlobalAnsi(filename);
        _native.pfnForceUnmodified((int)type, mins._native.ToNInt(), maxs._native.ToNInt(), ns);
        Marshal.FreeHGlobal(ns);
    }
    public void GetPlayerStats(Edict ent, out int ping, out int packet_loss)
    {
        nint ni1 = Marshal.AllocHGlobal(sizeof(int));
        nint ni2 = Marshal.AllocHGlobal(sizeof(int));
        _native.pfnGetPlayerStats(ent.GetUnmanagedPtr(), ni1, ni2);
        ping = Marshal.ReadInt32(ni1);
        packet_loss = Marshal.ReadInt32(ni2);
        Marshal.FreeHGlobal(ni2);
        Marshal.FreeHGlobal(ni1);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void ServerCommandDelegate();
    public void AddServerCommand(string cmd_name, ServerCommandDelegate function)
    {
        nint func = Marshal.GetFunctionPointerForDelegate(function);
        nint cmd = Marshal.StringToHGlobalAnsi(cmd_name);
        unsafe
        {
            _native.pfnAddServerCommand(cmd, func);
        }
        Marshal.FreeHGlobal(cmd);
    }

    public bool Voice_GetClientListening(int iReceiver, int iSender) => _native.pfnVoice_GetClientListening(iReceiver, iSender) != 0;
    public bool Voice_SetClientListening(int iReceiver, int iSender, bool bListen) => _native.pfnVoice_SetClientListening(iReceiver, iSender, bListen ? 1 : 0) != 0;
    public string GetPlayerAuthId(Edict e)
    {
        nint res = _native.pfnGetPlayerAuthId(e.GetUnmanagedPtr());
        return Marshal.PtrToStringUTF8(res) ?? string.Empty;
    }
    public nint SequenceGet(string fieldName, string entryName)
    {
        nint ns1 = Marshal.StringToHGlobalAnsi(fieldName);
        nint ns2 = Marshal.StringToHGlobalAnsi(entryName);
        nint res = _native.pfnSequenceGet(ns1, ns2);
        Marshal.FreeHGlobal(ns1);
        Marshal.FreeHGlobal(ns2);
        return res;
    }
    public nint SequencePickSentence(string groupName, int pickMethod, out int picked)
    {
        nint ns = Marshal.StringToHGlobalAnsi(groupName);
        nint ni = Marshal.AllocHGlobal(sizeof(int));
        nint res = _native.pfnSequencePickSentence(ns, pickMethod, ni);
        picked = Marshal.ReadInt32(ni);
        Marshal.FreeHGlobal(ns);
        Marshal.FreeHGlobal(ni);
        return res;
    }
    public int GetFileSize(string filename)
    {
        nint ns = Marshal.StringToHGlobalAnsi(filename);
        int res = _native.pfnGetFileSize(ns);
        Marshal.FreeHGlobal(ns);
        return res;
    }
    public uint GetApproxWavePlayLen(string filepath)
    {
        nint ns = Marshal.StringToHGlobalAnsi(filepath);
        uint res = _native.pfnGetApproxWavePlayLen(ns);
        Marshal.FreeHGlobal(ns);
        return res;
    }
    public int IsCareerMatch() => _native.pfnIsCareerMatch();
    public int GetLocalizedStringLength(string label)
    {
        nint ns = Marshal.StringToHGlobalAnsi(label);
        int res = _native.pfnGetLocalizedStringLength(ns);
        Marshal.FreeHGlobal(ns);
        return res;
    }
    public void RegisterTutorMessageShown(int mid) => _native.pfnRegisterTutorMessageShown(mid);
    public int GetTimesTutorMessageShown(int mid) => _native.pfnGetTimesTutorMessageShown(mid);
    public void ProcessTutorMessageDecayBuffer(nint buffer, int bufferLength)
        => _native.pfnProcessTutorMessageDecayBuffer(buffer, bufferLength);
    public void ConstructTutorMessageDecayBuffer(nint buffer, int bufferLength)
        => _native.pfnConstructTutorMessageDecayBuffer(buffer, bufferLength);
    public void ResetTutorMessageDecayData() => _native.pfnResetTutorMessageDecayData();

    public void QueryClientCvarValue(Edict player, string cvarName)
    {
        nint ns = Marshal.StringToHGlobalAnsi(cvarName);
        _native.pfnQueryClientCvarValue(player.GetUnmanagedPtr(), ns);
        Marshal.FreeHGlobal(ns);
    }

    public void QueryClientCvarValue2(Edict player, string cvarName, int requestID)
    {
        nint ns = Marshal.StringToHGlobalAnsi(cvarName);
        _native.pfnQueryClientCvarValue2(player.GetUnmanagedPtr(), ns, requestID);
        Marshal.FreeHGlobal(ns);
    }

    public void EngCheckParm(string pchCmdLineToken, out string ppszValue)
    {
        unsafe
        {
            nint ns = Marshal.StringToHGlobalAnsi(pchCmdLineToken);
            nint os = Marshal.AllocHGlobal(sizeof(nint));
            _native.pfnEngCheckParm(ns, out os);
            Marshal.FreeHGlobal(ns);
            ppszValue = Marshal.PtrToStringUTF8(os) ?? string.Empty;
            Marshal.FreeHGlobal(os);
        }
    }
}
