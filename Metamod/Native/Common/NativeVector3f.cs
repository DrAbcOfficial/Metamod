using System.Runtime.InteropServices;

namespace Metamod.Native.Common;

[StructLayout(LayoutKind.Sequential)]
internal struct NativeVector3f
{
    internal float x;
    internal float y;
    internal float z;
}
