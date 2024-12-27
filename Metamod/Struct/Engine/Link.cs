using System.Runtime.InteropServices;

namespace Metamod.Struct.Engine;

[StructLayout(LayoutKind.Sequential)]
public struct Link
{
    public nint prev; // Pointer to the previous node in the linked list
    public nint next; // Pointer to the next node in the linked list
}
