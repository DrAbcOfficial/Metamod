using Metamod.Native.Engine;
using Metamod.Struct.Common;

namespace Metamod.Struct.Engine;

public class TraceResult : BaseManaged<NativeTraceResult>
{
    public bool AllSolid
    {
        get => _native.fAllSolid == 1;
        set => _native.fAllSolid = value ? 1 : 0;
    }

    public bool StartSolid
    {
        get => _native.fStartSolid == 1;
        set => _native.fStartSolid = value ? 1 : 0;
    }

    public bool InOpen
    {
        get => _native.fInOpen == 1;
        set => _native.fInOpen = value ? 1 : 0;
    }

    public bool InWater
    {
        get => _native.fInWater == 1;
        set => _native.fInWater = value ? 1 : 0;
    }

    public float Fraction
    {
        get => _native.flFraction;
        set => _native.flFraction = value;
    }

    private Vector3f? _endpos;
    public Vector3f EndPos
    {
        get
        {
            _endpos ??= new Vector3f(_native.vecEndPos);
            return _endpos;
        }
        set
        {
            _endpos ??= new Vector3f(_native.vecEndPos);
            _endpos.X = value.X;
            _endpos.Y = value.Y;
            _endpos.Z = value.Z;
        }
    }

    public float PlaneDist
    {
        get => _native.flPlaneDist;
        set => _native.flPlaneDist = value;
    }

    private Vector3f? _planeNormal;
    public Vector3f PlaneNormal
    {
        get
        {
            _planeNormal ??= new Vector3f(_native.vecPlaneNormal);
            return _planeNormal;
        }
        set
        {
            _planeNormal ??= new Vector3f(_native.vecPlaneNormal);
            _planeNormal.X = value.X;
            _planeNormal.Y = value.Y;
            _planeNormal.Z = value.Z;
        }
    }

    private Edict _hit = new();
    public Edict Ent
    {
        get
        {
            _hit.SetupFromPtr(_native.pHit);
            return _hit;
        }
        set => _native.pHit = value.GetUnmanagedPtr();
    }

    public int HitGroup
    {
        get => _native.iHitgroup;
        set => _native.iHitgroup = value;
    }
}
