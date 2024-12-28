using Metamod.Native.Common;
using System.Text;

namespace Metamod.Struct.Common;

public class ClientData
{
    internal NativeClientData nativeClientData;

    private Vector3f _origin = new();
    public Vector3f Origin
    {
        get
        {
            _origin.X = nativeClientData.origin.x;
            _origin.Y = nativeClientData.origin.y;
            _origin.Z = nativeClientData.origin.z;
            return _origin;
        }
        set
        {
            nativeClientData.origin.x = value.X;
            nativeClientData.origin.y = value.Y;
            nativeClientData.origin.z = value.Z;
        }
    }

    private Vector3f _velocity = new();
    public Vector3f Velocity
    {
        get
        {
            _velocity.X = nativeClientData.velocity.x;
            _velocity.Y = nativeClientData.velocity.y;
            _velocity.Z = nativeClientData.velocity.z;
            return _velocity;
        }
        set
        {
            nativeClientData.velocity.x = value.X;
            nativeClientData.velocity.y = value.Y;
            nativeClientData.velocity.z = value.Z;
        }
    }

    public int ViewModel
    {
        get => nativeClientData.viewmodel;
        set => nativeClientData.viewmodel = value;
    }

    private Vector3f _punchangle = new();
    public Vector3f PunchAngle
    {
        get
        {
            _punchangle.X = nativeClientData.punchangle.x;
            _punchangle.Y = nativeClientData.punchangle.y;
            _punchangle.Z = nativeClientData.punchangle.z;
            return _punchangle;
        }
        set
        {
            nativeClientData.punchangle.x = value.X;
            nativeClientData.punchangle.y = value.Y;
            nativeClientData.punchangle.z = value.Z;
        }
    }

    public int Flags
    {
        get => nativeClientData.flags;
        set => nativeClientData.flags = value;
    }

    public int WaterLevel
    {
        get => nativeClientData.waterlevel;
        set => nativeClientData.waterlevel = value;
    }

    public int WaterType
    {
        get => nativeClientData.watertype;
        set => nativeClientData.watertype = value;
    }

    private Vector3f _viewOfs;
    public Vector3f ViewOfs
    {
        get
        {
            _viewOfs.X = nativeClientData.view_ofs.x;
            _viewOfs.Y = nativeClientData.view_ofs.y;
            _viewOfs.Z = nativeClientData.view_ofs.z;
            return _viewOfs;
        }
        set
        {
            nativeClientData.view_ofs.x = value.X;
            nativeClientData.view_ofs.y = value.Y;
            nativeClientData.view_ofs.z = value.Z;
        }
    }

    public float Health
    {
        get => nativeClientData.health;
        set => nativeClientData.health = value;
    }

    public int BInDuck
    {
        get => nativeClientData.bInDuck;
        set => nativeClientData.bInDuck = value;
    }

    public int Weapons
    {
        get => nativeClientData.weapons;
        set => nativeClientData.weapons = value;
    }

    public int FlTimeStepSound
    {
        get => nativeClientData.flTimeStepSound;
        set => nativeClientData.flTimeStepSound = value;
    }

    public int FlDuckTime
    {
        get => nativeClientData.flDuckTime;
        set => nativeClientData.flDuckTime = value;
    }

    public int FlSwimTime
    {
        get => nativeClientData.flSwimTime;
        set => nativeClientData.flSwimTime = value;
    }

    public int WaterJumpTime
    {
        get => nativeClientData.waterjumptime;
        set => nativeClientData.waterjumptime = value;
    }

    public float MaxSpeed
    {
        get => nativeClientData.maxspeed;
        set => nativeClientData.maxspeed = value;
    }

    public float Fov
    {
        get => nativeClientData.fov;
        set => nativeClientData.fov = value;
    }

    public int WeaponAnim
    {
        get => nativeClientData.weaponanim;
        set => nativeClientData.weaponanim = value;
    }

    public int MId
    {
        get => nativeClientData.m_iId;
        set => nativeClientData.m_iId = value;
    }

    public int AmmoShells
    {
        get => nativeClientData.ammo_shells;
        set => nativeClientData.ammo_shells = value;
    }

    public int AmmoNails
    {
        get => nativeClientData.ammo_nails;
        set => nativeClientData.ammo_nails = value;
    }

    public int AmmoCells
    {
        get => nativeClientData.ammo_cells;
        set => nativeClientData.ammo_cells = value;
    }

