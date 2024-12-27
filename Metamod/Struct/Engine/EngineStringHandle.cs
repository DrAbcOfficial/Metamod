using System.Runtime.InteropServices;

namespace Metamod.Struct.Engine;

[StructLayout(LayoutKind.Sequential)]
public struct string_t
{
    internal int value;
    public static implicit operator string(string_t a)
    {
        throw new NotImplementedException();
    }
}
