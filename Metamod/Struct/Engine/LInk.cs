using Metamod.Native.Engine;

namespace Metamod.Struct.Engine;

public class Link
{
    private NativeLink nativeLink;

    public nint Prev
    {
        get => nativeLink.prev;
        set => nativeLink.prev = value;
    }
    public nint Next
    {
        get => nativeLink.next;
        set => nativeLink.next = value;
    }
}
