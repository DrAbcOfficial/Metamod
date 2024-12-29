using Metamod.Native.Common;

namespace Metamod.Struct.Engine;

public class Edict : BaseManaged<NativeEdict>
{
    public Edict() : base() { }
    public Edict(NativeEdict edict) : base(edict) { }
    public Edict(nint ptr) : base(ptr) { }
    public int Free
    {
        get => _native.free;
        set => _native.free = value;
    }

    public int SerialNumber
    {
        get => _native.serialnumber;
        set => _native.serialnumber = value;
    }

    private Link _area = new();
    public Link Area
    {
        get
        {
            _area.Next = _native.area.next;
            _area.Prev = _native.area.prev;
            return _area;
        }
        set => _area = value;
    }

    public int HeadNode
    {
        get => _native.headnode;
        set => _native.headnode = value;
    }

    public int NumLeafs
    {
        get => _native.num_leafs;
        set => _native.num_leafs = value;
    }

    public short[] LeafNums
    {
        get => _native.leafnums;
        set => _native.leafnums = value;
    }

    public float FreeTime
    {
        get => _native.freetime;
        set => _native.freetime = value;
    }

    public nint PrivateData
    {
        get => _native.pvPrivateData;
        set => _native.pvPrivateData = value;
    }

    private Entvars? _v;
    public Entvars V
    {
        get
        {
            _v ??= new Entvars(_native.v);
            return _v;
        }
        set
        {
            _v = value;
            _native.v = value._native;
        }
    }
}
