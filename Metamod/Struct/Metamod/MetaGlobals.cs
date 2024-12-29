using Metamod.Enum.Metamod;
using Metamod.Native.Metamod;

namespace Metamod.Struct.Metamod
{
    public class MetaGlobals : BaseManaged<NativeMetaGlobals>
    {
        public MetaResult Result
        {
            get => _native.mres;
            set => _native.mres = value;
        }

        public MetaResult PreverseResult
        {
            get => _native.prev_mres;
            set => _native.prev_mres = value;
        }

        public MetaResult Status
        {
            get => _native.status;
            set => _native.status = value;
        }

        public nint OriginReturn
        {
            get => _native.orig_ret;
            set => _native.orig_ret = value;
        }

        public nint OverrideReturn
        {
            get => _native.override_ret;
            set => _native.override_ret = value;
        }
    }
}
