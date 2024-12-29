using Metamod.Native.Engine;

namespace Metamod.Struct.Engine;

public class Link : BaseManaged<NativeLink>
{
    public nint Prev
    {
        get => _native.prev;
        set => _native.prev = value;
    }
    public nint Next
    {
        get => _native.next;
        set => _native.next = value;
    }
}
