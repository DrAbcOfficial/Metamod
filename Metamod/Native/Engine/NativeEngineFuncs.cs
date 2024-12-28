using System.Runtime.InteropServices;

namespace Metamod.Native.Engine;

[StructLayout(LayoutKind.Sequential)]
internal unsafe struct NativeEngineFuncs
{
    internal PrecacheModelDelegate pfnPrecacheModel;
    internal PrecacheSoundDelegate pfnPrecacheSound;
    internal SetModelDelegate pfnSetModel;
    internal ModelIndexDelegate pfnModelIndex;
    internal ModelFramesDelegate pfnModelFrames;
    internal SetSizeDelegate pfnSetSize;
    internal ChangeLevelDelegate pfnChangeLevel;
    internal GetSpawnParmsDelegate pfnGetSpawnParms;
    internal SaveSpawnParmsDelegate pfnSaveSpawnParms;
    internal VecToYawDelegate pfnVecToYaw;
    internal VecToAnglesDelegate pfnVecToAngles;
    internal MoveToOriginDelegate pfnMoveToOrigin;
    internal ChangeYawDelegate pfnChangeYaw;
    internal ChangePitchDelegate pfnChangePitch;
    internal FindEntityByStringDelegate pfnFindEntityByString;
    internal GetEntityIllumDelegate pfnGetEntityIllum;
    internal FindEntityInSphereDelegate pfnFindEntityInSphere;
    internal FindClientInPVSDelegate pfnFindClientInPVS;
    internal EntitiesInPVSDelegate pfnEntitiesInPVS;
    internal MakeVectorsDelegate pfnMakeVectors;
    internal AngleVectorsDelegate pfnAngleVectors;
    internal CreateEntityDelegate pfnCreateEntity;
    internal RemoveEntityDelegate pfnRemoveEntity;
    internal CreateNamedEntityDelegate pfnCreateNamedEntity;
    internal MakeStaticDelegate pfnMakeStatic;
    internal EntIsOnFloorDelegate pfnEntIsOnFloor;
    internal DropToFloorDelegate pfnDropToFloor;
    internal WalkMoveDelegate pfnWalkMove;
    internal SetOriginDelegate pfnSetOrigin;
    internal EmitSoundDelegate pfnEmitSound;
    internal EmitAmbientSoundDelegate pfnEmitAmbientSound;
    internal TraceLineDelegate pfnTraceLine;
    internal TraceTossDelegate pfnTraceToss;
    internal TraceMonsterHullDelegate pfnTraceMonsterHull;
    internal TraceHullDelegate pfnTraceHull;
    internal TraceModelDelegate pfnTraceModel;
    internal TraceTextureDelegate pfnTraceTexture;
    internal TraceSphereDelegate pfnTraceSphere;
    internal GetAimVectorDelegate pfnGetAimVector;
    internal ServerCommandDelegate pfnServerCommand;
    internal ServerExecuteDelegate pfnServerExecute;
    internal ClientCommandDelegate pfnClientCommand;
    internal ParticleEffectDelegate pfnParticleEffect;
    internal LightStyleDelegate pfnLightStyle;
    internal DecalIndexDelegate pfnDecalIndex;
    internal PointContentsDelegate pfnPointContents;
    internal MessageBeginDelegate pfnMessageBegin;
    internal MessageEndDelegate pfnMessageEnd;
    internal WriteByteDelegate pfnWriteByte;
    internal WriteCharDelegate pfnWriteChar;
    internal WriteShortDelegate pfnWriteShort;
    internal WriteLongDelegate pfnWriteLong;
    internal WriteAngleDelegate pfnWriteAngle;
    internal WriteCoordDelegate pfnWriteCoord;
    internal WriteStringDelegate pfnWriteString;
    internal WriteEntityDelegate pfnWriteEntity;
    internal CVarRegisterDelegate pfnCVarRegister;
    internal CVarGetFloatDelegate pfnCVarGetFloat;
    internal CVarGetStringDelegate pfnCVarGetString;
    internal CVarSetFloatDelegate pfnCVarSetFloat;
    internal CVarSetStringDelegate pfnCVarSetString;
    internal AlertMessageDelegate pfnAlertMessage;
    internal EngineFprintfDelegate pfnEngineFprintf;
    internal PvAllocEntPrivateDataDelegate pfnPvAllocEntPrivateData;
    internal PvEntPrivateDataDelegate pfnPvEntPrivateData;
    internal FreeEntPrivateDataDelegate pfnFreeEntPrivateData;
    internal SzFromIndexDelegate pfnSzFromIndex;
    internal AllocStringDelegate pfnAllocString;
    internal GetVarsOfEntDelegate pfnGetVarsOfEnt;
    internal PEntityOfEntOffsetDelegate pfnPEntityOfEntOffset;
    internal EntOffsetOfPEntityDelegate pfnEntOffsetOfPEntity;
    internal IndexOfEdictDelegate pfnIndexOfEdict;
    internal PEntityOfEntIndexDelegate pfnPEntityOfEntIndex;
    internal FindEntityByVarsDelegate pfnFindEntityByVars;
    internal GetModelPtrDelegate pfnGetModelPtr;
    internal RegUserMsgDelegate pfnRegUserMsg;
    internal AnimationAutomoveDelegate pfnAnimationAutomove;
    internal GetBonePositionDelegate pfnGetBonePosition;
    internal FunctionFromNameDelegate pfnFunctionFromName;
    internal NameForFunctionDelegate pfnNameForFunction;
    internal ClientPrintfDelegate pfnClientPrintf;
    internal ServerPrintDelegate pfnServerPrint;
    internal Cmd_ArgsDelegate pfnCmd_Args;
    internal Cmd_ArgvDelegate pfnCmd_Argv;
    internal Cmd_ArgcDelegate pfnCmd_Argc;
    internal GetAttachmentDelegate pfnGetAttachment;
    internal CRC32_InitDelegate pfnCRC32_Init;
    internal CRC32_ProcessBufferDelegate pfnCRC32_ProcessBuffer;
    internal CRC32_ProcessByteDelegate pfnCRC32_ProcessByte;
    internal CRC32_FinalDelegate pfnCRC32_Final;
    internal RandomLongDelegate pfnRandomLong;
    internal RandomFloatDelegate pfnRandomFloat;
    internal SetViewDelegate pfnSetView;
    internal TimeDelegate pfnTime;
    internal CrosshairAngleDelegate pfnCrosshairAngle;
    internal LoadFileForMeDelegate pfnLoadFileForMe;
    internal FreeFileDelegate pfnFreeFile;
    internal EndSectionDelegate pfnEndSection;
    internal CompareFileTimeDelegate pfnCompareFileTime;
    internal GetGameDirDelegate pfnGetGameDir;
    internal Cvar_RegisterVariableDelegate pfnCvar_RegisterVariable;
    internal FadeClientVolumeDelegate pfnFadeClientVolume;
    internal SetClientMaxspeedDelegate pfnSetClientMaxspeed;
    internal CreateFakeClientDelegate pfnCreateFakeClient;
    internal RunPlayerMoveDelegate pfnRunPlayerMove;
    internal NumberOfEntitiesDelegate pfnNumberOfEntities;
    internal GetInfoKeyBufferDelegate pfnGetInfoKeyBuffer;
    internal InfoKeyValueDelegate pfnInfoKeyValue;
    internal SetKeyValueDelegate pfnSetKeyValue;
    internal SetClientKeyValueDelegate pfnSetClientKeyValue;
    internal IsMapValidDelegate pfnIsMapValid;
    internal StaticDecalDelegate pfnStaticDecal;
    internal PrecacheGenericDelegate pfnPrecacheGeneric;
    internal GetPlayerUserIdDelegate pfnGetPlayerUserId;
    internal BuildSoundMsgDelegate pfnBuildSoundMsg;
    internal IsDedicatedServerDelegate pfnIsDedicatedServer;
    internal CVarGetPointerDelegate pfnCVarGetPointer;
    internal GetPlayerWONIdDelegate pfnGetPlayerWONId;
    internal Info_RemoveKeyDelegate pfnInfo_RemoveKey;
    internal GetPhysicsKeyValueDelegate pfnGetPhysicsKeyValue;
    internal SetPhysicsKeyValueDelegate pfnSetPhysicsKeyValue;
    internal GetPhysicsInfoStringDelegate pfnGetPhysicsInfoString;
    internal PrecacheEventDelegate pfnPrecacheEvent;
    internal PlaybackEventDelegate pfnPlaybackEvent;
    internal SetFatPVSDelegate pfnSetFatPVS;
    internal SetFatPASDelegate pfnSetFatPAS;
    internal CheckVisibilityDelegate pfnCheckVisibility;
    internal DeltaSetFieldDelegate pfnDeltaSetField;
    internal DeltaUnsetFieldDelegate pfnDeltaUnsetField;
    internal DeltaAddEncoderDelegate pfnDeltaAddEncoder;
    internal GetCurrentPlayerDelegate pfnGetCurrentPlayer;
    internal CanSkipPlayerDelegate pfnCanSkipPlayer;
    internal DeltaFindFieldDelegate pfnDeltaFindField;
    internal DeltaSetFieldByIndexDelegate pfnDeltaSetFieldByIndex;
    internal DeltaUnsetFieldByIndexDelegate pfnDeltaUnsetFieldByIndex;
    internal SetGroupMaskDelegate pfnSetGroupMask;
    internal CreateInstancedBaselineDelegate pfnCreateInstancedBaseline;
    internal Cvar_DirectSetDelegate pfnCvar_DirectSet;
    internal ForceUnmodifiedDelegate pfnForceUnmodified;
    internal GetPlayerStatsDelegate pfnGetPlayerStats;
    internal AddServerCommandDelegate pfnAddServerCommand;
    internal Voice_GetClientListeningDelegate pfnVoice_GetClientListening;
    internal Voice_SetClientListeningDelegate pfnVoice_SetClientListening;
    internal GetPlayerAuthIdDelegate pfnGetPlayerAuthId;
    internal SequenceGetDelegate pfnSequenceGet;
    internal SequencePickSentenceDelegate pfnSequencePickSentence;
    internal GetFileSizeDelegate pfnGetFileSize;
    internal GetApproxWavePlayLenDelegate pfnGetApproxWavePlayLen;
    internal IsCareerMatchDelegate pfnIsCareerMatch;
    internal GetLocalizedStringLengthDelegate pfnGetLocalizedStringLength;
    internal RegisterTutorMessageShownDelegate pfnRegisterTutorMessageShown;
    internal GetTimesTutorMessageShownDelegate pfnGetTimesTutorMessageShown;
    internal ProcessTutorMessageDecayBufferDelegate pfnProcessTutorMessageDecayBuffer;
    internal ConstructTutorMessageDecayBufferDelegate pfnConstructTutorMessageDecayBuffer;
    internal ResetTutorMessageDecayDataDelegate pfnResetTutorMessageDecayData;
    internal QueryClientCvarValueDelegate pfnQueryClientCvarValue;
    internal QueryClientCvarValue2Delegate pfnQueryClientCvarValue2;
    internal EngCheckParmDelegate pfnEngCheckParm;

