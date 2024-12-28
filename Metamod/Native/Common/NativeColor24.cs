using System.Runtime.InteropServices;

namespace Metamod.Native.Common
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct NativeColor24
    {
        internal byte r;
        internal byte g;
        internal byte b;
    }
}
