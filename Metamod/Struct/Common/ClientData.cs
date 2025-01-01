using Metamod.Native.Common;
using System.Text;

namespace Metamod.Struct.Common;

public class ClientData(nint ptr) : BaseManaged<NativeClientData>(ptr)
{
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

    private Vector3f? _velocity;
    public Vector3f Velocity
    {
        get
        {
            _velocity ??= new Vector3f(_native.velocity);
            return _velocity;
        }
        set
        {
            _velocity ??= new Vector3f(_native.velocity);
            _velocity.X = value.X;
            _velocity.Y = value.Y;
            _velocity.Z = value.Z;
        }
    }

    public int ViewModel
    {
        get => _native.viewmodel;
        set => _native.viewmodel = value;
    }

    private Vector3f? _punchangle;
    public Vector3f PunchAngle
    {
        get
        {
            _punchangle ??= new Vector3f(_native.punchangle);
            return _punchangle;
        }
        set
        {
            _punchangle ??= new Vector3f(_native.punchangle);
            _punchangle.X = value.X;
            _punchangle.Y = value.Y;
            _punchangle.Z = value.Z;
        }
    }

    public int Flags
    {
        get => _native.flags;
        set => _native.flags = value;
    }

    public int WaterLevel
    {
        get => _native.waterlevel;
        set => _native.waterlevel = value;
    }

    public int WaterType
    {
        get => _native.watertype;
        set => _native.watertype = value;
    }

    private Vector3f? _view_ofs;
    public Vector3f ViewOfs
    {
        get
        {
            _view_ofs ??= new Vector3f(_native.view_ofs);
            return _view_ofs;
        }
        set
        {
            _view_ofs ??= new Vector3f(_native.view_ofs);
            _view_ofs.X = value.X;
            _view_ofs.Y = value.Y;
            _view_ofs.Z = value.Z;
        }
    }

    public float Health
    {
        get => _native.health;
        set => _native.health = value;
    }

    public int BInDuck
    {
        get => _native.bInDuck;
        set => _native.bInDuck = value;
    }

    public int Weapons
    {
        get => _native.weapons;
        set => _native.weapons = value;
    }

    public int FlTimeStepSound
    {
        get => _native.flTimeStepSound;
        set => _native.flTimeStepSound = value;
    }

    public int FlDuckTime
    {
        get => _native.flDuckTime;
        set => _native.flDuckTime = value;
    }

    public int FlSwimTime
    {
        get => _native.flSwimTime;
        set => _native.flSwimTime = value;
    }

    public int WaterJumpTime
    {
        get => _native.waterjumptime;
        set => _native.waterjumptime = value;
    }

    public float MaxSpeed
    {
        get => _native.maxspeed;
        set => _native.maxspeed = value;
    }

    public float Fov
    {
        get => _native.fov;
        set => _native.fov = value;
    }

    public int WeaponAnim
    {
        get => _native.weaponanim;
        set => _native.weaponanim = value;
    }

    public int MId
    {
        get => _native.m_iId;
        set => _native.m_iId = value;
    }

    public int AmmoShells
    {
        get => _native.ammo_shells;
        set => _native.ammo_shells = value;
    }

    public int AmmoNails
    {
        get => _native.ammo_nails;
        set => _native.ammo_nails = value;
    }

    public int AmmoCells
    {
        get => _native.ammo_cells;
        set => _native.ammo_cells = value;
    }

    public int AmmoRockets
    {
        get => _native.ammo_rockets;
        set => _native.ammo_rockets = value;
    }

    public float MFlNextAttack
    {
        get => _native.m_flNextAttack;
        set => _native.m_flNextAttack = value;
    }

    public int TfState
    {
        get => _native.tfstate;
        set => _native.tfstate = value;
    }

    public int PushMsec
    {
        get => _native.pushmsec;
        set => _native.pushmsec = value;
    }

    public int DeadFlag
    {
        get => _native.deadflag;
        set => _native.deadflag = value;
    }

    public string PhysInfo
    {
        get => Encoding.UTF8.GetString(_native.physinfo);
        set
        {
            var bytes = Encoding.UTF8.GetBytes(value);
            Array.Copy(bytes, _native.physinfo, Math.Min(bytes.Length, _native.physinfo.Length));
            if (bytes.Length < _native.physinfo.Length)
                _native.physinfo[bytes.Length] = 0;
            else
                _native.physinfo[_native.physinfo.Length - 1] = 0;
        }
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

    private Vector3f _vuser4 = new();
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
        return $"Origin: {Origin}, Velocity: {Velocity}, Health: {Health}, MaxSpeed: {MaxSpeed}";
    }
}
