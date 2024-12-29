using Metamod.Native.Engine.PM;
using Metamod.Struct.Common;

namespace Metamod.Struct.Engine.PM;

public class PMPlane : BaseManaged<NativePMPlane>
{
    private Vector3f? _normal;
    public Vector3f Normal
    {
        get
        {
            _normal ??= new Vector3f(_native.normal);
            return _normal;
        }
        set
        {
            _normal ??= new Vector3f(_native.normal);
            _normal.X = value.X;
            _normal.Y = value.Y;
            _normal.Z = value.Z;
        }
    }

    public float Dist
    {
        get => _native.dist;
        set => _native.dist = value;
    }

    public override string ToString()
    {
        return $"Normal: {Normal}, Dist: {Dist}";
    }
}

