using Metamod.Enum.Metamod;
using Metamod.Native.Metamod;

namespace Metamod.Struct.Metamod
{
    public class MetaGlobals(nint ptr) : BaseManaged<NativeMetaGlobals>(ptr)
    {
        public unsafe MetaResult Result
        {
            get { ref var r = ref GetUnmanagedRef(); return r.mres; }
            set { ref var r = ref GetUnmanagedRef(); r.mres = value; }
        }

        public unsafe MetaResult PreverseResult
        {
            get { ref var r = ref GetUnmanagedRef(); return r.prev_mres; }
            set { ref var r = ref GetUnmanagedRef(); r.prev_mres = value; }
        }

        public unsafe MetaResult Status
        {
            get { ref var r = ref GetUnmanagedRef(); return r.status; }
            set { ref var r = ref GetUnmanagedRef(); r.status = value; }
        }

        public unsafe nint OriginReturn
        {
            get { ref var r = ref GetUnmanagedRef(); return r.orig_ret; }
            set { ref var r = ref GetUnmanagedRef(); r.orig_ret = value; }
        }

        public unsafe nint OverrideReturn
        {
            get { ref var r = ref GetUnmanagedRef(); return r.override_ret; }
            set { ref var r = ref GetUnmanagedRef(); r.override_ret = value; }
        }
    }
}