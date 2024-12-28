using Metamod.Native.Common;

namespace Metamod.Struct.Common;

public class UserCmd
{
    internal NativeUserCmd nativeUserCmd;

    public short LerpMsec
    {
        get => nativeUserCmd.lerp_msec;
        set => nativeUserCmd.lerp_msec = value;
    }

    public byte Msec
    {
        get => nativeUserCmd.msec;
        set => nativeUserCmd.msec = value;
    }

    private Vector3f _viewAngles = new();
    public Vector3f ViewAngles
    {
        get
        {
            _viewAngles.X = nativeUserCmd.viewangles.x;
            _viewAngles.Y = nativeUserCmd.viewangles.y;
            _viewAngles.Z = nativeUserCmd.viewangles.z;
            return _viewAngles;
        }
        set
        {
            nativeUserCmd.viewangles.x = value.X;
            nativeUserCmd.viewangles.y = value.Y;
            nativeUserCmd.viewangles.z = value.Z;
        }
    }

    public float ForwardMove
    {
        get => nativeUserCmd.forwardmove;
        set => nativeUserCmd.forwardmove = value;
    }

    public float SideMove
    {
        get => nativeUserCmd.sidemove;
        set => nativeUserCmd.sidemove = value;
    }

    public float UpMove
    {
        get => nativeUserCmd.upmove;
        set => nativeUserCmd.upmove = value;
    }

    public byte LightLevel
    {
        get => nativeUserCmd.lightlevel;
        set => nativeUserCmd.lightlevel = value;
    }

    public ushort Buttons
    {
        get => nativeUserCmd.buttons;
        set => nativeUserCmd.buttons = value;
    }

    public byte Impulse
    {
        get => nativeUserCmd.impulse;
        set => nativeUserCmd.impulse = value;
    }

    public byte WeaponSelect
    {
        get => nativeUserCmd.weaponselect;
        set => nativeUserCmd.weaponselect = value;
    }

    public int ImpactIndex
    {
        get => nativeUserCmd.impact_index;
        set => nativeUserCmd.impact_index = value;
    }

    private Vector3f _impactPosition = new();
    public Vector3f ImpactPosition
    {
        get
        {
            _impactPosition.X = nativeUserCmd.impact_position.x;
            _impactPosition.Y = nativeUserCmd.impact_position.y;
            _impactPosition.Z = nativeUserCmd.impact_position.z;
            return _impactPosition;
        }
        set
        {
            nativeUserCmd.impact_position.x = value.X;
            nativeUserCmd.impact_position.y = value.Y;
            nativeUserCmd.impact_position.z = value.Z;
        }
    }

    public override string ToString()
    {
        return $"LerpMsec: {LerpMsec}, Msec: {Msec}, ViewAngles: {ViewAngles}, ForwardMove: {ForwardMove}, SideMove: {SideMove}, UpMove: {UpMove}";
    }
}
