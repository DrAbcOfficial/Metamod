using Metamod.Native.Engine;
using System.Runtime.InteropServices;

namespace Metamod.Native.Common;

[StructLayout(LayoutKind.Sequential)]
internal struct NativeClientData
{
    internal vec3_t origin;
    internal vec3_t velocity;

    internal int viewmodel;
    internal vec3_t punchangle;
    internal int flags;
    internal int waterlevel;
    internal int watertype;
    internal vec3_t view_ofs;
    internal float health;

    internal int bInDuck;

    internal int weapons; // remove?

    internal int flTimeStepSound;
    internal int flDuckTime;
    internal int flSwimTime;
    internal int waterjumptime;

    internal float maxspeed;

    internal float fov;
    internal int weaponanim;

    internal int m_iId;
    internal int ammo_shells;
    internal int ammo_nails;
    internal int ammo_cells;
    internal int ammo_rockets;
    internal float m_flNextAttack;

    internal int tfstate;

    internal int pushmsec;

    internal int deadflag;

    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
    internal byte[] physinfo;

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
