using System.Runtime.InteropServices;

namespace Metamod.Native.Engine;

[StructLayout(LayoutKind.Sequential)]
internal unsafe struct NativeLevelList
{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    byte[] mapName;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    byte[] landmarkName;
    NativeEdict* pentLandmark;
    vec3_t vecLandmarkOrigin;
}
