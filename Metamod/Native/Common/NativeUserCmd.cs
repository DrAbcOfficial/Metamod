using Metamod.Native.Engine;
using System.Runtime.InteropServices;

namespace Metamod.Native.Common;

[StructLayout(LayoutKind.Sequential)]
internal struct NativeUserCmd
{
    internal short lerp_msec;      // Interpolation time on client
    internal byte msec;           // Duration in ms of command
    internal vec3_t viewangles;     // Command view angles.

    // intended velocities
    internal float forwardmove;    // Forward velocity.
    internal float sidemove;       // Sideways velocity.
    internal float upmove;         // Upward velocity.
    internal byte lightlevel;     // Light level at spot where we are standing.
    internal ushort buttons;  // Attack buttons
    internal byte impulse;          // Impulse command issued.
    internal byte weaponselect;  // Current weapon id

    // Experimental player impact stuff.
    internal int impact_index;
    internal vec3_t impact_position;
}
