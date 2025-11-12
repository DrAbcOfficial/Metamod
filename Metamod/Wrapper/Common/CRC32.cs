using Metamod.Native.Common;

namespace Metamod.Wrapper.Common;

public class CRC32 : BaseNativeWrapper<NativeCRC32>
{
    public ulong Value
    {
        get
        {
            unsafe
            {
                return NativePtr->value;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->value = value;
            }
        }
    }
}
