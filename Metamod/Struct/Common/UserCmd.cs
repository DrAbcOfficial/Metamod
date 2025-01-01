using Metamod.Native.Common;

namespace Metamod.Struct.Common;

public class UserCmd(nint ptr) : BaseManaged<NativeUserCmd>(ptr)
{
    public short LerpMsec
    {
        get => _native.lerp_msec;
        set => _native.lerp_msec = value;
    }

    public byte Msec
    {
        get => _native.msec;
        set => _native.msec = value;
    }

    private Vector3f? _viewangles;
    public Vector3f ViewAngles
    {
        get
        {
            _viewangles ??= new Vector3f(_native.viewangles);
            return _viewangles;
        }
        set
        {
            _viewangles ??= new Vector3f(_native.viewangles);
            _viewangles.X = value.X;
            _viewangles.Y = value.Y;
            _viewangles.Z = value.Z;
        }
    }

    public float ForwardMove
    {
        get => _native.forwardmove;
        set => _native.forwardmove = value;
    }

    public float SideMove
    {
        get => _native.sidemove;
        set => _native.sidemove = value;
    }

    public float UpMove
    {
        get => _native.upmove;
        set => _native.upmove = value;
    }

    public byte LightLevel
    {
        get => _native.lightlevel;
        set => _native.lightlevel = value;
    }

    public ushort Buttons
    {
        get => _native.buttons;
        set => _native.buttons = value;
    }

    public byte Impulse
    {
        get => _native.impulse;
        set => _native.impulse = value;
    }

    public byte WeaponSelect
    {
        get => _native.weaponselect;
        set => _native.weaponselect = value;
    }

    public int ImpactIndex
    {
        get => _native.impact_index;
        set => _native.impact_index = value;
    }

    private Vector3f? _impact_position;
    public Vector3f ImpactPosition
    {
        get
        {
            _impact_position ??= new Vector3f(_native.impact_position);
            return _impact_position;
        }
        set
        {
            _impact_position ??= new Vector3f(_native.impact_position);
            _impact_position.X = value.X;
            _impact_position.Y = value.Y;
            _impact_position.Z = value.Z;
        }
    }

    public override string ToString()
    {
        return $"LerpMsec: {LerpMsec}, Msec: {Msec}, ViewAngles: {ViewAngles}, ForwardMove: {ForwardMove}, SideMove: {SideMove}, UpMove: {UpMove}";
    }
}
