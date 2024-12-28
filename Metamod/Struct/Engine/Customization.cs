using Metamod.Enum.Metamod;
using Metamod.Native.Engine;
using System.Runtime.InteropServices;

namespace Metamod.Struct.Engine;

public class Customization
{
    internal NativeCustomization nativeCustomization;

    public bool InUse
    {
        get => nativeCustomization.bInUse == QBoolean.TRUE;
        set => nativeCustomization.bInUse = value ? QBoolean.TRUE : QBoolean.FALSE;
    }

    private Resource _resource = new();
    public Resource Resource
    {
        get
        {
            _resource.nativeResource = nativeCustomization.resource;
            return _resource;
        }
        set => _resource = value;
    }

    public bool Translated
    {
        get => nativeCustomization.bTranslated == QBoolean.TRUE;
        set => nativeCustomization.bTranslated = value ? QBoolean.TRUE : QBoolean.FALSE;
    }

    public int UserData1
    {
        get => nativeCustomization.nUserData1;
        set => nativeCustomization.nUserData1 = value;
    }

    public int UserData2
    {
        get => nativeCustomization.nUserData2;
        set => nativeCustomization.nUserData2 = value;
    }

    public nint Info
    {
        get => nativeCustomization.pInfo;
        set => nativeCustomization.pInfo = value;
    }

    public nint Buffer
    {
        get => nativeCustomization.pBuffer;
        set => nativeCustomization.pBuffer = value;
    }

    private Customization _next = new();
    public Customization Next
    {
        get
        {
            NativeCustomization next;
            unsafe
            {
                next = Marshal.PtrToStructure<NativeCustomization>((nint)nativeCustomization.pNext);
            }
            _next.nativeCustomization = next;
            return _next;
        }
        set => _next = value;
    }
}