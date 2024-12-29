using Metamod.Enum.Engine;
using Metamod.Native.Engine;
using System.Runtime.InteropServices;

namespace Metamod.Struct.Engine;

public class Resource : BaseManaged<NativeResource>
{
    public string FileName
    {
        get => System.Text.Encoding.UTF8.GetString(_native.szFileName).TrimEnd('\0');
        set => _native.szFileName = System.Text.Encoding.UTF8.GetBytes(value.PadRight(64, '\0'));
    }

    public ResourceType Type
    {
        get => _native.type;
        set => _native.type = value;
    }

    public int Index
    {
        get => _native.nIndex;
        set => _native.nIndex = value;
    }

    public int DownloadSize
    {
        get => _native.nDownloadSize;
        set => _native.nDownloadSize = value;
    }

    public byte Flags
    {
        get => _native.ucFlags;
        set => _native.ucFlags = value;
    }

    public byte[] MD5Hash
    {
        get => _native.rgucMD5_hash;
        set => _native.rgucMD5_hash = value;
    }

    public byte PlayerNum
    {
        get => _native.playernum;
        set => _native.playernum = value;
    }

    public byte[] Reserved
    {
        get => _native.rguc_reserved;
        set => _native.rguc_reserved = value;
    }

    private Resource _next = new();
    public Resource Next
    {
        get
        {
            NativeResource resource;
            unsafe
            {
                resource = Marshal.PtrToStructure<NativeResource>((nint)_native.pNext);
            }
            _next._native = resource;
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
                resource = Marshal.PtrToStructure<NativeResource>((nint)_native.pPrev);
            }
            _prev._native = resource;
            return _prev;
        }
        set => _prev = value;
    }
}