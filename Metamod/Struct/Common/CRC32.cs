using Metamod.Native.Common;

namespace Metamod.Struct.Common;

public class CRC32(NativeCRC32 crc) : BaseManaged<NativeCRC32>(crc)
{
    public ulong Value
    {
        get => _native.value;
        set => _native.value = value;
    }
}
