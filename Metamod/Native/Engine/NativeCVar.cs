using System.Runtime.InteropServices;

namespace Metamod.Native.Engine;

[StructLayout(LayoutKind.Sequential)]
public struct NativeCVar
{
    internal nint name;
    internal nint str;
    internal int flags;
    internal float value;
    internal nint next;
}
