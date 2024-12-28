using Metamod.Native.Engine.PM;
using Metamod.Struct.Common;
using System.Text;

namespace Metamod.Struct.Engine.PM;

public class PhySent
{
    internal NativePhySent nativePhySent;

    public string Name
    {
        get => Encoding.UTF8.GetString(nativePhySent.name);
        set
        {
            var bytes = Encoding.UTF8.GetBytes(value);
            Array.Copy(bytes, nativePhySent.name, Math.Min(bytes.Length, nativePhySent.name.Length));
            if (bytes.Length < nativePhySent.name.Length)
                nativePhySent.name[bytes.Length] = 0;
            else
                nativePhySent.name[nativePhySent.name.Length - 1] = 0;
        }
    }

    public int Player
    {
        get => nativePhySent.player;
        set => nativePhySent.player = value;
    }

    private Vector3f _origin = new();
    public Vector3f Origin
    {
        get
        {
            _origin.X = nativePhySent.origin.x;
            _origin.Y = nativePhySent.origin.y;
            _origin.Z = nativePhySent.origin.z;
            return _origin;
        }
        set
        {
            nativePhySent.origin.x = value.X;
            nativePhySent.origin.y = value.Y;
            nativePhySent.origin.z = value.Z;
        }
    }

    public nint Model
    {
        get => nativePhySent.model;
        set => nativePhySent.model = value;
    }

    public nint StudioModel
    {
        get => nativePhySent.studiomodel;
        set => nativePhySent.studiomodel = value;
    }

    private Vector3f _mins = new();
    public Vector3f Mins
    {
        get
        {
            _mins.X = nativePhySent.mins.x;
            _mins.Y = nativePhySent.mins.y;
            _mins.Z = nativePhySent.mins.z;
            return _mins;
        }
        set
        {
            nativePhySent.mins.x = value.X;
            nativePhySent.mins.y = value.Y;
            nativePhySent.mins.z = value.Z;
        }
    }

    private Vector3f _maxs = new();
    public Vector3f Maxs
    {
        get
        {
            _maxs.X = nativePhySent.maxs.x;
            _maxs.Y = nativePhySent.maxs.y;
            _maxs.Z = nativePhySent.maxs.z;
            return _maxs;
        }
        set
        {
            nativePhySent.maxs.x = value.X;
            nativePhySent.maxs.y = value.Y;
            nativePhySent.maxs.z = value.Z;
        }
    }

    public int Info
    {
        get => nativePhySent.info;
        set => nativePhySent.info = value;
    }

    private Vector3f _angles = new();
    public Vector3f Angles
    {
        get
        {
            _angles.X = nativePhySent.angles.x;
            _angles.Y = nativePhySent.angles.y;
            _angles.Z = nativePhySent.angles.z;
            return _angles;
        }
        set
        {
            nativePhySent.angles.x = value.X;
            nativePhySent.angles.y = value.Y;
            nativePhySent.angles.z = value.Z;
        }
    }

    public int Solid
    {
        get => nativePhySent.solid;
        set => nativePhySent.solid = value;
    }

    public int Skin
    {
        get => nativePhySent.skin;
        set => nativePhySent.skin = value;
    }

    public int RenderMode
    {
        get => nativePhySent.rendermode;
        set => nativePhySent.rendermode = value;
    }

    public float Frame
    {
        get => nativePhySent.frame;
        set => nativePhySent.frame = value;
    }

    public int Sequence
    {
        get => nativePhySent.sequence;
        set => nativePhySent.sequence = value;
    }

    public byte[] Controller
    {
        get => nativePhySent.controller;
        set => nativePhySent.controller = value;
    }

    public byte[] Blending
    {
        get => nativePhySent.blending;
        set => nativePhySent.blending = value;
    }

    public int MoveType
    {
        get => nativePhySent.movetype;
        set => nativePhySent.movetype = value;
    }

    public int TakeDamage
    {
        get => nativePhySent.takedamage;
        set => nativePhySent.takedamage = value;
    }

    public int BloodDecal
    {
        get => nativePhySent.blooddecal;
        set => nativePhySent.blooddecal = value;
    }

    public int Team
    {
        get => nativePhySent.team;
        set => nativePhySent.team = value;
    }

    public int ClassNumber
    {
        get => nativePhySent.classnumber;
        set => nativePhySent.classnumber = value;
    }

    public int IUser1
    {
        get => nativePhySent.iuser1;
        set => nativePhySent.iuser1 = value;
    }

    public int IUser2
    {
        get => nativePhySent.iuser2;
        set => nativePhySent.iuser2 = value;
    }

    public int IUser3
    {
        get => nativePhySent.iuser3;
        set => nativePhySent.iuser3 = value;
    }

    public int IUser4
    {
        get => nativePhySent.iuser4;
        set => nativePhySent.iuser4 = value;
    }

    public float FUser1
    {
        get => nativePhySent.fuser1;
        set => nativePhySent.fuser1 = value;
    }

    public float FUser2
    {
        get => nativePhySent.fuser2;
        set => nativePhySent.fuser2 = value;
    }

    public float FUser3
    {
        get => nativePhySent.fuser3;
        set => nativePhySent.fuser3 = value;
    }

    public float FUser4
    {
        get => nativePhySent.fuser4;
        set => nativePhySent.fuser4 = value;
    }

    private Vector3f _vuser1 = new();
    public Vector3f VUser1
    {
        get
        {
            _vuser1.X = nativePhySent.vuser1.x;
            _vuser1.Y = nativePhySent.vuser1.y;
            _vuser1.Z = nativePhySent.vuser1.z;
            return _vuser1;
        }
        set
        {
            nativePhySent.vuser1.x = value.X;
            nativePhySent.vuser1.y = value.Y;
            nativePhySent.vuser1.z = value.Z;
        }
    }

    private Vector3f _vuser2 = new();
    public Vector3f VUser2
    {
        get
        {
            _vuser2.X = nativePhySent.vuser2.x;
            _vuser2.Y = nativePhySent.vuser2.y;
            _vuser2.Z = nativePhySent.vuser2.z;
            return _vuser2;
        }
        set
        {
            nativePhySent.vuser2.x = value.X;
            nativePhySent.vuser2.y = value.Y;
            nativePhySent.vuser2.z = value.Z;
        }
    }

    private Vector3f _vuser3 = new();
    public Vector3f VUser3
    {
        get
        {
            _vuser3.X = nativePhySent.vuser3.x;
            _vuser3.Y = nativePhySent.vuser3.y;
            _vuser3.Z = nativePhySent.vuser3.z;
            return _vuser3;
        }
        set
        {
            nativePhySent.vuser3.x = value.X;
            nativePhySent.vuser3.y = value.Y;
            nativePhySent.vuser3.z = value.Z;
        }
    }

    private Vector3f _vuser4 = new();
    public Vector3f VUser4
    {
        get
        {
            _vuser4.X = nativePhySent.vuser4.x;
            _vuser4.Y = nativePhySent.vuser4.y;
            _vuser4.Z = nativePhySent.vuser4.z;
            return _vuser4;
        }
        set
        {
            nativePhySent.vuser4.x = value.X;
            nativePhySent.vuser4.y = value.Y;
            nativePhySent.vuser4.z = value.Z;
        }
    }

    public override string ToString()
    {
        return $"Name: {Name}, Player: {Player}, Origin: {Origin}, Angles: {Angles}, Team: {Team}";
    }
}

