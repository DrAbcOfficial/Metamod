using Metamod.Struct.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metamod.Struct.Game;

public class HudParams : BaseManaged<NativeHudParams>
{
    public float X
    {
        get => _native.x; 
        set => _native.x = value;
    }

    public float Y
    {
        get => _native.y;
        set => _native.y = value;
    }

    public int Effect
    {
        get => _native.effect;
        set => _native.effect = value;
    }

    public byte R1
    {
        get => _native.r1;
        set => _native.r1 = value;
    }

    public byte G1
    {
        get => _native.g1;
        set => _native.g1 = value;
    }

    public byte B1
    {
        get => _native.b1;
        set => _native.b1 = value;
    }

    public byte A1
    {
        get => _native.a1;
        set => _native.a1 = value;
    }

    public byte R2
    {
        get => _native.r2;
        set => _native.r2 = value;
    }

    public byte G2
    {
        get => _native.g2;
        set => _native.g2 = value;
    }

    public byte B2
    {
        get => _native.b2;
        set => _native.b2 = value;
    }

    public byte A2
    {
        get => _native.a2;
        set => _native.a2 = value;
    }
    
    public float FadeinTime
    {
        get => _native.fadeinTime;
        set => _native.fadeinTime = value;
    }

    public float FadeoutTime
    {
        get => _native.fadeoutTime;
        set => _native.fadeoutTime = value;
    }

    public float HoldTime
    {
        get => _native.holdTime;
        set => _native.holdTime = value;
    }

    public float FxTime
    {
        get => _native.fxTime;
        set => _native.fxTime = value;
    }

    public int Channel
    {
        get => _native.channel;
        set => _native.channel = value;
    }
}
