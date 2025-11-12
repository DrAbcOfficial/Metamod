using Metamod.Native.Common;

namespace Metamod.Wrapper.Common;

public class Vector3f : BaseNativeWrapper<NativeVector3f>
{
    public Vector3f(float x, float y, float z) : base()
    {
        X = x;
        Y = y;
        Z = z;
    }
    public Vector3f() : base() { }
    internal unsafe Vector3f(NativeVector3f* nativePtr, bool ownsPointer = false) : base(nativePtr, ownsPointer){}

    /// <summary>
    /// X坐标
    /// </summary>
    public float X
    {
        get
        {
            unsafe
            {
                return NativePtr->startpos[0];
            }
        }
        set
        {
            unsafe
            {
                NativePtr->startpos[0] = value;
            }
        }
    }

    /// <summary>
    /// Y坐标
    /// </summary>
    public float Y
    {
        get
        {
            unsafe
            {
                return NativePtr->startpos[1];
            }
        }
        set
        {
            unsafe
            {
                NativePtr->startpos[1] = value;
            }
        }
    }

    /// <summary>
    /// Z坐标
    /// </summary>
    public float Z
    {
        get
        {
            unsafe
            {
                return NativePtr->startpos[2];
            }
        }
        set
        {
            unsafe
            {
                NativePtr->startpos[2] = value;
            }
        }
    }
}
