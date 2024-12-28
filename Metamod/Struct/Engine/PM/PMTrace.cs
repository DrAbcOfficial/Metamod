using Metamod.Enum.Metamod;
using Metamod.Native.Engine.PM;
using Metamod.Struct.Common;

namespace Metamod.Struct.Engine.PM;

public class PMTrace
{
    internal NativePMTrace nativePMTrace;

    public bool AllSolid
    {
        get => nativePMTrace.allsolid == QBoolean.TRUE;
        set => nativePMTrace.allsolid = value ? QBoolean.TRUE : QBoolean.FALSE;
    }

    public bool StartSolid
    {
        get => nativePMTrace.startsolid == QBoolean.TRUE;
        set => nativePMTrace.startsolid = value ? QBoolean.TRUE : QBoolean.FALSE;
    }

    public bool InOpen
    {
        get => nativePMTrace.inopen == QBoolean.TRUE;
        set => nativePMTrace.inopen = value ? QBoolean.TRUE : QBoolean.FALSE;
    }

    public bool InWater
    {
        get => nativePMTrace.inwater == QBoolean.TRUE;
        set => nativePMTrace.inwater = value ? QBoolean.TRUE : QBoolean.FALSE;
    }

    public float Fraction
    {
        get => nativePMTrace.fraction;
        set => nativePMTrace.fraction = value;
    }

    private Vector3f _endPos = new();
    public Vector3f EndPos
    {
        get
        {
            _endPos.X = nativePMTrace.endpos.x;
            _endPos.Y = nativePMTrace.endpos.y;
            _endPos.Z = nativePMTrace.endpos.z;
            return _endPos;
        }
        set
        {
            nativePMTrace.endpos.x = value.X;
            nativePMTrace.endpos.y = value.Y;
            nativePMTrace.endpos.z = value.Z;
        }
    }

    private PMPlane _plane = new();
    public PMPlane Plane
    {
        get
        {
            _plane.nativePMPlane = nativePMTrace.plane;
            return _plane;
        }
        set
        {
            nativePMTrace.plane = value.nativePMPlane;
        }
    }

    public int Ent
    {
        get => nativePMTrace.ent;
        set => nativePMTrace.ent = value;
    }

    private Vector3f _deltaVelocity = new();
    public Vector3f DeltaVelocity
    {
        get
        {
            _deltaVelocity.X = nativePMTrace.deltavelocity.x;
            _deltaVelocity.Y = nativePMTrace.deltavelocity.y;
            _deltaVelocity.Z = nativePMTrace.deltavelocity.z;
            return _deltaVelocity;
        }
        set
        {
            nativePMTrace.deltavelocity.x = value.X;
            nativePMTrace.deltavelocity.y = value.Y;
            nativePMTrace.deltavelocity.z = value.Z;
        }
    }

    public int HitGroup
    {
        get => nativePMTrace.hitgroup;
        set => nativePMTrace.hitgroup = value;
    }

    public override string ToString()
    {
        return $"AllSolid: {AllSolid}, StartSolid: {StartSolid}, EndPos: {EndPos}, Fraction: {Fraction}, Ent: {Ent}, HitGroup: {HitGroup}";
    }
}
