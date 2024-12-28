using Metamod.Enum.Metamod;
using System.Runtime.InteropServices;

namespace Metamod.Native.Engine.PM;

[StructLayout(LayoutKind.Sequential)]
internal struct NativePMTrace
{
    internal QBoolean allsolid;        // if true, plane is not valid
    internal QBoolean startsolid;          // if true, the initial point was in a solid area
    internal QBoolean inopen, inwater;  // End point is in empty space or in water
    internal float fraction;       // time completed, 1.0 = didn't hit anything
    internal vec3_t endpos;            // final position
    internal NativePMPlane plane;              // surface normal at impact
    internal int ent;              // entity at impact
    internal vec3_t deltavelocity;    // Change in player's velocity caused by impact.  
                                      // Only run on server.
    internal int hitgroup;
}
