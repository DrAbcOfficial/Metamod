using System.Runtime.InteropServices;

namespace Metamod.Native.Common;

[StructLayout(LayoutKind.Sequential)]
public struct NativeVector3f : INativeStruct
{
    internal unsafe float* startpos;
}
