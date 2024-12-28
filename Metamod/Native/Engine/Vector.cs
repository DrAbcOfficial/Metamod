using System.Runtime.InteropServices;

namespace Metamod.Native.Engine;

[StructLayout(LayoutKind.Sequential)]
internal struct vec3_t
{
    internal float x;
    internal float y;
    internal float z;
}
