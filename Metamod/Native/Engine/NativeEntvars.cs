﻿using Metamod.Native.Common;
using System.Runtime.InteropServices;

namespace Metamod.Native.Engine;

#pragma warning disable CS8500 // 这会获取托管类型的地址、获取其大小或声明指向它的指针
[StructLayout(LayoutKind.Sequential)]
public unsafe struct NativeEntvars
{
    internal string_t classname;
    internal string_t globalname;

    internal NativeVector3f origin;
    internal NativeVector3f oldorigin;
    internal NativeVector3f velocity;
    internal NativeVector3f basevelocity;
    internal NativeVector3f clbasevelocity;  // Base velocity that was passed in to server physics so 
                                   //  client can predict conveyors correctly.  Server zeroes it, so we need to store here, too.
    internal NativeVector3f movedir;

    internal NativeVector3f angles;          // Model angles
    internal NativeVector3f avelocity;       // angle velocity (degrees per second)
    internal NativeVector3f punchangle;      // auto-decaying view angle adjustment
    internal NativeVector3f v_angle;     // Viewing angle (player only)

    // For parametric entities
    internal NativeVector3f endpos;
    internal NativeVector3f startpos;
    internal float impacttime;
    internal float starttime;

    internal int fixangle;       // 0:nothing, 1:force view angles, 2:add avelocity
    internal float idealpitch;
    internal float pitch_speed;
    internal float ideal_yaw;
    internal float yaw_speed;

    internal int modelindex;
    internal string_t model;

    internal int viewmodel;      // player's viewmodel
    internal int weaponmodel;    // what other players see

    internal NativeVector3f absmin;      // BB max translated to world coord
    internal NativeVector3f absmax;      // BB max translated to world coord
    internal NativeVector3f mins;        // local BB min
    internal NativeVector3f maxs;        // local BB max
    internal NativeVector3f size;        // maxs - mins

    internal float ltime;
    internal float nextthink;

    internal int movetype;
    internal int solid;

    internal int skin;
    internal int body;           // sub-model selection for studiomodels
    internal int effects;

    internal float gravity;      // % of "normal" gravity
    internal float friction;     // inverse elasticity of MOVETYPE_BOUNCE

    internal int light_level;

    internal int sequence;       // animation sequence
    internal int gaitsequence;   // movement animation sequence for player (0 for none)
    internal float frame;            // % playback position in animation sequences (0..255)
    internal float animtime;     // world time when frame was set
    internal float framerate;        // animation playback rate (-8x to 8x)
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    internal byte[] controller; // bone controller setting (0..255)
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    internal byte[] blending;   // blending amount between sub-sequences (0..255)

    internal float scale;            // sprite rendering scale (0..255)

    internal int rendermode;
    internal float renderamt;
    internal NativeVector3f rendercolor;
    internal int renderfx;

    internal float health;
    internal float frags;
    internal int weapons;  // bit mask for available weapons
    internal float takedamage;

    internal int deadflag;
    internal NativeVector3f view_ofs;    // eye position

    internal int button;
    internal int impulse;


    internal NativeEdict* chain;         // Entity pointer when linked into a linked list
    internal NativeEdict* dmg_inflictor;
    internal NativeEdict* enemy;
    internal NativeEdict* aiment;        // entity pointer when MOVETYPE_FOLLOW
    internal NativeEdict* owner;
    internal NativeEdict* groundentity;

    internal int spawnflags;
    internal int flags;

    internal int colormap;       // lowbyte topcolor, highbyte bottomcolor
    internal int team;

    internal float max_health;
    internal float teleport_time;
    internal float armortype;
    internal float armorvalue;
    internal int waterlevel;
    internal int watertype;

    internal string_t target;
    internal string_t targetname;
    internal string_t netname;
    internal string_t message;

    internal float dmg_take;
    internal float dmg_save;
    internal float dmg;
    internal float dmgtime;

    internal string_t noise;
    internal string_t noise1;
    internal string_t noise2;
    internal string_t noise3;

    internal float speed;
    internal float air_finished;
    internal float pain_finished;
    internal float radsuit_finished;

    internal NativeEdict* pContainingEntity;

    internal int playerclass;
    internal float maxspeed;

    internal float fov;
    internal int weaponanim;

    internal int pushmsec;

    internal int bInDuck;
    internal int flTimeStepSound;
    internal int flSwimTime;
    internal int flDuckTime;
    internal int iStepLeft;
    internal float flFallVelocity;

    internal int gamestate;

    internal int oldbuttons;

    internal int groupinfo;

    // For mods
    internal int iuser1;
    internal int iuser2;
    internal int iuser3;
    internal int iuser4;
    internal float fuser1;
    internal float fuser2;
    internal float fuser3;
    internal float fuser4;
    internal NativeVector3f vuser1;
    internal NativeVector3f vuser2;
    internal NativeVector3f vuser3;
    internal NativeVector3f vuser4;
    internal NativeEdict* euser1;
    internal NativeEdict* euser2;
    internal NativeEdict* euser3;
    internal NativeEdict* euser4;
};
#pragma warning restore CS8500 // 这会获取托管类型的地址、获取其大小或声明指向它的指针