using Metamod.Native.Common;

namespace Metamod.Wrapper.Common;

public class Color24 : BaseNativeWrapper<NativeColor24>
{
    public byte R
    {
        get
        {
            unsafe
            {
                return NativePtr->r;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->r = value;
            }
        }
    }

    public byte G
    {
        get
        {
            unsafe
            {
                return NativePtr->g;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->g = value;
            }
        }
    }

    public byte B
    {
        get
        {
            unsafe
            {
                return NativePtr->b;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->b = value;
            }
        }
    }

    public Color24(byte r, byte g, byte b) : base()
    {
        R = r;
        G = g;
        B = b;
    }

    public Color24() : base() { }

    internal unsafe Color24(NativeColor24* ptr) : base(ptr) { }
}