    #region Delegate
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int PrecacheModelDelegate(nint s);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int PrecacheSoundDelegate(nint s);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetModelDelegate(nint e, nint m);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int ModelIndexDelegate(nint m);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int ModelFramesDelegate(int modelIndex);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetSizeDelegate(nint e, nint rgflMin, nint rgflMax);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void ChangeLevelDelegate(nint s1, nint s2);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void GetSpawnParmsDelegate(nint ent);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SaveSpawnParmsDelegate(nint ent);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate float VecToYawDelegate(nint rgflVector);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void VecToAnglesDelegate(nint rgflVectorIn, nint rgflVectorOut);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void MoveToOriginDelegate(nint ent, nint pflGoal, float dist, int iMoveType);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void ChangeYawDelegate(nint ent);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void ChangePitchDelegate(nint ent);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint FindEntityByStringDelegate(nint pEdictStartSearchAfter, nint pszField, nint pszValue);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int GetEntityIllumDelegate(nint pEnt);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint FindEntityInSphereDelegate(nint pEdictStartSearchAfter, nint org, float rad);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint FindClientInPVSDelegate(nint pEdict);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint EntitiesInPVSDelegate(nint pplayer);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void MakeVectorsDelegate(nint rgflVector);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void AngleVectorsDelegate(nint rgflVector, nint forward, nint right, nint up);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint CreateEntityDelegate();
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void RemoveEntityDelegate(nint e);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint CreateNamedEntityDelegate(int className);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void MakeStaticDelegate(nint ent);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int EntIsOnFloorDelegate(nint e);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int DropToFloorDelegate(nint e);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int WalkMoveDelegate(nint ent, float yaw, float dist, int iMode);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetOriginDelegate(nint e, nint rgflOrigin);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void EmitSoundDelegate(nint entity, int channel, nint sample, float volume, float attenuation, int fFlags, int pitch);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void EmitAmbientSoundDelegate(nint entity, nint pos, nint samp, float vol, float attenuation, int fFlags, int pitch);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void TraceLineDelegate(nint v1, nint v2, int fNoMonsters, nint pentToSkip, nint ptr);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void TraceTossDelegate(nint pent, nint pentToIgnore, nint ptr);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int TraceMonsterHullDelegate(nint pEdict, nint v1, nint v2, int fNoMonsters, nint pentToSkip, nint ptr);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void TraceHullDelegate(nint v1, nint v2, int fNoMonsters, int hullNumber, nint pentToSkip, nint ptr);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void TraceModelDelegate(nint v1, nint v2, int hullNumber, nint pent, nint ptr);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint TraceTextureDelegate(nint pTextureEntity, nint v1, nint v2);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void TraceSphereDelegate(nint v1, nint v2, int fNoMonsters, float radius, nint pentToSkip, nint ptr);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void GetAimVectorDelegate(nint ent, float speed, nint rgflReturn);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void ServerCommandDelegate(nint str);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void ServerExecuteDelegate();
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void ClientCommandDelegate(nint pEdict, nint szFmt);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void ParticleEffectDelegate(nint org, nint dir, float color, float count);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void LightStyleDelegate(int style, nint val);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int DecalIndexDelegate(nint name);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int PointContentsDelegate(nint rgflVector);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void MessageBeginDelegate(int msg_dest, int msg_type, nint pOrigin, nint ed);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void MessageEndDelegate();
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void WriteByteDelegate(int iValue);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void WriteCharDelegate(int iValue);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void WriteShortDelegate(int iValue);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void WriteLongDelegate(int iValue);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void WriteAngleDelegate(float flValue);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void WriteCoordDelegate(float flValue);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void WriteStringDelegate(nint sz);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void WriteEntityDelegate(int iValue);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void CVarRegisterDelegate(nint pCvar);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate float CVarGetFloatDelegate(nint szVarName);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint CVarGetStringDelegate(nint szVarName);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void CVarSetFloatDelegate(nint szVarName, float flValue);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void CVarSetStringDelegate(nint szVarName, nint szValue);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void AlertMessageDelegate(int atype, nint szFmt);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void EngineFprintfDelegate(nint pfile, nint szFmt);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint PvAllocEntPrivateDataDelegate(nint pEdict, int cb);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint PvEntPrivateDataDelegate(nint pEdict);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void FreeEntPrivateDataDelegate(nint pEdict);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint SzFromIndexDelegate(int iString);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int AllocStringDelegate(nint szValue);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint GetVarsOfEntDelegate(nint pEdict);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint PEntityOfEntOffsetDelegate(int iEntOffset);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int EntOffsetOfPEntityDelegate(nint pEdict);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int IndexOfEdictDelegate(nint pEdict);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint PEntityOfEntIndexDelegate(int iEntIndex);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint FindEntityByVarsDelegate(nint pvars);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint GetModelPtrDelegate(nint pEdict);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int RegUserMsgDelegate(nint pszName, int iSize);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void AnimationAutomoveDelegate(nint pEdict, float flTime);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void GetBonePositionDelegate(nint pEdict, int iBone, nint rgflOrigin, nint rgflAngles);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate uint FunctionFromNameDelegate(nint pName);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint NameForFunctionDelegate(uint function);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void ClientPrintfDelegate(nint pEdict, int ptype, nint szMsg);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void ServerPrintDelegate(nint szMsg);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint Cmd_ArgsDelegate();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint Cmd_ArgvDelegate(int argc);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int Cmd_ArgcDelegate();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void GetAttachmentDelegate(nint pEdict, int iAttachment, nint rgflOrigin, nint rgflAngles);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void CRC32_InitDelegate(nint pulCRC);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void CRC32_ProcessBufferDelegate(nint pulCRC, nint p, int len);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void CRC32_ProcessByteDelegate(nint pulCRC, byte ch);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate uint CRC32_FinalDelegate(uint pulCRC);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int RandomLongDelegate(int lLow, int lHigh);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate float RandomFloatDelegate(float flLow, float flHigh);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetViewDelegate(nint pClient, nint pViewent);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate float TimeDelegate();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void CrosshairAngleDelegate(nint pClient, float pitch, float yaw);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint LoadFileForMeDelegate(nint filename, nint pLength);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void FreeFileDelegate(nint buffer);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void EndSectionDelegate(nint pszSectionName);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int CompareFileTimeDelegate(nint filename1, nint filename2, nint iCompare);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void GetGameDirDelegate(nint szGetGameDir);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void Cvar_RegisterVariableDelegate(nint variable);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void FadeClientVolumeDelegate(nint pEdict, int fadePercent, int fadeOutSeconds, int holdTime, int fadeInSeconds);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetClientMaxspeedDelegate(nint pEdict, float fNewMaxspeed);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint CreateFakeClientDelegate(byte* netname);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void RunPlayerMoveDelegate(nint fakeclient, nint viewangles, float forwardmove, float sidemove, float upmove, ushort buttons, byte impulse, byte msec);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int NumberOfEntitiesDelegate();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint GetInfoKeyBufferDelegate(nint e);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint InfoKeyValueDelegate(nint infobuffer, byte* key);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetKeyValueDelegate(nint infobuffer, byte* key, byte* value);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetClientKeyValueDelegate(int clientIndex, nint infobuffer, byte* key, byte* value);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int IsMapValidDelegate(byte* filename);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void StaticDecalDelegate(nint origin, int decalIndex, int entityIndex, int modelIndex);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int PrecacheGenericDelegate(byte* s);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int GetPlayerUserIdDelegate(nint e);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void BuildSoundMsgDelegate(nint entity, int channel, byte* sample, float volume, float attenuation, int fFlags, int pitch, int msg_dest, int msg_type, nint pOrigin, nint ed);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int IsDedicatedServerDelegate();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint CVarGetPointerDelegate(byte* szVarName);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate uint GetPlayerWONIdDelegate(nint e);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void Info_RemoveKeyDelegate(nint s, byte* key);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint GetPhysicsKeyValueDelegate(nint pClient, byte* key);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetPhysicsKeyValueDelegate(nint pClient, byte* key, byte* value);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint GetPhysicsInfoStringDelegate(nint pClient);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate ushort PrecacheEventDelegate(int type, byte* psz);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void PlaybackEventDelegate(int flags, nint pInvoker, ushort eventindex, float delay, nint origin, nint angles, float fparam1, float fparam2, int iparam1, int iparam2, int bparam1, int bparam2);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint SetFatPVSDelegate(nint org);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint SetFatPASDelegate(nint org);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int CheckVisibilityDelegate(nint entity, nint pset);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void DeltaSetFieldDelegate(nint pFields, byte* fieldname);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void DeltaUnsetFieldDelegate(nint pFields, byte* fieldname);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void DeltaAddEncoderDelegate(byte* name, nint conditionalencode);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int GetCurrentPlayerDelegate();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int CanSkipPlayerDelegate(nint player);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int DeltaFindFieldDelegate(nint pFields, byte* fieldname);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void DeltaSetFieldByIndexDelegate(nint pFields, int fieldNumber);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void DeltaUnsetFieldByIndexDelegate(nint pFields, int fieldNumber);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetGroupMaskDelegate(int mask, int op);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int CreateInstancedBaselineDelegate(int classname, nint baseline);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void Cvar_DirectSetDelegate(nint var, byte* value);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void ForceUnmodifiedDelegate(int type, nint mins, nint maxs, byte* filename);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void GetPlayerStatsDelegate(nint pClient, out int ping, out int packet_loss);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void AddServerCommandDelegate(byte* cmd_name, nint function);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate bool Voice_GetClientListeningDelegate(int iReceiver, int iSender);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate bool Voice_SetClientListeningDelegate(int iReceiver, int iSender, bool bListen);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint GetPlayerAuthIdDelegate(nint e);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint SequenceGetDelegate(byte* fileName, byte* entryName);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint SequencePickSentenceDelegate(byte* groupName, int pickMethod, out int picked);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int GetFileSizeDelegate(byte* filename);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate uint GetApproxWavePlayLenDelegate(byte* filepath);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int IsCareerMatchDelegate();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int GetLocalizedStringLengthDelegate(byte* label);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void RegisterTutorMessageShownDelegate(int mid);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int GetTimesTutorMessageShownDelegate(int mid);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void ProcessTutorMessageDecayBufferDelegate(nint buffer, int bufferLength);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void ConstructTutorMessageDecayBufferDelegate(nint buffer, int bufferLength);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void ResetTutorMessageDecayDataDelegate();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void QueryClientCvarValueDelegate(nint player, byte* cvarName);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void QueryClientCvarValue2Delegate(nint player, byte* cvarName, int requestID);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int EngCheckParmDelegate(byte* pchCmdLineToken, out nint pchNextVal);
    #endregion
}
