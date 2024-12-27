using System.Runtime.InteropServices;
using static Metamod.Struct.Engine.EngineFuncsDelegate;

namespace Metamod.Struct.Engine;

[StructLayout(LayoutKind.Sequential)]
public struct EngineFuncs
{
    internal PrecacheModelDelegate pfnPrecacheModel;
    public bool PrecacheModel(string s)
    {
        nint native = Marshal.StringToHGlobalAnsi(s);
        int result = pfnPrecacheModel(native);
        Marshal.FreeHGlobal(native);
        
        return result != 0;
    }

    internal PrecacheSoundDelegate pfnPrecacheSound;
    public bool PrecacheSound(string s)
    {
        nint native = Marshal.StringToHGlobalAnsi(s);
        int result = pfnPrecacheSound(native);
        Marshal.FreeHGlobal(native);
        return result != 0;
    }

    internal SetModelDelegate pfnSetModel;
    public void SetModel(Edict e, string m)
    {
        nint nativeEdict = Marshal.AllocHGlobal(Marshal.SizeOf<Edict>());
        Marshal.StructureToPtr(e, nativeEdict, false);
        nint native = Marshal.StringToHGlobalAnsi(m);
        pfnSetModel(nativeEdict, native);
        Marshal.FreeHGlobal(nativeEdict);
        Marshal.FreeHGlobal(native);
    }

    internal ModelIndexDelegate pfnModelIndex;
    public int ModelIndex(string m)
    {
        nint native = Marshal.StringToHGlobalAnsi(m);
        int result = pfnModelIndex(native);
        Marshal.FreeHGlobal(native);
        return result;
    }

    internal ModelFramesDelegate pfnModelFrames;
    public int ModelFrames(int modelIndex)
    {
        return pfnModelFrames(modelIndex);
    }

    internal SetSizeDelegate pfnSetSize;
    public void SetSize(Edict e, vec3_t rgflMin, vec3_t rgflMax)
    {
        nint nativeEdict = Marshal.AllocHGlobal(Marshal.SizeOf<Edict>());
        Marshal.StructureToPtr(e, nativeEdict, false);
        nint nativeRgflMin = Marshal.AllocHGlobal(Marshal.SizeOf<vec3_t>());
        Marshal.StructureToPtr(rgflMin, nativeRgflMin, false);
        nint nativeRgflMax = Marshal.AllocHGlobal(Marshal.SizeOf<vec3_t>());
        Marshal.StructureToPtr(rgflMax, nativeRgflMax, false);
        pfnSetSize(nativeEdict, nativeRgflMin, nativeRgflMax);
        Marshal.FreeHGlobal(nativeEdict);
        Marshal.FreeHGlobal(nativeRgflMin);
        Marshal.FreeHGlobal(nativeRgflMax);
    }

    internal ChangeLevelDelegate pfnChangeLevel;
    public void ChangeLevel(string s1, string s2)
    {
        nint nativeS1 = Marshal.StringToHGlobalAnsi(s1);
        nint nativeS2 = Marshal.StringToHGlobalAnsi(s2);
        pfnChangeLevel(nativeS1, nativeS2);
        Marshal.FreeHGlobal(nativeS1);
        Marshal.FreeHGlobal(nativeS2);
    }

    internal GetSpawnParmsDelegate pfnGetSpawnParms;
    public void GetSpawnParms(Edict ent)
    {
        nint native = Marshal.AllocHGlobal(Marshal.SizeOf<Edict>());
        Marshal.StructureToPtr(ent, native, false);
        pfnGetSpawnParms(native);
        Marshal.FreeHGlobal(native);
    }

