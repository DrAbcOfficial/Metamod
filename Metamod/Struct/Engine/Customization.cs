using Metamod.Enum.Metamod;
using Metamod.Native.Engine;
using System.Runtime.InteropServices;

namespace Metamod.Struct.Engine;

public class Customization : BaseManaged<NativeCustomization>
{
    public bool InUse
    {
        get => _native.bInUse == QBoolean.TRUE;
        set => _native.bInUse = value ? QBoolean.TRUE : QBoolean.FALSE;
    }

    private Resource _resource = new();
    public Resource Resource
    {
        get
        {
            _resource._native = _native.resource;
            return _resource;
        }
        set => _resource = value;
    }

    public bool Translated
    {
        get => _native.bTranslated == QBoolean.TRUE;
        set => _native.bTranslated = value ? QBoolean.TRUE : QBoolean.FALSE;
    }

    public int UserData1
    {
        get => _native.nUserData1;
        set => _native.nUserData1 = value;
    }

    public int UserData2
    {
        get => _native.nUserData2;
        set => _native.nUserData2 = value;
    }

    public nint Info
    {
        get => _native.pInfo;
        set => _native.pInfo = value;
    }

    public nint Buffer
    {
        get => _native.pBuffer;
        set => _native.pBuffer = value;
    }

    private Customization _next = new();
    public Customization Next
    {
        get
        {
            NativeCustomization next;
            unsafe
            {
                next = Marshal.PtrToStructure<NativeCustomization>((nint)_native.pNext);
            }
            _next._native = next;
            return _next;
        }
        set => _next = value;
    }
}