using Metamod.Enum.Common;
using Metamod.Struct.Common;
using Metamod.Struct.Engine;

namespace Metamod.Interface;

public delegate void PrecacheModelDelegate(string s);
public delegate void PrecacheSoundDelegate(string s);
public delegate void SetModelDelegate(Edict e, string m);
public delegate int ModelIndexDelegate(string m);
public delegate int ModelFramesDelegate(int modelIndex);
public delegate void SetSizeDelegate(Edict e, Vector3f min, Vector3f max);
public delegate void ChangeLevelDelegate(string s1, string s2);
public delegate void GetSpawnParmsDelegate(Edict ent);
public delegate void SaveSpawnParmsDelegate(Edict ent);
public delegate float VecToYawDelegate(Vector3f vec);
public delegate void VecToAnglesDelegate(Vector3f vec, Vector3f angles);
public delegate void MoveToOriginDelegate(Edict ent, Vector3f goal, float dist, int moveType);
public delegate void ChangeYawDelegate(Edict edict);
public delegate void ChangePitchDelegate(Edict ent);
public delegate Edict FindEntityByStringDelegate(Edict e, string field, string value);
public delegate int GetEntityIllumDelegate(Edict ent);
public delegate Edict FindEntityInSphereDelegate(Edict e, Vector3f origin, float radius);
public delegate Edict FindClientInPVSDelegate(Edict e);
public delegate Edict EntitiesInPVSDelegate(Edict e);
public delegate void MakeVectorsDelegate(Vector3f vec);
public delegate void AngleVectorsDelegate(Vector3f vec, Vector3f forward, Vector3f right, Vector3f up);
public delegate Edict CreateEntityDelegate();
public delegate void RemoveEntityDelegate(Edict e);
public delegate Edict CreateNamedEntityDelegate(int className);
public delegate void MakeStaticDelegate(Edict ent);
public delegate int EntIsOnFloorDelegate(Edict ent);
public delegate int DropToFloorDelegate(Edict ent);
public delegate int WalkMoveDelegate(Edict ent, float yaw, float dist, int mode);
public delegate void SetOriginDelegate(Edict ent, Vector3f origin);
public delegate void EmitSoundDelegate(Edict ent, int channel, string sample, float volume, float attenuation, int fFlags, int pitch);
public delegate void EmitAmbientSoundDelegate(Edict ent, Vector3f pos, string sample, float volume, float attenuation, int fFlags, int pitch);
public delegate void TraceLineDelegate(Vector3f v1, Vector3f v2, int fNoMonsters, Edict pentToSkip, ref TraceResult ptr);
public delegate void TraceTossDelegate(Edict pent, Edict pentToIgnore, ref TraceResult ptr);
public delegate int TraceMonsterHullDelegate(Edict pent, Vector3f v1, Vector3f v2, int fNoMonsters, Edict pentToSkip, ref TraceResult ptr);
public delegate void TraceHullDelegate(Vector3f v1, Vector3f v2, int fNoMonsters, int hullNumber, Edict pentToSkip, ref TraceResult ptr);
public delegate void TraceModelDelegate(Vector3f v1, Vector3f v2, int hullNumber, Edict pent, ref TraceResult ptr);
public delegate string TraceTextureDelegate(Edict pTextureEntity, Vector3f v1, Vector3f v2);
public delegate void TraceSphereDelegate(Vector3f v1, Vector3f v2, int fNoMonsters, float radius, Edict pentToSkip, ref TraceResult ptr);
public delegate void GetAimVectorDelegate(Edict ent, float speed, ref Vector3f vec);
public delegate void ServerCommandDelegate(string str);
public delegate void ServerExecuteDelegate();
public delegate void EngineClientCommandDelegate(Edict ent, string str);
public delegate void ParticleEffectDelegate(Vector3f org, Vector3f dir, float color, float count);
public delegate void LightStyleDelegate(int style, string val);
public delegate int DecalIndexDelegate(string name);
public delegate int PointContentsDelegate(Vector3f vec);
public delegate void MessageBeginDelegate(int msg_dest, int msg_type, Vector3f pOrigin, Edict ed);
public delegate void MessageEndDelegate();
public delegate void WriteByteDelegate(int iValue);
public delegate void WriteCharDelegate(int iValue);
public delegate void WriteShortDelegate(int iValue);
public delegate void WriteLongDelegate(int iValue);
public delegate void WriteAngleDelegate(float flValue);
public delegate void WriteCoordDelegate(float flValue);
public delegate void WriteStringDelegate(string sz);
public delegate void WriteEntityDelegate(int iValue);
public delegate void CVarRegisterDelegate(CVar cvar);
public delegate float CVarGetFloatDelegate(string szVarName);
public delegate string CVarGetStringDelegate(string szVarName);
public delegate void CVarSetFloatDelegate(string szVarName, float flValue);
public delegate void CVarSetStringDelegate(string szVarName, string szValue);
public delegate void AlertMessageDelegate(AlertType atype, string szFmt);
public delegate void EngineFprintfDelegate(nint pFile, string szFmt, params string[] p);
public delegate nint PvAllocEntPrivateDataDelegate(Edict ed, int size);
public delegate nint PvEntPrivateDataDelegate(Edict ed);
public delegate void FreeEntPrivateDataDelegate(Edict ed);
public delegate string SzFromIndexDelegate(int iString);
public delegate int AllocStringDelegate(string szValue);
public delegate Entvars GetVarsOfEntDelegate(Edict pEdict);
public delegate Edict PEntityOfEntOffsetDelegate(int iEntOffset);
public delegate int EntOffsetOfPEntityDelegate(Edict pEdict);
public delegate int IndexOfEdictDelegate(Edict pEdict);
public delegate Edict PEntityOfEntIndexDelegate(int iEntIndex);
public delegate Edict FindEntityByVarsDelegate(Entvars pvars);
public delegate nint GetModelPtrDelegate(Edict pEdict);
public delegate int RegUserMsgDelegate(string pszName, int iSize);
public delegate void AnimationAutomoveDelegate(Edict ent, float flTime);
public delegate void GetBonePositionDelegate(Edict ent, int iBone, ref Vector3f origin, ref Vector3f angles);
public delegate uint FunctionFromNameDelegate(string pName);
public delegate string NameForFunctionDelegate(uint function);
public delegate void ClientPrintfDelegate(Edict ent, PrintType ptype, string szMsg);
public delegate void ServerPrintDelegate(string msg);
public delegate string Cmd_ArgsDelegate();
public delegate string Cmd_ArgvDelegate(int argc);
public delegate int Cmd_ArgcDelegate();
public delegate void GetAttachmentDelegate(Edict ent, int iAttachment, ref Vector3f origin, ref Vector3f angles);
public delegate void CRC32_InitDelegate(CRC32 pulCRC);
public delegate void CRC32_ProcessBufferDelegate(CRC32 pulCRC, nint buffer, int len);
public delegate void CRC32_ProcessByteDelegate(CRC32 pulCRC, byte ch);
public delegate CRC32 CRC32_FinalDelegate(CRC32 pulCRC);
public delegate int RandomLongDelegate(int lLow, int lHigh);
public delegate float RandomFloatDelegate(float flLow, float flHigh);
public delegate void SetViewDelegate(Edict ent, Edict viewent);
public delegate float TimeDelegate();
public delegate void CrosshairAngleDelegate(Edict ent, float pitch, float yaw);
public delegate nint LoadFileForMeDelegate(string filename, out int pLength);
public delegate void FreeFileDelegate(nint buffer);
public delegate void EndSectionDelegate(string szSectionName);
public delegate int CompareFileTimeDelegate(string filename1, string filename2, out int iCompare);
public delegate string GetGameDirDelegate();
public delegate void CVar_RegisterVariableDelegate(CVar cvar);
public delegate void FadeClientVolumeDelegate(Edict ent, int fadePercent, int fadeOutSeconds, int holdTime, int fadeInSeconds);
public delegate void SetClientMaxspeedDelegate(Edict ent, float fNewMaxspeed);
public delegate Edict CreateFakeClientDelegate(string netname);
public delegate void RunPlayerMoveDelegate(Edict fakeClient, Vector3f viewangles, float forwardmove, float sidemove, float upmove, ushort buttons, byte impulse, byte msec);
public delegate int NumberOfEntitiesDelegate();
public delegate string GetInfoKeyBufferDelegate(Edict ent);
public delegate string InfoKeyValueDelegate(string infobuffer, string key);
public delegate void SetKeyValueDelegate(ref string infobuffer, string key, string value);
public delegate void SetClientKeyValueDelegate(int clientIndex, string infobuffer, string key, string value);
public delegate bool IsMapValidDelegate(string filename);
public delegate void StaticDecalDelegate(Vector3f origin, int decalIndex, int entityIndex, int modelIndex);
public delegate void PrecacheGenericDelegate(string s);
public delegate int GetPlayerUserIdDelegate(Edict e);
public delegate void BuildSoundMsgDelegate(Edict entity, int channel, string sample, float volume, float attenuation, int fFlags, int pitch, int msg_dest, int msg_type, Vector3f pOrigin, Edict ed);
public delegate bool IsDedicatedServerDelegate();
public delegate CVar CVarGetPointerDelegate(string szVarName);
public delegate uint GetPlayerWONIdDelegate(Edict e);
public delegate void Info_RemoveKeyDelegate(ref string s, string key);
public delegate string GetPhysicsKeyValueDelegate(Edict ent, string key);
public delegate void SetPhysicsKeyValueDelegate(Edict ent, string key, string value);
public delegate string GetPhysicsInfoStringDelegate(Edict ent);
public delegate ushort PrecacheEventDelegate(int type, string psz);
public delegate void PlaybackEventDelegate(int flags, Edict ed, ushort eventindex, float delay, Vector3f origin, Vector3f angles, float fparam1, float fparam2, int iparam1, int iparam2, int bparam1, int bparam2);
public delegate string SetFatPVSDelegate(Vector3f org);
public delegate string SetFatPASDelegate(Vector3f org);
public delegate bool CheckVisibilityDelegate(Edict entity, nint pset);
public delegate void DeltaSetFieldDelegate(nint pFields, string fieldName);
public delegate void DeltaUnsetFieldDelegate(nint pFields, string fieldName);
public delegate void DeltaAddEncoderDelegate(string name, nint callback);
public delegate int GetCurrentPlayerDelegate();
public delegate int CanSkipPlayerDelegate(Edict player);
public delegate int DeltaFindFieldDelegate(nint pFields, string fieldName);
public delegate void DeltaSetFieldByIndexDelegate(nint pFields, int fieldNumber);
public delegate void DeltaUnsetFieldByIndexDelegate(nint pFields, int fieldNumber);
public delegate void SetGroupMaskDelegate(int mask, int op);
public delegate int CreateInstancedBaselineDelegate(int classname, EntityState baseline);
public delegate void Cvar_DirectSetDelegate(CVar cvar, string value);
public delegate void ForceUnmodifiedDelegate(ForceType type, Vector3f mins, Vector3f maxs, string filename);
public delegate void GetPlayerStatsDelegate(Edict ent, out int ping, out int packet_loss);
public delegate void AddServerCommandDelegate(string cmd_name, ServerCommandDelegate function);
public delegate bool Voice_GetClientListeningDelegate(int iReceiver, int iSender);
public delegate bool Voice_SetClientListeningDelegate(int iReceiver, int iSender, bool bListen);
public delegate string GetPlayerAuthIdDelegate(Edict e);
public delegate nint SequenceGetDelegate(string fieldName, string entryName);
public delegate nint SequencePickSentenceDelegate(string groupName, int pickMethod, out int picked);
public delegate int GetFileSizeDelegate(string filename);
public delegate uint GetApproxWavePlayLenDelegate(string filepath);
public delegate int IsCareerMatchDelegate();
public delegate int GetLocalizedStringLengthDelegate(string label);
public delegate void RegisterTutorMessageShownDelegate(int mid);
public delegate int GetTimesTutorMessageShownDelegate(int mid);
public delegate void ProcessTutorMessageDecayBufferDelegate(nint buffer, int bufferLength);
public delegate void ConstructTutorMessageDecayBufferDelegate(nint buffer, int bufferLength);
public delegate void ResetTutorMessageDecayDataDelegate();
public delegate void QueryClientCvarValueDelegate(Edict player, string cvarName);
public delegate void QueryClientCvarValue2Delegate(Edict player, string cvarName, int requestID);
public delegate void EngCheckParmDelegate(string pchCmdLineToken, out string ppszValue);


