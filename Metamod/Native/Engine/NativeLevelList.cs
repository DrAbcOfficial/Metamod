using Metamod.Native.Common;
using System.Runtime.InteropServices;

namespace Metamod.Native.Engine;

[StructLayout(LayoutKind.Sequential)]
#pragma warning disable CS8500 // 这会获取托管类型的地址、获取其大小或声明指向它的指针
internal unsafe struct NativeLevelList
{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    byte[] mapName;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    byte[] landmarkName;
    NativeEdict* pentLandmark;
    NativeVector3f vecLandmarkOrigin;
}
#pragma warning restore CS8500 // 这会获取托管类型的地址、获取其大小或声明指向它的指针