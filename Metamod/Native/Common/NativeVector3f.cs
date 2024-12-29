using System.Runtime.InteropServices;

namespace Metamod.Native.Common;

[StructLayout(LayoutKind.Sequential)]
public struct NativeVector3f
{
    internal unsafe float* startpos;
}
