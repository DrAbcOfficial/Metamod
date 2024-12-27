using System.Runtime.InteropServices;

namespace Metamod.Struct.Engine;

[StructLayout(LayoutKind.Sequential)]
public struct Edict
{
    public int free;
    public int serialnumber;
    public Link area;                // linked to a division node or leaf

    public int headnode;           // -1 to use normal leaf check
    public int num_leafs;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
    public short[] leafnums;

    public float freetime;         // sv.time when the object was freed

    public nint pvPrivateData;        // Alloced and freed by engine, used by DLLs

    public Entvars v;                    // C exported fields from progs

    // other fields from progs come immediately after
}
