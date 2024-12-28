using Metamod.Native.Common;

namespace Metamod.Struct.Common;

public class Color24
{
    internal NativeColor24 nativeColor;

    public byte R
    {
        get => nativeColor.r;
        set => nativeColor.r = value;
    }

    public byte G
    {
        get => nativeColor.g;
        set => nativeColor.g = value;
    }

    public byte B
    {
        get => nativeColor.b;
        set => nativeColor.b = value;
    }

    public Color24(byte r, byte g, byte b)
    {
        nativeColor = new NativeColor24 { r = r, g = g, b = b };
    }

    public override string ToString()
    {
        return $"R: {R}, G: {G}, B: {B}";
    }
}