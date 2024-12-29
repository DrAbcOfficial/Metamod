using Metamod.Native.Engine.PM;
using Metamod.Struct.Common;
using System.Text;

namespace Metamod.Struct.Engine.PM;

public class PhySent : BaseManaged<NativePhySent>
{
    public string Name
    {
        get => Encoding.UTF8.GetString(_native.name);
        set
        {
            var bytes = Encoding.UTF8.GetBytes(value);
            Array.Copy(bytes, _native.name, Math.Min(bytes.Length, _native.name.Length));
            if (bytes.Length < _native.name.Length)
                _native.name[bytes.Length] = 0;
            else
                _native.name[_native.name.Length - 1] = 0;
        }
    }

    public int Player
    {
        get => _native.player;
        set => _native.player = value;
    }

    private Vector3f? _origin;
    public Vector3f Origin
    {
        get
        {
            _origin ??= new Vector3f(_native.origin);
            return _origin;
        }
        set
        {
            _origin ??= new Vector3f(_native.origin);
            _origin.X = value.X;
            _origin.Y = value.Y;
            _origin.Z = value.Z;
        }
    }

    public nint Model
    {
        get => _native.model;
        set => _native.model = value;
    }

    public nint StudioModel
    {
        get => _native.studiomodel;
        set => _native.studiomodel = value;
    }

    private Vector3f? _mins;
    public Vector3f Mins
    {
        get
        {
            _mins ??= new Vector3f(_native.mins);
            return _mins;
        }
        set
        {
            _mins ??= new Vector3f(_native.mins);
            _mins.X = value.X;
            _mins.Y = value.Y;
            _mins.Z = value.Z;
        }
    }

    private Vector3f? _maxs;
    public Vector3f Maxs
    {
        get
        {
            _maxs ??= new Vector3f(_native.maxs);
            return _maxs;
        }
        set
        {
            _maxs ??= new Vector3f(_native.maxs);
            _maxs.X = value.X;
            _maxs.Y = value.Y;
            _maxs.Z = value.Z;
        }
    }

    public int Info
    {
        get => _native.info;
        set => _native.info = value;
    }

    private Vector3f? _angles;
    public Vector3f Angles
    {
        get
        {
            _angles ??= new Vector3f(_native.angles);
            return _angles;
        }
        set
        {
            _angles ??= new Vector3f(_native.angles);
            _angles.X = value.X;
            _angles.Y = value.Y;
            _angles.Z = value.Z;
        }
    }

    public int Solid
    {
        get => _native.solid;
        set => _native.solid = value;
    }

    public int Skin
    {
        get => _native.skin;
        set => _native.skin = value;
    }

    public int RenderMode
    {
        get => _native.rendermode;
        set => _native.rendermode = value;
    }

    public float Frame
    {
        get => _native.frame;
        set => _native.frame = value;
    }

    public int Sequence
    {
        get => _native.sequence;
        set => _native.sequence = value;
    }

    public byte[] Controller
    {
        get => _native.controller;
        set => _native.controller = value;
    }

    public byte[] Blending
    {
        get => _native.blending;
        set => _native.blending = value;
    }

    public int MoveType
    {
        get => _native.movetype;
        set => _native.movetype = value;
    }

    public int TakeDamage
    {
        get => _native.takedamage;
        set => _native.takedamage = value;
    }

    public int BloodDecal
    {
        get => _native.blooddecal;
        set => _native.blooddecal = value;
    }

    public int Team
    {
        get => _native.team;
        set => _native.team = value;
    }

    public int ClassNumber
    {
        get => _native.classnumber;
        set => _native.classnumber = value;
    }

    public int IUser1
    {
        get => _native.iuser1;
        set => _native.iuser1 = value;
    }

    public int IUser2
    {
        get => _native.iuser2;
        set => _native.iuser2 = value;
    }

    public int IUser3
    {
        get => _native.iuser3;
        set => _native.iuser3 = value;
    }

    public int IUser4
    {
        get => _native.iuser4;
        set => _native.iuser4 = value;
    }

    public float FUser1
    {
        get => _native.fuser1;
        set => _native.fuser1 = value;
    }

    public float FUser2
    {
        get => _native.fuser2;
        set => _native.fuser2 = value;
    }

    public float FUser3
    {
        get => _native.fuser3;
        set => _native.fuser3 = value;
    }

    public float FUser4
    {
        get => _native.fuser4;
        set => _native.fuser4 = value;
    }

    private Vector3f? _vuser1;
    public Vector3f VUser1
    {
        get
        {
            _vuser1 ??= new Vector3f(_native.vuser1);
            return _vuser1;
        }
        set
        {
            _vuser1 ??= new Vector3f(_native.vuser1);
            _vuser1.X = value.X;
            _vuser1.Y = value.Y;
            _vuser1.Z = value.Z;
        }
    }
    private Vector3f? _vuser2;
    public Vector3f VUser2
    {
        get
        {
            _vuser2 ??= new Vector3f(_native.vuser2);
            return _vuser2;
        }
        set
        {
            _vuser2 ??= new Vector3f(_native.vuser2);
            _vuser2.X = value.X;
            _vuser2.Y = value.Y;
            _vuser2.Z = value.Z;
        }
    }
    private Vector3f? _vuser3;
    public Vector3f VUser3
    {
        get
        {
            _vuser3 ??= new Vector3f(_native.vuser3);
            return _vuser3;
        }
        set
        {
            _vuser3 ??= new Vector3f(_native.vuser3);
            _vuser3.X = value.X;
            _vuser3.Y = value.Y;
            _vuser3.Z = value.Z;
        }

    }
    private Vector3f? _vuser4;
    public Vector3f VUser4
    {
        get
        {
            _vuser4 ??= new Vector3f(_native.vuser4);
            return _vuser4;
        }
        set
        {
            _vuser4 ??= new Vector3f(_native.vuser4);
            _vuser4.X = value.X;
            _vuser4.Y = value.Y;
            _vuser4.Z = value.Z;
        }
    }

    public override string ToString()
    {
        return $"Name: {Name}, Player: {Player}, Origin: {Origin}, Angles: {Angles}, Team: {Team}";
    }
}

