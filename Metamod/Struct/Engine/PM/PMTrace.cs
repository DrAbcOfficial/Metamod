using Metamod.Enum.Metamod;
using Metamod.Native.Engine.PM;
using Metamod.Struct.Common;

namespace Metamod.Struct.Engine.PM;

public class PMTrace : BaseManaged<NativePMTrace>
{
    public bool AllSolid
    {
        get => _native.allsolid == QBoolean.TRUE;
        set => _native.allsolid = value ? QBoolean.TRUE : QBoolean.FALSE;
    }

    public bool StartSolid
    {
        get => _native.startsolid == QBoolean.TRUE;
        set => _native.startsolid = value ? QBoolean.TRUE : QBoolean.FALSE;
    }

    public bool InOpen
    {
        get => _native.inopen == QBoolean.TRUE;
        set => _native.inopen = value ? QBoolean.TRUE : QBoolean.FALSE;
    }

    public bool InWater
    {
        get => _native.inwater == QBoolean.TRUE;
        set => _native.inwater = value ? QBoolean.TRUE : QBoolean.FALSE;
    }

    public float Fraction
    {
        get => _native.fraction;
        set => _native.fraction = value;
    }

    private Vector3f? _endpos;
    public Vector3f EndPos
    {
        get
        {
            _endpos ??= new Vector3f(_native.endpos);
            return _endpos;
        }
        set
        {
            _endpos ??= new Vector3f(_native.endpos);
            _endpos.X = value.X;
            _endpos.Y = value.Y;
            _endpos.Z = value.Z;
        }
    }

    private PMPlane _plane = new();
    public PMPlane Plane
    {
        get
        {
            _plane._native = _native.plane;
            return _plane;
        }
        set
        {
            _plane = value;
            _native.plane = value._native;
        }
    }

    public int Ent
    {
        get => _native.ent;
        set => _native.ent = value;
    }

    private Vector3f? _deltavelocity;
    public Vector3f DeltaVelocity
    {
        get
        {
            _deltavelocity ??= new Vector3f(_native.deltavelocity);
            return _deltavelocity;
        }
        set
        {
            _deltavelocity ??= new Vector3f(_native.deltavelocity);
            _deltavelocity.X = value.X;
            _deltavelocity.Y = value.Y;
            _deltavelocity.Z = value.Z;
        }
    }

    public int HitGroup
    {
        get => _native.hitgroup;
        set => _native.hitgroup = value;
    }

    public override string ToString()
    {
        return $"AllSolid: {AllSolid}, StartSolid: {StartSolid}, EndPos: {EndPos}, Fraction: {Fraction}, Ent: {Ent}, HitGroup: {HitGroup}";
    }
}
