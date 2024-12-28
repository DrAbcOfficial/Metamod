using System.Runtime.InteropServices;

namespace Metamod.Native.Engine.PM;

[StructLayout(LayoutKind.Sequential)]
internal struct NativePhySent
{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    internal byte[] name;             // Name of model, or "player" or "world".
    internal int player;
    internal vec3_t origin;               // Model's origin in world coordinates.
    internal nint model;               // only for bsp models
    internal nint studiomodel;         // SOLID_BBOX, but studio clip intersections.
    internal vec3_t mins, maxs;            // only for non-bsp models
    internal int info;                 // For client or server to use to identify (index into edicts or cl_entities)
    internal vec3_t angles;               // rotated entities need this info for hull testing to work.

    internal int solid;                // Triggers and func_door type WATER brushes are SOLID_NOT
    internal int skin;                 // BSP Contents for such things like fun_door water brushes.
    internal int rendermode;           // So we can ignore glass

    // Complex collision detection.
    internal float frame;
    internal int sequence;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    internal byte[] controller;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    internal byte[] blending;

    internal int movetype;
    internal int takedamage;
    internal int blooddecal;
    internal int team;
    internal int classnumber;

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