    public int AmmoRockets
    {
        get => nativeClientData.ammo_rockets;
        set => nativeClientData.ammo_rockets = value;
    }

    public float MFlNextAttack
    {
        get => nativeClientData.m_flNextAttack;
        set => nativeClientData.m_flNextAttack = value;
    }

    public int TfState
    {
        get => nativeClientData.tfstate;
        set => nativeClientData.tfstate = value;
    }

    public int PushMsec
    {
        get => nativeClientData.pushmsec;
        set => nativeClientData.pushmsec = value;
    }

    public int DeadFlag
    {
        get => nativeClientData.deadflag;
        set => nativeClientData.deadflag = value;
    }

    public string PhysInfo
    {
        get => Encoding.UTF8.GetString(nativeClientData.physinfo);
        set
        {
            byte[] bytes = Encoding.UTF8.GetBytes(value);
            int len = Math.Min(bytes.Length, nativeClientData.physinfo.Length);
            Array.Copy(bytes, nativeClientData.physinfo, len);
            nativeClientData.physinfo[Math.Min(len, nativeClientData.physinfo.Length - 1)] = 0;
        }
    }

    public int IUser1
    {
        get => nativeClientData.iuser1;
        set => nativeClientData.iuser1 = value;
    }

    public int IUser2
    {
        get => nativeClientData.iuser2;
        set => nativeClientData.iuser2 = value;
    }

    public int IUser3
    {
        get => nativeClientData.iuser3;
        set => nativeClientData.iuser3 = value;
    }

    public int IUser4
    {
        get => nativeClientData.iuser4;
        set => nativeClientData.iuser4 = value;
    }

    public float FUser1
    {
        get => nativeClientData.fuser1;
        set => nativeClientData.fuser1 = value;
    }

    public float FUser2
    {
        get => nativeClientData.fuser2;
        set => nativeClientData.fuser2 = value;
    }

    public float FUser3
    {
        get => nativeClientData.fuser3;
        set => nativeClientData.fuser3 = value;
    }

    public float FUser4
    {
        get => nativeClientData.fuser4;
        set => nativeClientData.fuser4 = value;
    }

    private Vector3f _vuser1 = new();
    public Vector3f VUser1
    {
        get
        {
            _vuser1.X = nativeClientData.vuser1.x;
            _vuser1.Y = nativeClientData.vuser1.y;
            _vuser1.Z = nativeClientData.vuser1.z;
            return _vuser1;
        }
        set
        {
            nativeClientData.vuser1.x = value.X;
            nativeClientData.vuser1.y = value.Y;
            nativeClientData.vuser1.z = value.Z;
        }
    }

    private Vector3f _vuser2 = new();
    public Vector3f VUser2
    {
        get
        {
            _vuser2.X = nativeClientData.vuser2.x;
            _vuser2.Y = nativeClientData.vuser2.y;
            _vuser2.Z = nativeClientData.vuser2.z;
            return _vuser2;
        }
        set
        {
            nativeClientData.vuser2.x = value.X;
            nativeClientData.vuser2.y = value.Y;
            nativeClientData.vuser2.z = value.Z;
        }
    }

    private Vector3f _vuser3 = new();
    public Vector3f VUser3
    {
        get
        {
            _vuser3.X = nativeClientData.vuser3.x;
            _vuser3.Y = nativeClientData.vuser3.y;
            _vuser3.Z = nativeClientData.vuser3.z;
            return _vuser3;
        }
        set
        {
            nativeClientData.vuser3.x = value.X;
            nativeClientData.vuser3.y = value.Y;
            nativeClientData.vuser3.z = value.Z;
        }
    }

    private Vector3f _vuser4 = new();
    public Vector3f VUser4
    {
        get
        {
            _vuser4.X = nativeClientData.vuser4.x;
            _vuser4.Y = nativeClientData.vuser4.y;
            _vuser4.Z = nativeClientData.vuser4.z;
            return _vuser4;
        }
        set
        {
            nativeClientData.vuser4.x = value.X;
            nativeClientData.vuser4.y = value.Y;
            nativeClientData.vuser4.z = value.Z;
        }
    }

    public override string ToString()
    {
        return $"Origin: {Origin}, Velocity: {Velocity}, Health: {Health}, MaxSpeed: {MaxSpeed}";
    }
}
