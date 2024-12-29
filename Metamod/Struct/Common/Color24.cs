using Metamod.Native.Common;

namespace Metamod.Struct.Common;

public class Color24 : BaseManaged<NativeColor24>
{
    public byte R
    {
        get => _native.r;
        set => _native.r = value;
    }

    public byte G
    {
        get => _native.g;
        set => _native.g = value;
    }

    public byte B
    {
        get => _native.b;
        set => _native.b = value;
    }

    public Color24(byte r, byte g, byte b)
    {
        _native = new NativeColor24 { r = r, g = g, b = b };
    }

    public Color24() : base(){ }
    public override string ToString()
    {
        return $"R: {R}, G: {G}, B: {B}";
    }
}