public interface IEngineFunctions
{
    public PrecacheModelDelegate pfnPrecacheModel { get; set; }
    public PrecacheSoundDelegate pfnPrecacheSound { get; set; }
    public SetModelDelegate pfnSetModel { get; set; }
    public ModelIndexDelegate pfnModelIndex { get; set; }
    public ModelFramesDelegate pfnModelFrames { get; set; }
    public SetSizeDelegate pfnSetSize { get; set; }
    public ChangeLevelDelegate pfnChangeLevel { get; set; }
    public GetSpawnParmsDelegate pfnGetSpawnParms { get; set; }
    public SaveSpawnParmsDelegate pfnSaveSpawnParms { get; set; }
    public VecToYawDelegate pfnVecToYaw { get; set; }
    public VecToAnglesDelegate pfnVecToAngles { get; set; }
    public MoveToOriginDelegate pfnMoveToOrigin { get; set; }
    public ChangeYawDelegate pfnChangeYaw { get; set; }
    public ChangePitchDelegate pfnChangePitch { get; set; }
    public FindEntityByStringDelegate pfnFindEntityByString { get; set; }
    public GetEntityIllumDelegate pfnGetEntityIllum { get; set; }
    public FindEntityInSphereDelegate pfnFindEntityInSphere { get; set; }
    public FindClientInPVSDelegate pfnFindClientInPVS { get; set; }
    public EntitiesInPVSDelegate pfnEntitiesInPVS { get; set; }
    public MakeVectorsDelegate pfnMakeVectors { get; set; }
    public AngleVectorsDelegate pfnAngleVectors { get; set; }
    public CreateEntityDelegate pfnCreateEntity { get; set; }
    public RemoveEntityDelegate pfnRemoveEntity { get; set; }
    public CreateNamedEntityDelegate pfnCreateNamedEntity { get; set; }
    public MakeStaticDelegate pfnMakeStatic { get; set; }
    public EntIsOnFloorDelegate pfnEntIsOnFloor { get; set; }
    public DropToFloorDelegate pfnDropToFloor { get; set; }
    public WalkMoveDelegate pfnWalkMove { get; set; }
    public SetOriginDelegate pfnSetOrigin { get; set; }
    public EmitSoundDelegate pfnEmitSound { get; set; }
    public EmitAmbientSoundDelegate pfnEmitAmbientSound { get; set; }
    public TraceLineDelegate pfnTraceLine { get; set; }
    public TraceTossDelegate pfnTraceToss { get; set; }
    public TraceMonsterHullDelegate pfnTraceMonsterHull { get; set; }
    public TraceHullDelegate pfnTraceHull { get; set; }
    public TraceModelDelegate pfnTraceModel { get; set; }
    public TraceTextureDelegate pfnTraceTexture { get; set; }
    public TraceSphereDelegate pfnTraceSphere { get; set; }
    public GetAimVectorDelegate pfnGetAimVector { get; set; }
    public ServerCommandDelegate pfnServerCommand { get; set; }
    public ServerExecuteDelegate pfnServerExecute { get; set; }
    public EngineClientCommandDelegate pfnClientCommand { get; set; }
    public ParticleEffectDelegate pfnParticleEffect { get; set; }
    public LightStyleDelegate pfnLightStyle { get; set; }
    public DecalIndexDelegate pfnDecalIndex { get; set; }
    public PointContentsDelegate pfnPointContents { get; set; }
    public MessageBeginDelegate pfnMessageBegin { get; set; }
    public MessageEndDelegate pfnMessageEnd { get; set; }
    public WriteByteDelegate pfnWriteByte { get; set; }
    public WriteCharDelegate pfnWriteChar { get; set; }
    public WriteShortDelegate pfnWriteShort { get; set; }
    public WriteLongDelegate pfnWriteLong { get; set; }
    public WriteAngleDelegate pfnWriteAngle { get; set; }
    public WriteCoordDelegate pfnWriteCoord { get; set; }
    public WriteStringDelegate pfnWriteString { get; set; }
    public WriteEntityDelegate pfnWriteEntity { get; set; }
    public CVarRegisterDelegate pfnCVarRegister { get; set; }
    public CVarGetFloatDelegate pfnCVarGetFloat { get; set; }
    public CVarGetStringDelegate pfnCVarGetString { get; set; }
    public CVarSetFloatDelegate pfnCVarSetFloat { get; set; }
    public CVarSetStringDelegate pfnCVarSetString { get; set; }
    public AlertMessageDelegate pfnAlertMessage { get; set; }
    public EngineFprintfDelegate pfnEngineFprintf { get; set; }
    public PvAllocEntPrivateDataDelegate pfnPvAllocEntPrivateData { get; set; }
    public PvEntPrivateDataDelegate pfnPvEntPrivateData { get; set; }
    public FreeEntPrivateDataDelegate pfnFreeEntPrivateData { get; set; }
    public SzFromIndexDelegate pfnSzFromIndex { get; set; }
    public AllocStringDelegate pfnAllocString { get; set; }
    public GetVarsOfEntDelegate pfnGetVarsOfEnt { get; set; }
    public PEntityOfEntOffsetDelegate pfnPEntityOfEntOffset { get; set; }
    public EntOffsetOfPEntityDelegate pfnEntOffsetOfPEntity { get; set; }
    public IndexOfEdictDelegate pfnIndexOfEdict { get; set; }
    public PEntityOfEntIndexDelegate pfnPEntityOfEntIndex { get; set; }
    public FindEntityByVarsDelegate pfnFindEntityByVars { get; set; }
    public GetModelPtrDelegate pfnGetModelPtr { get; set; }
    public RegUserMsgDelegate pfnRegUserMsg { get; set; }
    public AnimationAutomoveDelegate pfnAnimationAutomove { get; set; }
    public GetBonePositionDelegate pfnGetBonePosition { get; set; }
    public FunctionFromNameDelegate pfnFunctionFromName { get; set; }
    public NameForFunctionDelegate pfnNameForFunction { get; set; }
    public ClientPrintfDelegate pfnClientPrintf { get; set; }
    public ServerPrintDelegate pfnServerPrint { get; set; }
    public Cmd_ArgsDelegate pfnCmd_Args { get; set; }
    public Cmd_ArgvDelegate pfnCmd_Argv { get; set; }
    public Cmd_ArgcDelegate pfnCmd_Argc { get; set; }
    public GetAttachmentDelegate pfnGetAttachment { get; set; }
    public CRC32_InitDelegate pfnCRC32_Init { get; set; }
    public CRC32_ProcessBufferDelegate pfnCRC32_ProcessBuffer { get; set; }
    public CRC32_ProcessByteDelegate pfnCRC32_ProcessByte { get; set; }
    public CRC32_FinalDelegate pfnCRC32_Final { get; set; }
    public RandomLongDelegate pfnRandomLong { get; set; }
    public RandomFloatDelegate pfnRandomFloat { get; set; }
    public SetViewDelegate pfnSetView { get; set; }
    public TimeDelegate pfnTime { get; set; }
    public CrosshairAngleDelegate pfnCrosshairAngle { get; set; }
    public LoadFileForMeDelegate pfnLoadFileForMe { get; set; }
    public FreeFileDelegate pfnFreeFile { get; set; }
    public EndSectionDelegate pfnEndSection { get; set; }
    public CompareFileTimeDelegate pfnCompareFileTime { get; set; }
    public GetGameDirDelegate pfnGetGameDir { get; set; }
    public CVar_RegisterVariableDelegate pfnCvar_RegisterVariable { get; set; }
    public FadeClientVolumeDelegate pfnFadeClientVolume { get; set; }
    public SetClientMaxspeedDelegate pfnSetClientMaxspeed { get; set; }
    public CreateFakeClientDelegate pfnCreateFakeClient { get; set; }
    public RunPlayerMoveDelegate pfnRunPlayerMove { get; set; }
    public NumberOfEntitiesDelegate pfnNumberOfEntities { get; set; }
    public GetInfoKeyBufferDelegate pfnGetInfoKeyBuffer { get; set; }
    public InfoKeyValueDelegate pfnInfoKeyValue { get; set; }
    public SetKeyValueDelegate pfnSetKeyValue { get; set; }
    public SetClientKeyValueDelegate pfnSetClientKeyValue { get; set; }
    public IsMapValidDelegate pfnIsMapValid { get; set; }
    public StaticDecalDelegate pfnStaticDecal { get; set; }
    public PrecacheGenericDelegate pfnPrecacheGeneric { get; set; }
    public GetPlayerUserIdDelegate pfnGetPlayerUserId { get; set; }
    public BuildSoundMsgDelegate pfnBuildSoundMsg { get; set; }
    public IsDedicatedServerDelegate pfnIsDedicatedServer { get; set; }
    public CVarGetPointerDelegate pfnCVarGetPointer { get; set; }
    public GetPlayerWONIdDelegate pfnGetPlayerWONId { get; set; }
    public Info_RemoveKeyDelegate pfnInfo_RemoveKey { get; set; }
    public GetPhysicsKeyValueDelegate pfnGetPhysicsKeyValue { get; set; }
    public SetPhysicsKeyValueDelegate pfnSetPhysicsKeyValue { get; set; }
    public GetPhysicsInfoStringDelegate pfnGetPhysicsInfoString { get; set; }
    public PrecacheEventDelegate pfnPrecacheEvent { get; set; }
    public PlaybackEventDelegate pfnPlaybackEvent { get; set; }
    public SetFatPVSDelegate pfnSetFatPVS { get; set; }
    public SetFatPASDelegate pfnSetFatPAS { get; set; }
    public CheckVisibilityDelegate pfnCheckVisibility { get; set; }
    public DeltaSetFieldDelegate pfnDeltaSetField { get; set; }
    public DeltaUnsetFieldDelegate pfnDeltaUnsetField { get; set; }
    public DeltaAddEncoderDelegate pfnDeltaAddEncoder { get; set; }
    public GetCurrentPlayerDelegate pfnGetCurrentPlayer { get; set; }
    public CanSkipPlayerDelegate pfnCanSkipPlayer { get; set; }
    public DeltaFindFieldDelegate pfnDeltaFindField { get; set; }
    public DeltaSetFieldByIndexDelegate pfnDeltaSetFieldByIndex { get; set; }
    public DeltaUnsetFieldByIndexDelegate pfnDeltaUnsetFieldByIndex { get; set; }
    public SetGroupMaskDelegate pfnSetGroupMask { get; set; }
    public CreateInstancedBaselineDelegate pfnCreateInstancedBaseline { get; set; }
    public Cvar_DirectSetDelegate pfnCvar_DirectSet { get; set; }
    public ForceUnmodifiedDelegate pfnForceUnmodified { get; set; }
    public GetPlayerStatsDelegate pfnGetPlayerStats { get; set; }
    public AddServerCommandDelegate pfnAddServerCommand { get; set; }
    public Voice_GetClientListeningDelegate pfnVoice_GetClientListening { get; set; }
    public Voice_SetClientListeningDelegate pfnVoice_SetClientListening { get; set; }
    public GetPlayerAuthIdDelegate pfnGetPlayerAuthId { get; set; }
    public SequenceGetDelegate pfnSequenceGet { get; set; }
    public SequencePickSentenceDelegate pfnSequencePickSentence { get; set; }
    public GetFileSizeDelegate pfnGetFileSize { get; set; }
    public GetApproxWavePlayLenDelegate pfnGetApproxWavePlayLen { get; set; }
    public IsCareerMatchDelegate pfnIsCareerMatch { get; set; }
    public GetLocalizedStringLengthDelegate pfnGetLocalizedStringLength { get; set; }
    public RegisterTutorMessageShownDelegate pfnRegisterTutorMessageShown { get; set; }
    public GetTimesTutorMessageShownDelegate pfnGetTimesTutorMessageShown { get; set; }
    public ProcessTutorMessageDecayBufferDelegate pfnProcessTutorMessageDecayBuffer { get; set; }
    public ConstructTutorMessageDecayBufferDelegate pfnConstructTutorMessageDecayBuffer { get; set; }
    public ResetTutorMessageDecayDataDelegate pfnResetTutorMessageDecayData { get; set; }
    public QueryClientCvarValueDelegate pfnQueryClientCvarValue { get; set; }
    public QueryClientCvarValue2Delegate pfnQueryClientCvarValue2 { get; set; }
    public EngCheckParmDelegate pfnEngCheckParm { get; set; }
}

