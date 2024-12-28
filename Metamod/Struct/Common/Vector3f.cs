using Metamod.Native.Common;

namespace Metamod.Struct.Common
{
    public class Vector3f
    {
        internal NativeVector3f native;
        public float X
        {
            get => native.x;
            set => native.x = value;
        }
        public float Y
        {
            get => native.y;
            set => native.y = value;
        }

        public float Z
        {
            get => native.z;
            set => native.z = value;
        }

        public Vector3f()
        {
            native = new NativeVector3f();
        }
    }
}
