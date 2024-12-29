using Metamod.Native.Common;
using System.Runtime.InteropServices;

namespace Metamod.Struct.Common
{
    public class Vector3f : BaseManaged<NativeVector3f>
    {
        private readonly bool _needFree = false;
        private readonly nint _ptr = nint.Zero;

        public float X
        {
            get
            {
                unsafe
                {
                    return _native.startpos[0];
                }
            }
            set
            {
                unsafe
                {
                    _native.startpos[0] = value;
                }
            }
        }
        public float Y
        {
            get
            {
                unsafe
                {
                    return _native.startpos[1];
                }
            }
            set
            {
                unsafe
                {
                    _native.startpos[1] = value;
                }
            }
        }
        public float Z
        {
            get
            {
                unsafe
                {
                    return _native.startpos[2];
                }
            }
            set
            {
                unsafe
                {
                    _native.startpos[2] = value;
                }
            }
        }

        ~Vector3f()
        {
            if (_needFree)
                Marshal.FreeHGlobal(_ptr);
        }
        public Vector3f() : base()
        {
            _ptr = Marshal.AllocHGlobal(sizeof(float) * 3);
            _needFree = true;
            unsafe
            {
                _native.startpos = (float*)_ptr;
            }
        }
        public Vector3f(NativeVector3f native) : base(native)
        {
            _needFree = false;
        }
        public Vector3f(float x, float y, float z) : this()
        {
            _needFree = false;
            X = x;
            Y = y;
            Z = z;
            unsafe
            {
                _native.startpos[0] = X;
                _native.startpos[1] = Y;
                _native.startpos[2] = Z;
            }
        }
    }
}
