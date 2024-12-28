using Metamod.Enum.Common;
using System.Runtime.InteropServices;

namespace Metamod.Native.Common;

[StructLayout(LayoutKind.Sequential)]
internal struct NativeNetAdr
{
    internal NetAdrType type;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    internal byte[] ip;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
    internal byte[] ipx;
    internal ushort port;
}
