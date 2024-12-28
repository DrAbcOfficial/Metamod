using System.Runtime.InteropServices;

namespace Metamod.Native.Game;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void SV_StudioSetupBonesDelegate(
       nint pModel,
       float frame,
       int sequence,
       nint angles,
       nint origin,
       nint pcontroller,
       nint pblending,
       int iBone,
       nint pEdict
   );

[StructLayout(LayoutKind.Sequential)]
internal struct NativeServerBlendInterface
{
    internal int version;
    internal SV_StudioSetupBonesDelegate SV_StudioSetupBones;
}
