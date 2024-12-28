using Metamod.Enum.Engine;
using Metamod.Native.Engine;
using System.Runtime.InteropServices;

namespace Metamod.Struct.Engine;

public class Resource
{
    internal NativeResource nativeResource;

    public string FileName
    {
        get => System.Text.Encoding.UTF8.GetString(nativeResource.szFileName).TrimEnd('\0');
        set => nativeResource.szFileName = System.Text.Encoding.UTF8.GetBytes(value.PadRight(64, '\0'));
    }

    public ResourceType Type
    {
        get => nativeResource.type;
        set => nativeResource.type = value;
    }

    public int Index
    {
        get => nativeResource.nIndex;
        set => nativeResource.nIndex = value;
    }

    public int DownloadSize
    {
        get => nativeResource.nDownloadSize;
        set => nativeResource.nDownloadSize = value;
    }

    public byte Flags
    {
        get => nativeResource.ucFlags;
        set => nativeResource.ucFlags = value;
    }

    public byte[] MD5Hash
    {
        get => nativeResource.rgucMD5_hash;
        set => nativeResource.rgucMD5_hash = value;
    }

    public byte PlayerNum
    {
        get => nativeResource.playernum;
        set => nativeResource.playernum = value;
    }

    public byte[] Reserved
    {
        get => nativeResource.rguc_reserved;
        set => nativeResource.rguc_reserved = value;
    }

    private Resource _next = new();
    public Resource Next
    {
        get
        {
            NativeResource resource;
            unsafe
            {
                resource = Marshal.PtrToStructure<NativeResource>((nint)nativeResource.pNext);
            }
            _next.nativeResource = resource;
            return _next;
        }
        set => _next = value;
    }

    private Resource _prev = new();
    public Resource Prev
    {
        get
        {
            NativeResource resource;
            unsafe
            {
                resource = Marshal.PtrToStructure<NativeResource>((nint)nativeResource.pPrev);
            }
            _prev.nativeResource = resource;
            return _prev;
        }
        set => _prev = value;
    }
}