using Metamod.Enum.Metamod;
using Metamod.Native.Engine;
using System.Runtime.InteropServices;

namespace Metamod.Native.Common;

[StructLayout(LayoutKind.Sequential)]
internal struct NativeEntityState
{
    // Fields which are filled in by routines outside of delta compression
    internal int entityType;
    // Index into cl_entities array for this entity.
    internal int number;
    internal float msg_time;

    // Message number last time the player/entity state was updated.
    internal int messagenum;

    // Fields which can be transitted and reconstructed over the network stream
    internal vec3_t origin;
    internal vec3_t angles;

    internal int modelindex;
    internal int sequence;
    internal float frame;
    internal int colormap;
    internal short skin;
    internal short solid;
    internal int effects;
    internal float scale;

    internal byte eflags;

    // Render information
    internal int rendermode;
    internal int renderamt;
    internal Color24 rendercolor;
    internal int renderfx;

    internal int movetype;
    internal float animtime;
    internal float framerate;
    internal int body;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    internal byte[] controller;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    internal byte[]blending;
    internal vec3_t velocity;

    // Send bbox down to client for use during prediction.
    internal vec3_t mins;
    internal vec3_t maxs;

    internal int aiment;
    // If owned by a player, the index of that player ( for projectiles ).
    internal int owner;

    // Friction, for prediction.
    internal float friction;
    // Gravity multiplier
    internal float gravity;

    // PLAYER SPECIFIC
    internal int team;
    internal int playerclass;
    internal int health;
    internal QBoolean spectator;
    internal int weaponmodel;
    internal int gaitsequence;
    // If standing on conveyor, e.g.
    internal vec3_t basevelocity;
    // Use the crouched hull, or the regular player hull.
    internal int usehull;
    // Latched buttons last time state updated.
    internal int oldbuttons;
    // -1 = in air, else pmove entity number
    internal int onground;
    internal int iStepLeft;
    // How fast we are falling
    internal float flFallVelocity;

    internal float fov;
    internal int weaponanim;

    // Parametric movement overrides
    internal vec3_t startpos;
    internal vec3_t endpos;
    internal float impacttime;
    internal float starttime;

    // For mods
    internal int iuser1;
    internal int iuser2;
    internal int iuser3;
    internal int iuser4;
    internal float fuser1;
    internal float fuser2;
    internal float fuser3;
    internal float fuser4;
    internal vec3_t vuser1;
    internal vec3_t vuser2;
    internal vec3_t vuser3;
    internal vec3_t vuser4;
}
