using System.Runtime.InteropServices;

namespace Metamod.Struct.Engine;

[StructLayout(LayoutKind.Sequential)]
public struct vec3_t
{
    public float x;
    public float y;
    public float z;
}
