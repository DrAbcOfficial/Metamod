﻿using System.Runtime.InteropServices;

namespace Metamod.Native.Engine;

[StructLayout(LayoutKind.Sequential)]
internal unsafe struct NativeGlobalVars
{
    internal float time;
    internal float frametime;
    internal float force_retouch;
    internal string_t mapname;
    internal string_t startspot;
    internal float deathmatch;
    internal float coop;
    internal float teamplay;
    internal float serverflags;
    internal float found_secrets;
    internal vec3_t v_forward;
    internal vec3_t v_up;
    internal vec3_t v_right;
    internal float trace_allsolid;
    internal float trace_startsolid;
    internal float trace_fraction;
    internal vec3_t trace_endpos;
    internal vec3_t trace_plane_normal;
    internal float trace_plane_dist;
#pragma warning disable CS8500 // 这会获取托管类型的地址、获取其大小或声明指向它的指针
    internal NativeEdict* trace_ent;
#pragma warning restore CS8500 // 这会获取托管类型的地址、获取其大小或声明指向它的指针
    internal float trace_inopen;
    internal float trace_inwater;
    internal int trace_hitgroup;
    internal int trace_flags;
    internal int msg_entity;
    internal int cdAudioTrack;
    internal int maxClients;
    internal int maxEntities;
    internal nint pStringBase;

    internal nint pSaveData;
    internal vec3_t vecLandmarkOffset;
}