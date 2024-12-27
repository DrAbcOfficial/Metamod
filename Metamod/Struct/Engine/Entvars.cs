using System.Runtime.InteropServices;

namespace Metamod.Struct.Engine;

[StructLayout(LayoutKind.Sequential)]
public struct Entvars
{
    public string_t classname;
    public string_t globalname;

    public vec3_t origin;
    public vec3_t oldorigin;
    public vec3_t velocity;
    public vec3_t basevelocity;
    public vec3_t clbasevelocity;  // Base velocity that was passed in to server physics so 
                                   //  client can predict conveyors correctly.  Server zeroes it, so we need to store here, too.
    public vec3_t movedir;

    public vec3_t angles;          // Model angles
    public vec3_t avelocity;       // angle velocity (degrees per second)
    public vec3_t punchangle;      // auto-decaying view angle adjustment
    public vec3_t v_angle;     // Viewing angle (player only)

    // For parametric entities
    public vec3_t endpos;
    public vec3_t startpos;
    public float impacttime;
    public float starttime;

    public int fixangle;       // 0:nothing, 1:force view angles, 2:add avelocity
    public float idealpitch;
    public float pitch_speed;
    public float ideal_yaw;
    public float yaw_speed;

    public int modelindex;
    public string_t model;

    public int viewmodel;      // player's viewmodel
    public int weaponmodel;    // what other players see

    public vec3_t absmin;      // BB max translated to world coord
    public vec3_t absmax;      // BB max translated to world coord
    public vec3_t mins;        // local BB min
    public vec3_t maxs;        // local BB max
    public vec3_t size;        // maxs - mins

    public float ltime;
    public float nextthink;

    int movetype;
    int solid;

    public int skin;
    public int body;           // sub-model selection for studiomodels
    public int effects;

    public float gravity;      // % of "normal" gravity
    public float friction;     // inverse elasticity of MOVETYPE_BOUNCE

    public int light_level;

    public int sequence;       // animation sequence
    public int gaitsequence;   // movement animation sequence for player (0 for none)
    public float frame;            // % playback position in animation sequences (0..255)
    public float animtime;     // world time when frame was set
    public float framerate;        // animation playback rate (-8x to 8x)
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] controller; // bone controller setting (0..255)
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] blending;   // blending amount between sub-sequences (0..255)

    public float scale;            // sprite rendering scale (0..255)

    public int rendermode;
    public float renderamt;
    public vec3_t rendercolor;
    public int renderfx;

    public float health;
    public float frags;
    public int weapons;  // bit mask for available weapons
    public float takedamage;

    public int deadflag;
    public vec3_t view_ofs;    // eye position

    public int button;
    public int impulse;

    internal nint _raw_chain;         // Entity pointer when linked into a linked list
    internal nint _raw_dmg_inflictor;
    internal nint _raw_enemy;
    internal nint _raw_aiment;        // entity pointer when MOVETYPE_FOLLOW
    internal nint _raw_owner;
    internal nint _raw_groundentity;

    public int spawnflags;
    public int flags;

    public int colormap;       // lowbyte topcolor, highbyte bottomcolor
    public int team;

    public float max_health;
    public float teleport_time;
    public float armortype;
    public float armorvalue;
    public int waterlevel;
    public int watertype;

    public string_t target;
    public string_t targetname;
    public string_t netname;
    public string_t message;

    public float dmg_take;
    public float dmg_save;
    public float dmg;
    public float dmgtime;

    public string_t noise;
    public string_t noise1;
    public string_t noise2;
    public string_t noise3;

    public float speed;
    public float air_finished;
    public float pain_finished;
    public float radsuit_finished;

    internal nint _raw_pContainingEntity;

    public int playerclass;
    public float maxspeed;

    public float fov;
    public int weaponanim;

    public int pushmsec;

    public int bInDuck;
    public int flTimeStepSound;
    public int flSwimTime;
    public int flDuckTime;
    public int iStepLeft;
    public float flFallVelocity;

    public int gamestate;

    public int oldbuttons;

    public int groupinfo;

    // For mods
    public int iuser1;
    public int iuser2;
    public int iuser3;
    public int iuser4;
    public float fuser1;
    public float fuser2;
    public float fuser3;
    public float fuser4;
    public vec3_t vuser1;
    public vec3_t vuser2;
    public vec3_t vuser3;
    public vec3_t vuser4;
    internal nint _raw_euser1;
    internal nint _raw_euser2;
    internal nint _raw_euser3;
    internal nint _raw_euser4;

    public Edict chain
    {
        get
        {
            return Marshal.PtrToStructure<Edict>(_raw_chain);
        }
        set
        {
            Marshal.StructureToPtr<Edict>(value, _raw_chain, false);
        }
    }// Entity pointer when linked into a linked list
    public Edict dmg_inflictor
    {
        get
        {
            return Marshal.PtrToStructure<Edict>(_raw_dmg_inflictor);
        }
        set
        {
            Marshal.StructureToPtr<Edict>(value, _raw_dmg_inflictor, false);
        }
    }
    public Edict enemy
    {
        get
        {
            return Marshal.PtrToStructure<Edict>(_raw_enemy);
        }
        set
        {
            Marshal.StructureToPtr<Edict>(value, _raw_enemy, false);
        }
    }
    public Edict aiment
    {
        get
        {
            return Marshal.PtrToStructure<Edict>(_raw_aiment);
        }
        set
        {
            Marshal.StructureToPtr<Edict>(value, _raw_aiment, false);
        }
    }       // entity pointer when MOVETYPE_FOLLOW
    public Edict owner
    {
        get
        {
            return Marshal.PtrToStructure<Edict>(_raw_owner);
        }
        set
        {
            Marshal.StructureToPtr<Edict>(value, _raw_owner, false);
        }
    }
    public Edict groundentity
    {
        get
        {
            return Marshal.PtrToStructure<Edict>(_raw_groundentity);
        }
        set
        {
            Marshal.StructureToPtr<Edict>(value, _raw_groundentity, false);
        }
    }
    public Edict pContainingEntity
    {
        get
        {
            return Marshal.PtrToStructure<Edict>(_raw_pContainingEntity);
        }
        set
        {
            Marshal.StructureToPtr<Edict>(value, _raw_pContainingEntity, false);
        }
    }
    public Edict euser1
    {
        get
        {
            return Marshal.PtrToStructure<Edict>(_raw_euser1);
        }
        set
        {
            Marshal.StructureToPtr<Edict>(value, _raw_euser1, false);
        }
    }
    public Edict euser2
    {
        get
        {
            return Marshal.PtrToStructure<Edict>(_raw_euser2);
        }
        set
        {
            Marshal.StructureToPtr<Edict>(value, _raw_euser2, false);
        }
    }
    public Edict euser3
    {
        get
        {
            return Marshal.PtrToStructure<Edict>(_raw_euser3);
        }
        set
        {
            Marshal.StructureToPtr<Edict>(value, _raw_euser3, false);
        }
    }
    public Edict euser4
    {
        get
        {
            return Marshal.PtrToStructure<Edict>(_raw_euser4);
        }
        set
        {
            Marshal.StructureToPtr<Edict>(value, _raw_euser4, false);
        }
    }
};
