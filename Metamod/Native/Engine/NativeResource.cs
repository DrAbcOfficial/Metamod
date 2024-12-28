using Metamod.Enum.Engine;
using System.Runtime.InteropServices;

namespace Metamod.Native.Engine;

[StructLayout(LayoutKind.Sequential)]
internal unsafe struct NativeResource
{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
    internal byte[] szFileName; // File name to download/precache.
    internal ResourceType type;                // t_sound, t_skin, t_model, t_decal.
    internal int nIndex;              // For t_decals
    internal int nDownloadSize;       // Size in Bytes if this must be downloaded.
    internal byte ucFlags;

    // For handling client to client resource propagation
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    byte[] rgucMD5_hash;    // To determine if we already have it.
    byte playernum;           // Which player index this resource is associated with, if it's a custom resource.

    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    byte[] rguc_reserved; // For future expansion
    NativeResource* pNext;              // Next in chain.
    NativeResource* pPrev;
}
