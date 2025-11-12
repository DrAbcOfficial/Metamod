using Metamod.Helper;
using Metamod.Interface.Events;
using Metamod.Interface.Events.NativeCaller;
using Metamod.Native.Engine;
using Metamod.Native.Game;
using Metamod.Native.Metamod;
using Metamod.Struct.Engine;
using Metamod.Struct.Metamod;
using System.Runtime.InteropServices;

namespace Metamod.Interface;

public class MetaMod
{
    #region 内部函数
    private static DLLEvents? _entityApi = null;
    private static DLLEvents? _entityApi_Post = null;
    private static DLLEvents? _entityApi2 = null;
    private static DLLEvents? _entityApi2_Post = null;
    private static NewDLLEvents? _newDllFunctions = null;
    private static NewDLLEvents? _newDLLFunctions_Post = null;
    private static EngineEvents? _engineFunctions = null;
    private static EngineEvents? _engineFunctions_Post = null;
    private static BlendingInterfaceEvent? _blendingInterface = null;
    private static BlendingInterfaceEvent? _blendingInterface_Post = null;

    // 将托管 delegate 转为原生函数指针并按字段顺序写入到非托管结构内存中。
    // 注意：字段顺序必须与 NativeDllFuncs 的定义完全一致（指针大小顺序）。
    private static unsafe void LinkNativeDLLEvents(nint pFunctionTable, NativeDllFuncs source)
    {
        if (pFunctionTable == 0)
            throw new ArgumentNullException(nameof(pFunctionTable), "pFunctionTable is NULL in LinkNativeDLLEvents.");

        IntPtr* dest = (IntPtr*)pFunctionTable;
        int i = 0;

        dest[i++] = source.pfnGameInit == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnGameInit);
        dest[i++] = source.pfnSpawn == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnSpawn);
        dest[i++] = source.pfnThink == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnThink);
        dest[i++] = source.pfnUse == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnUse);
        dest[i++] = source.pfnTouch == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnTouch);
        dest[i++] = source.pfnBlocked == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnBlocked);
        dest[i++] = source.pfnKeyValue == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnKeyValue);
        dest[i++] = source.pfnSave == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnSave);
        dest[i++] = source.pfnRestore == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnRestore);
        dest[i++] = source.pfnSetAbsBox == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnSetAbsBox);
        dest[i++] = source.pfnSaveWriteFields == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnSaveWriteFields);
        dest[i++] = source.pfnSaveReadFields == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnSaveReadFields);
        dest[i++] = source.pfnSaveGlobalState == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnSaveGlobalState);
        dest[i++] = source.pfnRestoreGlobalState == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnRestoreGlobalState);
        dest[i++] = source.pfnResetGlobalState == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnResetGlobalState);
        dest[i++] = source.pfnClientConnect == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnClientConnect);
        dest[i++] = source.pfnClientDisconnect == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnClientDisconnect);
        dest[i++] = source.pfnClientKill == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnClientKill);
        dest[i++] = source.pfnClientPutInServer == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnClientPutInServer);
        dest[i++] = source.pfnClientCommand == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnClientCommand);
        dest[i++] = source.pfnClientUserInfoChanged == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnClientUserInfoChanged);
        dest[i++] = source.pfnServerActivate == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnServerActivate);
        dest[i++] = source.pfnServerDeactivate == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnServerDeactivate);
        dest[i++] = source.pfnPlayerPreThink == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnPlayerPreThink);
        dest[i++] = source.pfnPlayerPostThink == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnPlayerPostThink);
        dest[i++] = source.pfnStartFrame == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnStartFrame);
        dest[i++] = source.pfnParmsNewLevel == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnParmsNewLevel);
        dest[i++] = source.pfnParmsChangeLevel == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnParmsChangeLevel);
        dest[i++] = source.pfnGetGameDescription == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnGetGameDescription);
        dest[i++] = source.pfnPlayerCustomization == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnPlayerCustomization);
        dest[i++] = source.pfnSpectatorConnect == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnSpectatorConnect);
        dest[i++] = source.pfnSpectatorDisconnect == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnSpectatorDisconnect);
        dest[i++] = source.pfnSpectatorThink == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnSpectatorThink);
        dest[i++] = source.pfnSysError == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnSysError);
        dest[i++] = source.pfnPMMove == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnPMMove);
        dest[i++] = source.pfnPMInit == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnPMInit);
        dest[i++] = source.pfnPMFindTextureType == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnPMFindTextureType);
        dest[i++] = source.pfnSetupVisibility == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnSetupVisibility);
        dest[i++] = source.pfnUpdateClientData == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnUpdateClientData);
        dest[i++] = source.pfnAddToFullPack == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnAddToFullPack);
        dest[i++] = source.pfnCreateBaseline == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnCreateBaseline);
        dest[i++] = source.pfnRegisterEncoders == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnRegisterEncoders);
        dest[i++] = source.pfnGetWeaponData == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnGetWeaponData);
        dest[i++] = source.pfnCmdStart == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnCmdStart);
        dest[i++] = source.pfnCmdEnd == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnCmdEnd);
        dest[i++] = source.pfnConnectionlessPacket == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnConnectionlessPacket);
        dest[i++] = source.pfnGetHullBounds == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnGetHullBounds);
        dest[i++] = source.pfnCreateInstancedBaselines == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnCreateInstancedBaselines);
        dest[i++] = source.pfnInconsistentFile == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnInconsistentFile);
        dest[i++] = source.pfnAllowLagCompensation == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnAllowLagCompensation);
    }
    private static unsafe void LinkNativeNewDLLEvents(nint pFunctionTable, NativeNewDllFuncs source)
    {
        if (pFunctionTable == 0)
            throw new ArgumentNullException(nameof(pFunctionTable), "pFunctionTable is NULL in LinkNativeNewDLLEvents.");

        IntPtr* dest = (IntPtr*)pFunctionTable;
        int i = 0;

        dest[i++] = source.pfnOnFreeEntPrivateData == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnOnFreeEntPrivateData);
        dest[i++] = source.pfnGameShutdown == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnGameShutdown);
        dest[i++] = source.pfnShouldCollide == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnShouldCollide);
        dest[i++] = source.pfnCvarValue == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnCvarValue);
        dest[i++] = source.pfnCvarValue2 == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnCvarValue2);
    }
    private static unsafe void LinkNativeEngineEvents(nint pFunctionTable, NativeEngineFuncs source)
    {
        if (pFunctionTable == 0)
            throw new ArgumentNullException(nameof(pFunctionTable), "pFunctionTable is NULL in LinkNativeEngineEvents.");
        IntPtr* dest = (IntPtr*)pFunctionTable;
        int i = 0;

        dest[i++] = source.pfnPrecacheModel == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnPrecacheModel);
        dest[i++] = source.pfnPrecacheSound == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnPrecacheSound);
        dest[i++] = source.pfnSetModel == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnSetModel);
        dest[i++] = source.pfnModelIndex == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnModelIndex);
        dest[i++] = source.pfnModelFrames == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnModelFrames);
        dest[i++] = source.pfnSetSize == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnSetSize);
        dest[i++] = source.pfnChangeLevel == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnChangeLevel);
        dest[i++] = source.pfnGetSpawnParms == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnGetSpawnParms);
        dest[i++] = source.pfnSaveSpawnParms == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnSaveSpawnParms);
        dest[i++] = source.pfnVecToYaw == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnVecToYaw);
        dest[i++] = source.pfnVecToAngles == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnVecToAngles);
        dest[i++] = source.pfnMoveToOrigin == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnMoveToOrigin);
        dest[i++] = source.pfnChangeYaw == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnChangeYaw);
        dest[i++] = source.pfnChangePitch == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnChangePitch);
        dest[i++] = source.pfnFindEntityByString == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnFindEntityByString);
        dest[i++] = source.pfnGetEntityIllum == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnGetEntityIllum);
        dest[i++] = source.pfnFindEntityInSphere == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnFindEntityInSphere);
        dest[i++] = source.pfnFindClientInPVS == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnFindClientInPVS);
        dest[i++] = source.pfnEntitiesInPVS == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnEntitiesInPVS);
        dest[i++] = source.pfnMakeVectors == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnMakeVectors);
        dest[i++] = source.pfnAngleVectors == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnAngleVectors);
        dest[i++] = source.pfnCreateEntity == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnCreateEntity);
        dest[i++] = source.pfnRemoveEntity == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnRemoveEntity);
        dest[i++] = source.pfnCreateNamedEntity == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnCreateNamedEntity);
        dest[i++] = source.pfnMakeStatic == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnMakeStatic);
        dest[i++] = source.pfnEntIsOnFloor == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnEntIsOnFloor);
        dest[i++] = source.pfnDropToFloor == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnDropToFloor);
        dest[i++] = source.pfnWalkMove == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnWalkMove);
        dest[i++] = source.pfnSetOrigin == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnSetOrigin);
        dest[i++] = source.pfnEmitSound == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnEmitSound);
        dest[i++] = source.pfnEmitAmbientSound == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnEmitAmbientSound);
        dest[i++] = source.pfnTraceLine == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnTraceLine);
        dest[i++] = source.pfnTraceToss == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnTraceToss);
        dest[i++] = source.pfnTraceMonsterHull == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnTraceMonsterHull);
        dest[i++] = source.pfnTraceHull == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnTraceHull);
        dest[i++] = source.pfnTraceModel == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnTraceModel);
        dest[i++] = source.pfnTraceTexture == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnTraceTexture);
        dest[i++] = source.pfnTraceSphere == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnTraceSphere);
        dest[i++] = source.pfnGetAimVector == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnGetAimVector);
        dest[i++] = source.pfnServerCommand == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnServerCommand);
        dest[i++] = source.pfnServerExecute == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnServerExecute);
        dest[i++] = source.pfnClientCommand == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnClientCommand);
        dest[i++] = source.pfnParticleEffect == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnParticleEffect);
        dest[i++] = source.pfnLightStyle == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnLightStyle);
        dest[i++] = source.pfnDecalIndex == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnDecalIndex);
        dest[i++] = source.pfnPointContents == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnPointContents);
        dest[i++] = source.pfnMessageBegin == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnMessageBegin);
        dest[i++] = source.pfnMessageEnd == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnMessageEnd);
        dest[i++] = source.pfnWriteByte == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnWriteByte);
        dest[i++] = source.pfnWriteChar == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnWriteChar);
        dest[i++] = source.pfnWriteShort == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnWriteShort);
        dest[i++] = source.pfnWriteLong == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnWriteLong);
        dest[i++] = source.pfnWriteAngle == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnWriteAngle);
        dest[i++] = source.pfnWriteCoord == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnWriteCoord);
        dest[i++] = source.pfnWriteString == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnWriteString);
        dest[i++] = source.pfnWriteEntity == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnWriteEntity);
        dest[i++] = source.pfnCVarRegister == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnCVarRegister);
        dest[i++] = source.pfnCVarGetFloat == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnCVarGetFloat);
        dest[i++] = source.pfnCVarGetString == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnCVarGetString);
        dest[i++] = source.pfnCVarSetFloat == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnCVarSetFloat);
        dest[i++] = source.pfnCVarSetString == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnCVarSetString);
        dest[i++] = source.pfnAlertMessage == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnAlertMessage);
        dest[i++] = source.pfnEngineFprintf == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnEngineFprintf);
        dest[i++] = source.pfnPvAllocEntPrivateData == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnPvAllocEntPrivateData);
        dest[i++] = source.pfnPvEntPrivateData == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnPvEntPrivateData);
        dest[i++] = source.pfnFreeEntPrivateData == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnFreeEntPrivateData);
        dest[i++] = source.pfnSzFromIndex == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnSzFromIndex);
        dest[i++] = source.pfnAllocString == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnAllocString);
        dest[i++] = source.pfnGetVarsOfEnt == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnGetVarsOfEnt);
        dest[i++] = source.pfnPEntityOfEntOffset == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnPEntityOfEntOffset);
        dest[i++] = source.pfnEntOffsetOfPEntity == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnEntOffsetOfPEntity);
        dest[i++] = source.pfnIndexOfEdict == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnIndexOfEdict);
        dest[i++] = source.pfnPEntityOfEntIndex == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnPEntityOfEntIndex);
        dest[i++] = source.pfnFindEntityByVars == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnFindEntityByVars);
        dest[i++] = source.pfnGetModelPtr == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnGetModelPtr);
        dest[i++] = source.pfnRegUserMsg == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnRegUserMsg);
        dest[i++] = source.pfnAnimationAutomove == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnAnimationAutomove);
        dest[i++] = source.pfnGetBonePosition == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnGetBonePosition);
        dest[i++] = source.pfnFunctionFromName == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnFunctionFromName);
        dest[i++] = source.pfnNameForFunction == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnNameForFunction);
        dest[i++] = source.pfnClientPrintf == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnClientPrintf);
        dest[i++] = source.pfnServerPrint == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnServerPrint);
        dest[i++] = source.pfnCmd_Args == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnCmd_Args);
        dest[i++] = source.pfnCmd_Argv == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnCmd_Argv);
        dest[i++] = source.pfnCmd_Argc == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnCmd_Argc);
        dest[i++] = source.pfnGetAttachment == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnGetAttachment);
        dest[i++] = source.pfnCRC32_Init == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnCRC32_Init);
        dest[i++] = source.pfnCRC32_ProcessBuffer == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnCRC32_ProcessBuffer);
        dest[i++] = source.pfnCRC32_ProcessByte == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnCRC32_ProcessByte);
        dest[i++] = source.pfnCRC32_Final == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnCRC32_Final);
        dest[i++] = source.pfnRandomLong == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnRandomLong);
        dest[i++] = source.pfnRandomFloat == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnRandomFloat);
        dest[i++] = source.pfnSetView == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnSetView);
        dest[i++] = source.pfnTime == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnTime);
        dest[i++] = source.pfnCrosshairAngle == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnCrosshairAngle);
        dest[i++] = source.pfnLoadFileForMe == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnLoadFileForMe);
        dest[i++] = source.pfnFreeFile == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnFreeFile);
        dest[i++] = source.pfnEndSection == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnEndSection);
        dest[i++] = source.pfnCompareFileTime == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnCompareFileTime);
        dest[i++] = source.pfnGetGameDir == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnGetGameDir);
        dest[i++] = source.pfnCvar_RegisterVariable == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnCvar_RegisterVariable);
        dest[i++] = source.pfnFadeClientVolume == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnFadeClientVolume);
        dest[i++] = source.pfnSetClientMaxspeed == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnSetClientMaxspeed);
        dest[i++] = source.pfnCreateFakeClient == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnCreateFakeClient);
        dest[i++] = source.pfnRunPlayerMove == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnRunPlayerMove);
        dest[i++] = source.pfnNumberOfEntities == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnNumberOfEntities);
        dest[i++] = source.pfnGetInfoKeyBuffer == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnGetInfoKeyBuffer);
        dest[i++] = source.pfnInfoKeyValue == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnInfoKeyValue);
        dest[i++] = source.pfnSetKeyValue == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnSetKeyValue);
        dest[i++] = source.pfnSetClientKeyValue == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnSetClientKeyValue);
        dest[i++] = source.pfnIsMapValid == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnIsMapValid);
        dest[i++] = source.pfnStaticDecal == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnStaticDecal);
        dest[i++] = source.pfnPrecacheGeneric == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnPrecacheGeneric);
        dest[i++] = source.pfnGetPlayerUserId == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnGetPlayerUserId);
        dest[i++] = source.pfnBuildSoundMsg == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnBuildSoundMsg);
        dest[i++] = source.pfnIsDedicatedServer == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnIsDedicatedServer);
        dest[i++] = source.pfnCVarGetPointer == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnCVarGetPointer);
        dest[i++] = source.pfnGetPlayerWONId == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnGetPlayerWONId);
        dest[i++] = source.pfnInfo_RemoveKey == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnInfo_RemoveKey);
        dest[i++] = source.pfnGetPhysicsKeyValue == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnGetPhysicsKeyValue);
        dest[i++] = source.pfnSetPhysicsKeyValue == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnSetPhysicsKeyValue);
        dest[i++] = source.pfnGetPhysicsInfoString == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnGetPhysicsInfoString);
        dest[i++] = source.pfnPrecacheEvent == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnPrecacheEvent);
        dest[i++] = source.pfnPlaybackEvent == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnPlaybackEvent);
        dest[i++] = source.pfnSetFatPVS == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnSetFatPVS);
        dest[i++] = source.pfnSetFatPAS == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnSetFatPAS);
        dest[i++] = source.pfnCheckVisibility == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnCheckVisibility);
        dest[i++] = source.pfnDeltaSetField == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnDeltaSetField);
        dest[i++] = source.pfnDeltaUnsetField == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnDeltaUnsetField);
        dest[i++] = source.pfnDeltaAddEncoder == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnDeltaAddEncoder);
        dest[i++] = source.pfnGetCurrentPlayer == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnGetCurrentPlayer);
        dest[i++] = source.pfnCanSkipPlayer == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnCanSkipPlayer);
        dest[i++] = source.pfnDeltaFindField == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnDeltaFindField);
        dest[i++] = source.pfnDeltaSetFieldByIndex == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnDeltaSetFieldByIndex);
        dest[i++] = source.pfnDeltaUnsetFieldByIndex == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnDeltaUnsetFieldByIndex);
        dest[i++] = source.pfnSetGroupMask == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnSetGroupMask);
        dest[i++] = source.pfnCreateInstancedBaseline == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnCreateInstancedBaseline);
        dest[i++] = source.pfnCvar_DirectSet == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnCvar_DirectSet);
        dest[i++] = source.pfnForceUnmodified == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnForceUnmodified);
        dest[i++] = source.pfnGetPlayerStats == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnGetPlayerStats);
        dest[i++] = source.pfnAddServerCommand == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnAddServerCommand);
        dest[i++] = source.pfnVoice_GetClientListening == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnVoice_GetClientListening);
        dest[i++] = source.pfnVoice_SetClientListening == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnVoice_SetClientListening);
        dest[i++] = source.pfnGetPlayerAuthId == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnGetPlayerAuthId);
        dest[i++] = source.pfnSequenceGet == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnSequenceGet);
        dest[i++] = source.pfnSequencePickSentence == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnSequencePickSentence);
        dest[i++] = source.pfnGetFileSize == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnGetFileSize);
        dest[i++] = source.pfnGetApproxWavePlayLen == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnGetApproxWavePlayLen);
        dest[i++] = source.pfnIsCareerMatch == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnIsCareerMatch);
        dest[i++] = source.pfnGetLocalizedStringLength == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnGetLocalizedStringLength);
        dest[i++] = source.pfnRegisterTutorMessageShown == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnRegisterTutorMessageShown);
        dest[i++] = source.pfnGetTimesTutorMessageShown == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnGetTimesTutorMessageShown);
        dest[i++] = source.pfnProcessTutorMessageDecayBuffer == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnProcessTutorMessageDecayBuffer);
        dest[i++] = source.pfnConstructTutorMessageDecayBuffer == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnConstructTutorMessageDecayBuffer);
        dest[i++] = source.pfnResetTutorMessageDecayData == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnResetTutorMessageDecayData);
        dest[i++] = source.pfnQueryClientCvarValue == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnQueryClientCvarValue);
        dest[i++] = source.pfnQueryClientCvarValue2 == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnQueryClientCvarValue2);
        dest[i++] = source.pfnEngCheckParm == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnEngCheckParm);
    }
    private static unsafe void LinkNativeBlendEvents(nint pFunctionTable, NativeServerBlendInterface source)
    {
        if (pFunctionTable == 0)
            throw new ArgumentNullException(nameof(pFunctionTable), "pFunctionTable is NULL in LinkNativeBlendEvents.");
        IntPtr* dest = (IntPtr*)pFunctionTable;
        int i = 0;
        dest[i++] = source.version;
        dest[i++] = source.pfnSV_StudioSetupBones == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(source.pfnSV_StudioSetupBones);
    }

    internal static NativeGetEntityApiDelegate GetEntityApiWrapper = (pFunctionTable, interfaceVersion) =>
    {
        int res = 0;
        unsafe
        {
            if (_entityApi == null)
                throw new NullReferenceException("DLLEvents instance is null in GetEntityApiWrapper.");
            EntityAPINativeCaller._dllEvents = _entityApi;
            LinkNativeDLLEvents(pFunctionTable, EntityAPINativeCaller.GetDLLFunctionsNative());
            res = 1;
        }
        return res;
    };
    internal static NativeGetEntityApiDelegate GetEntityApiPostWrapper = (pFunctionTable, interfaceVersion) =>
    {
        int res = 0;
        unsafe
        {
            if (_entityApi_Post == null)
                throw new NullReferenceException("DLLEvents instance is null in GetEntityApiPostWrapper.");
            EntityAPIPostNativeCaller._dllEvents = _entityApi_Post;
            LinkNativeDLLEvents(pFunctionTable, EntityAPIPostNativeCaller.GetDLLFunctionsNative());
            res = 1;
        }
        return res;
    };
    internal static NativeGetEntityApi2Delegate GetEntityApi2Wrapper = (pFunctionTable, interfaceVersion) =>
    {
        int res = 0;
        unsafe
        {
            if (_entityApi2 == null)
                throw new NullReferenceException("DLLEvents instance is null in GetEntityApi2Wrapper.");
            EntityAPI2NativeCaller._dllEvents = _entityApi2;
            LinkNativeDLLEvents(pFunctionTable, EntityAPI2NativeCaller.GetDLLFunctionsNative());
            res = 1;
        }
        return res;
    };
    internal static NativeGetEntityApi2Delegate GetEntityApi2PostWrapper = (pFunctionTable, interfaceVersion) =>
    {
        int res = 0;
        unsafe
        {
            if (_entityApi2_Post == null)
                throw new NullReferenceException("DLLEvents instance is null in GetEntityApi2PostWrapper.");
            EntityAPI2PostNativeCaller._dllEvents = _entityApi2_Post;
            LinkNativeDLLEvents(pFunctionTable, EntityAPI2PostNativeCaller.GetDLLFunctionsNative());
            res = 1;
        }
        return res;
    };
    internal static NativeGetNewDllFunctionsDelegate GetNewDllFunctionsWrapper = (pFunctionTable, interfaceVersion) =>
    {
        int res = 0;
        unsafe
        {
            if (_newDllFunctions == null)
                throw new NullReferenceException("NewDLLEvents instance is null in GetNewDllFunctionsWrapper.");
            NewDLLFunctionsNativeCaller._newEvents = _newDllFunctions;
            LinkNativeNewDLLEvents(pFunctionTable, NewDLLFunctionsNativeCaller.GetNewDLLFunctionsNative());
            res = 1;
        }
        return res;
    };
    internal static NativeGetNewDllFunctionsDelegate GetNewDllFunctions_PostWrapper = (pFunctionTable, interfaceVersion) =>
    {
        int res = 0;
        unsafe
        {
            if (_newDLLFunctions_Post == null)
                throw new NullReferenceException("NewDLLEvents instance is null in GetNewDllFunctions_PostWrapper.");
            NewDLLFunctionsPostNativeCaller._newEvents = _newDLLFunctions_Post;
            LinkNativeNewDLLEvents(pFunctionTable, NewDLLFunctionsPostNativeCaller.GetNewDLLFunctionsNative());
            res = 1;
        }
        return res;
    };
    internal static NativeGetEngineFunctionsDelegate GetEngineFunctions = (pFunctionTable, interfaceVersion) =>
    {
        int res = 0;
        unsafe
        {
            if (_engineFunctions == null)
                throw new NullReferenceException("EngineEvents instance is null in GetEngineFunctions.");
            EngineNativeCaller._engineEvents = _engineFunctions;
            LinkNativeEngineEvents(pFunctionTable, EngineNativeCaller.GetEngineFunctionsNative());
            res = 1;
        }
        return res;
    };
    internal static NativeGetEngineFunctionsDelegate GetEngineFunctions_Post = (pFunctionTable, interfaceVersion) =>
    {
        int res = 0;
        unsafe
        {
            if (_engineFunctions_Post == null)
                throw new NullReferenceException("EngineEvents instance is null in GetEngineFunctions_Post.");
            EnginePostNativeCaller._engineEvents = _engineFunctions_Post;
            LinkNativeEngineEvents(pFunctionTable, EnginePostNativeCaller.GetEngineFunctionsNative());
            res = 1;
        }
        return res;
    };
    internal static NativeGetStudioBlendingInterfaceDelegate GetBlendingInterfaceDelegate = (pFunctionTable, interfaceVersion) =>
    {
        int res = 0;
        unsafe
        {
            if (_blendingInterface == null)
                throw new NullReferenceException("BlendingEvent instance is null in GetStudioBlendingInterface.");
            BlendingInterfaceNativeCaller._Events = _blendingInterface;
            LinkNativeBlendEvents(pFunctionTable, BlendingInterfaceNativeCaller.GetBlendingInterfaceNative());
            res = 1;
        }
        return res;
    };
    internal static NativeGetStudioBlendingInterfaceDelegate GetBlendingInterface_PostDelegate = (pFunctionTable, interfaceVersion) =>
    {
        int res = 0;
        unsafe
        {
            if (_blendingInterface_Post == null)
                throw new NullReferenceException("BlendingEvent instance is null in GetStudioBlendingInterface_Post.");
            BlendingInterfacePostNativeCaller._Events = _blendingInterface_Post;
            LinkNativeBlendEvents(pFunctionTable, BlendingInterfacePostNativeCaller.GetBlendingInterfaceNative());
            res = 1;
        }
        return res;
    };


    internal static NativeMetaFuncs? _native = null;

    internal static NativeMetaFuncs GetNative()
    {
        _native ??= new()
        {
            pfnGetEntityAPI = _entityApi == null ? null : GetEntityApiWrapper,
            pfnGetEntityAPI_Post = _entityApi_Post == null ? null : GetEntityApiPostWrapper,
            pfnGetEntityAPI2 = _entityApi2 == null ? null : GetEntityApi2Wrapper,
            pfnGetEntityAPI2_Post = _entityApi2_Post == null ? null : GetEntityApi2PostWrapper,
            pfnGetNewDLLFunctions = _newDllFunctions == null ? null : GetNewDllFunctionsWrapper,
            pfnGetNewDLLFunctions_Post = _newDLLFunctions_Post == null ? null : GetNewDllFunctions_PostWrapper,
            pfnGetEngineFunctions = _engineFunctions == null ? null : GetEngineFunctions,
            pfnGetEngineFunctions_Post = _engineFunctions_Post == null ? null : GetEngineFunctions_Post,
            pfnGetStudioBlendingInterface = _blendingInterface == null ? null : GetBlendingInterfaceDelegate,
            pfnGetStudioBlendingInterface_Post = _blendingInterface_Post == null ? null : GetBlendingInterface_PostDelegate
        };
        return (NativeMetaFuncs)_native;
    }
    #endregion

    #region 对外函数
    /// <summary>
    /// 统一注册事件接口
    /// </summary>
    /// <param name="entityApi">实体API事件</param>
    /// <param name="entityApiPost">实体API后置事件</param>
    /// <param name="entityApi2">实体API2事件</param>
    /// <param name="entityApi2Post">实体API2后置事件</param>
    /// <param name="newDllFunctions">新DLL函数事件</param>
    /// <param name="newDllFunctionsPost">新DLL函数后置事件</param>
    /// <param name="engineFunctions">引擎函数事件</param>
    /// <param name="engineFunctionsPost">引擎函数后置事件</param>
    /// <param name="blendingInterface">混合接口事件</param>
    /// <param name="blendingInterfacePost">混合接口后置事件</param>
    public static void RegisterEvents(
        DLLEvents? entityApi = null,
        DLLEvents? entityApiPost = null,
        DLLEvents? entityApi2 = null,
        DLLEvents? entityApi2Post = null,
        NewDLLEvents? newDllFunctions = null,
        NewDLLEvents? newDllFunctionsPost = null,
        EngineEvents? engineFunctions = null,
        EngineEvents? engineFunctionsPost = null,
        BlendingInterfaceEvent? blendingInterface = null,
        BlendingInterfaceEvent? blendingInterfacePost = null)
    {
        _entityApi = entityApi;
        _entityApi_Post = entityApiPost;
        _entityApi2 = entityApi2;
        _entityApi2_Post = entityApi2Post;
        _newDllFunctions = newDllFunctions;
        _newDLLFunctions_Post = newDllFunctionsPost;
        _engineFunctions = engineFunctions;
        _engineFunctions_Post = engineFunctionsPost;
        _blendingInterface = blendingInterface;
        _blendingInterface_Post = blendingInterfacePost;
    }
    #endregion

    #region 对外变量
    public static EngineFuncs EngineFuncs => _engineFuncs ?? throw new NullReferenceException("EngineFuncs is NULL");
    public static GlobalVars GlobalVars => _globalVars ?? throw new NullReferenceException("GlobalVars is NULL");
    public static Utility Utility => _utility ?? throw new NullReferenceException("Utility is NULL");
    public static MetaUtilFuncs MetaUtilFuncs => _metaUtilFuncs ?? throw new NullReferenceException("MetaUtilFuncs is NULL");
    public static PluginInfo PluginInfo => _pluginInfo ?? throw new NullReferenceException("PluginInfo is NULL");
    public static MetaGlobals MetaGlobals => _metaGlobals ?? throw new NullReferenceException("MetaGlobals is NULL");
    public static GameDllFuncs GameDllFuncs => _gameDllFuncs ?? throw new NullReferenceException("GameDllFuncs is NULL");

    internal static EngineFuncs? _engineFuncs;
    internal static GlobalVars? _globalVars;
    internal static Utility? _utility;
    internal static MetaUtilFuncs? _metaUtilFuncs;
    internal static PluginInfo? _pluginInfo;
    internal static MetaGlobals? _metaGlobals;
    internal static GameDllFuncs? _gameDllFuncs;
    #endregion
}