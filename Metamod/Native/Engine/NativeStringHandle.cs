using System.Runtime.InteropServices;

namespace Metamod.Native.Engine;

[StructLayout(LayoutKind.Sequential)]
public struct string_t
{
    internal int value;
}
