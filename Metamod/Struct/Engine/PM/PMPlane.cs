using Metamod.Native.Engine.PM;
using Metamod.Struct.Common;

namespace Metamod.Struct.Engine.PM;

public class PMPlane
{
    internal NativePMPlane nativePMPlane;

    private Vector3f _normal = new();
    public Vector3f Normal
    {
        get
        {
            _normal.X = nativePMPlane.normal.x;
            _normal.Y = nativePMPlane.normal.y;
            _normal.Z = nativePMPlane.normal.z;
            return _normal;
        }
        set
        {
            nativePMPlane.normal.x = value.X;
            nativePMPlane.normal.y = value.Y;
            nativePMPlane.normal.z = value.Z;
        }
    }

    public float Dist
    {
        get => nativePMPlane.dist;
        set => nativePMPlane.dist = value;
    }

    public override string ToString()
    {
        return $"Normal: {Normal}, Dist: {Dist}";
    }
}