    internal SaveSpawnParmsDelegate pfnSaveSpawnParms;
    public void SaveSpawnParms(Edict ent)
    {
        nint native = Marshal.AllocHGlobal(Marshal.SizeOf<Edict>());
        Marshal.StructureToPtr(ent, native, false);
        pfnGetSpawnParms(native);
        Marshal.FreeHGlobal(native);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate float VecToYawDelegate(IntPtr rgflVector);
    public VecToYawDelegate pfnVecToYaw;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void VecToAnglesDelegate(IntPtr rgflVectorIn, IntPtr rgflVectorOut);
    public VecToAnglesDelegate pfnVecToAngles;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void MoveToOriginDelegate(IntPtr ent, IntPtr pflGoal, float dist, int iMoveType);
    public MoveToOriginDelegate pfnMoveToOrigin;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void ChangeYawDelegate(IntPtr ent);
    public ChangeYawDelegate pfnChangeYaw;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void ChangePitchDelegate(IntPtr ent);
    public ChangePitchDelegate pfnChangePitch;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr FindEntityByStringDelegate(IntPtr pEdictStartSearchAfter, nint pszField, nint pszValue);
    public FindEntityByStringDelegate pfnFindEntityByString;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int GetEntityIllumDelegate(IntPtr pEnt);
    public GetEntityIllumDelegate pfnGetEntityIllum;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr FindEntityInSphereDelegate(IntPtr pEdictStartSearchAfter, IntPtr org, float rad);
    public FindEntityInSphereDelegate pfnFindEntityInSphere;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr FindClientInPVSDelegate(IntPtr pEdict);
    public FindClientInPVSDelegate pfnFindClientInPVS;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr EntitiesInPVSDelegate(IntPtr pplayer);
    public EntitiesInPVSDelegate pfnEntitiesInPVS;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void MakeVectorsDelegate(IntPtr rgflVector);
    public MakeVectorsDelegate pfnMakeVectors;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void AngleVectorsDelegate(IntPtr rgflVector, IntPtr forward, IntPtr right, IntPtr up);
    public AngleVectorsDelegate pfnAngleVectors;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr CreateEntityDelegate();
    public CreateEntityDelegate pfnCreateEntity;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void RemoveEntityDelegate(IntPtr e);
    public RemoveEntityDelegate pfnRemoveEntity;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr CreateNamedEntityDelegate(int className);
    public CreateNamedEntityDelegate pfnCreateNamedEntity;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void MakeStaticDelegate(IntPtr ent);
    public MakeStaticDelegate pfnMakeStatic;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int EntIsOnFloorDelegate(IntPtr e);
    public EntIsOnFloorDelegate pfnEntIsOnFloor;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int DropToFloorDelegate(IntPtr e);
    public DropToFloorDelegate pfnDropToFloor;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int WalkMoveDelegate(IntPtr ent, float yaw, float dist, int iMode);
    public WalkMoveDelegate pfnWalkMove;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void SetOriginDelegate(IntPtr e, IntPtr rgflOrigin);
    public SetOriginDelegate pfnSetOrigin;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void EmitSoundDelegate(IntPtr entity, int channel, nint sample, float volume, float attenuation, int fFlags, int pitch);
    public EmitSoundDelegate pfnEmitSound;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void EmitAmbientSoundDelegate(IntPtr entity, IntPtr pos, nint samp, float vol, float attenuation, int fFlags, int pitch);
    public EmitAmbientSoundDelegate pfnEmitAmbientSound;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void TraceLineDelegate(IntPtr v1, IntPtr v2, int fNoMonsters, IntPtr pentToSkip, IntPtr ptr);
    public TraceLineDelegate pfnTraceLine;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void TraceTossDelegate(IntPtr pent, IntPtr pentToIgnore, IntPtr ptr);
    public TraceTossDelegate pfnTraceToss;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int TraceMonsterHullDelegate(IntPtr pEdict, IntPtr v1, IntPtr v2, int fNoMonsters, IntPtr pentToSkip, IntPtr ptr);
    public TraceMonsterHullDelegate pfnTraceMonsterHull;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void TraceHullDelegate(IntPtr v1, IntPtr v2, int fNoMonsters, int hullNumber, IntPtr pentToSkip, IntPtr ptr);
    public TraceHullDelegate pfnTraceHull;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void TraceModelDelegate(IntPtr v1, IntPtr v2, int hullNumber, IntPtr pent, IntPtr ptr);
    public TraceModelDelegate pfnTraceModel;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate nint TraceTextureDelegate(IntPtr pTextureEntity, IntPtr v1, IntPtr v2);
    public TraceTextureDelegate pfnTraceTexture;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void TraceSphereDelegate(IntPtr v1, IntPtr v2, int fNoMonsters, float radius, IntPtr pentToSkip, IntPtr ptr);
    public TraceSphereDelegate pfnTraceSphere;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void GetAimVectorDelegate(IntPtr ent, float speed, IntPtr rgflReturn);
    public GetAimVectorDelegate pfnGetAimVector;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void ServerCommandDelegate(nint str);
    public ServerCommandDelegate pfnServerCommand;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void ServerExecuteDelegate();
    public ServerExecuteDelegate pfnServerExecute;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void ClientCommandDelegate(IntPtr pEdict, nint szFmt);
    public ClientCommandDelegate pfnClientCommand;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void ParticleEffectDelegate(IntPtr org, IntPtr dir, float color, float count);
    public ParticleEffectDelegate pfnParticleEffect;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void LightStyleDelegate(int style, nint val);
    public LightStyleDelegate pfnLightStyle;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int DecalIndexDelegate(nint name);
    public DecalIndexDelegate pfnDecalIndex;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int PointContentsDelegate(IntPtr rgflVector);
    public PointContentsDelegate pfnPointContents;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void MessageBeginDelegate(int msg_dest, int msg_type, IntPtr pOrigin, IntPtr ed);
    public MessageBeginDelegate pfnMessageBegin;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void MessageEndDelegate();
    public MessageEndDelegate pfnMessageEnd;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void WriteByteDelegate(int iValue);
    public WriteByteDelegate pfnWriteByte;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void WriteCharDelegate(int iValue);
    public WriteCharDelegate pfnWriteChar;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void WriteShortDelegate(int iValue);
    public WriteShortDelegate pfnWriteShort;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void WriteLongDelegate(int iValue);
    public WriteLongDelegate pfnWriteLong;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void WriteAngleDelegate(float flValue);
    public WriteAngleDelegate pfnWriteAngle;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void WriteCoordDelegate(float flValue);
    public WriteCoordDelegate pfnWriteCoord;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void WriteStringDelegate(nint sz);
    public WriteStringDelegate pfnWriteString;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void WriteEntityDelegate(int iValue);
    public WriteEntityDelegate pfnWriteEntity;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void CVarRegisterDelegate(IntPtr pCvar);
    public CVarRegisterDelegate pfnCVarRegister;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate float CVarGetFloatDelegate(nint szVarName);
    public CVarGetFloatDelegate pfnCVarGetFloat;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate nint CVarGetStringDelegate(nint szVarName);
    public CVarGetStringDelegate pfnCVarGetString;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void CVarSetFloatDelegate(nint szVarName, float flValue);
    public CVarSetFloatDelegate pfnCVarSetFloat;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void CVarSetStringDelegate(nint szVarName, nint szValue);
    public CVarSetStringDelegate pfnCVarSetString;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void AlertMessageDelegate(int atype, nint szFmt);
    public AlertMessageDelegate pfnAlertMessage;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void EngineFprintfDelegate(IntPtr pfile, nint szFmt);
    public EngineFprintfDelegate pfnEngineFprintf;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr PvAllocEntPrivateDataDelegate(IntPtr pEdict, int cb);
    public PvAllocEntPrivateDataDelegate pfnPvAllocEntPrivateData;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr PvEntPrivateDataDelegate(IntPtr pEdict);
    public PvEntPrivateDataDelegate pfnPvEntPrivateData;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void FreeEntPrivateDataDelegate(IntPtr pEdict);
    public FreeEntPrivateDataDelegate pfnFreeEntPrivateData;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate nint SzFromIndexDelegate(int iString);
    public SzFromIndexDelegate pfnSzFromIndex;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int AllocStringDelegate(nint szValue);
    public AllocStringDelegate pfnAllocString;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr GetVarsOfEntDelegate(IntPtr pEdict);
    public GetVarsOfEntDelegate pfnGetVarsOfEnt;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr PEntityOfEntOffsetDelegate(int iEntOffset);
    public PEntityOfEntOffsetDelegate pfnPEntityOfEntOffset;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int EntOffsetOfPEntityDelegate(IntPtr pEdict);
    public EntOffsetOfPEntityDelegate pfnEntOffsetOfPEntity;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int IndexOfEdictDelegate(IntPtr pEdict);
    public IndexOfEdictDelegate pfnIndexOfEdict;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr PEntityOfEntIndexDelegate(int iEntIndex);
    public PEntityOfEntIndexDelegate pfnPEntityOfEntIndex;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr FindEntityByVarsDelegate(IntPtr pvars);
    public FindEntityByVarsDelegate pfnFindEntityByVars;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr GetModelPtrDelegate(IntPtr pEdict);
    public GetModelPtrDelegate pfnGetModelPtr;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int RegUserMsgDelegate(nint pszName, int iSize);
    public RegUserMsgDelegate pfnRegUserMsg;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void AnimationAutomoveDelegate(IntPtr pEdict, float flTime);
    public AnimationAutomoveDelegate pfnAnimationAutomove;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void GetBonePositionDelegate(IntPtr pEdict, int iBone, IntPtr rgflOrigin, IntPtr rgflAngles);
    public GetBonePositionDelegate pfnGetBonePosition;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate uint FunctionFromNameDelegate(nint pName);
    public FunctionFromNameDelegate pfnFunctionFromName;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate nint NameForFunctionDelegate(uint function);
    public NameForFunctionDelegate pfnNameForFunction;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void ClientPrintfDelegate(IntPtr pEdict, int ptype, nint szMsg);
    public ClientPrintfDelegate pfnClientPrintf;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void ServerPrintDelegate(nint szMsg);
    public ServerPrintDelegate pfnServerPrint;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate nint Cmd_ArgsDelegate();
    public Cmd_ArgsDelegate pfnCmd_Args;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate nint Cmd_ArgvDelegate(int argc);
    public Cmd_ArgvDelegate pfnCmd_Argv;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int Cmd_ArgcDelegate();
    public Cmd_ArgcDelegate pfnCmd_Argc;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void GetAttachmentDelegate(IntPtr pEdict, int iAttachment, IntPtr rgflOrigin, IntPtr rgflAngles);
    public GetAttachmentDelegate pfnGetAttachment;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void CRC32_InitDelegate(IntPtr pulCRC);
    public CRC32_InitDelegate pfnCRC32_Init;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void CRC32_ProcessBufferDelegate(IntPtr pulCRC, IntPtr p, int len);
    public CRC32_ProcessBufferDelegate pfnCRC32_ProcessBuffer;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void CRC32_ProcessByteDelegate(IntPtr pulCRC, byte ch);
    public CRC32_ProcessByteDelegate pfnCRC32_ProcessByte;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate uint CRC32_FinalDelegate(uint pulCRC);
    public CRC32_FinalDelegate pfnCRC32_Final;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int RandomLongDelegate(int lLow, int lHigh);
    public RandomLongDelegate pfnRandomLong;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate float RandomFloatDelegate(float flLow, float flHigh);
    public RandomFloatDelegate pfnRandomFloat;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void SetViewDelegate(IntPtr pClient, IntPtr pViewent);
    public SetViewDelegate pfnSetView;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate float TimeDelegate();
    public TimeDelegate pfnTime;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void CrosshairAngleDelegate(IntPtr pClient, float pitch, float yaw);
    public CrosshairAngleDelegate pfnCrosshairAngle;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr LoadFileForMeDelegate(nint filename, IntPtr pLength);
    public LoadFileForMeDelegate pfnLoadFileForMe;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void FreeFileDelegate(IntPtr buffer);
    public FreeFileDelegate pfnFreeFile;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void EndSectionDelegate(nint pszSectionName);
    public EndSectionDelegate pfnEndSection;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int CompareFileTimeDelegate(nint filename1, nint filename2, nint iCompare);

}
