using System.Runtime.InteropServices;

namespace Metamod.Native.Engine.PM;
[StructLayout(LayoutKind.Sequential)]
internal struct NativePMPlane
{
    internal vec3_t normal;
    internal float dist;
}
