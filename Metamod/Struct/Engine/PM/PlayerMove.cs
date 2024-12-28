using Metamod.Enum.Metamod;
using Metamod.Native.Engine.PM;
using Metamod.Struct.Common;

namespace Metamod.Struct.Engine.PM;

public class PlayerMove
{
    internal NativePlayerMove nativePlayerMove;

    public int PlayerIndex
    {
        get => nativePlayerMove.player_index;
        set => nativePlayerMove.player_index = value;
    }

    public bool Server
    {
        get => nativePlayerMove.server == QBoolean.TRUE;
        set => nativePlayerMove.server = value ? QBoolean.TRUE : QBoolean.FALSE;
    }

    public bool Multiplayer
    {
        get => nativePlayerMove.multiplayer == QBoolean.TRUE;
        set => nativePlayerMove.multiplayer = value ? QBoolean.TRUE : QBoolean.FALSE;
    }

    public float Time
    {
        get => nativePlayerMove.time;
        set => nativePlayerMove.time = value;
    }

    public float FrameTime
    {
        get => nativePlayerMove.frametime;
        set => nativePlayerMove.frametime = value;
    }

    private Vector3f _forward = new();
    public Vector3f Forward
    {
        get
        {
            _forward.X = nativePlayerMove.forward.x;
            _forward.Y = nativePlayerMove.forward.y;
            _forward.Z = nativePlayerMove.forward.z;
            return _forward;
        }
        set
        {
            nativePlayerMove.forward.x = value.X;
            nativePlayerMove.forward.y = value.Y;
            nativePlayerMove.forward.z = value.Z;
        }
    }

    private Vector3f _right = new();
    public Vector3f Right
    {
        get
        {
            _right.X = nativePlayerMove.right.x;
            _right.Y = nativePlayerMove.right.y;
            _right.Z = nativePlayerMove.right.z;
            return _right;
        }
        set
        {
            nativePlayerMove.right.x = value.X;
            nativePlayerMove.right.y = value.Y;
            nativePlayerMove.right.z = value.Z;
        }
    }

    private Vector3f _up = new();
    public Vector3f Up
    {
        get
        {
            _up.X = nativePlayerMove.up.x;
            _up.Y = nativePlayerMove.up.y;
            _up.Z = nativePlayerMove.up.z;
            return _up;
        }
        set
        {
            nativePlayerMove.up.x = value.X;
            nativePlayerMove.up.y = value.Y;
            nativePlayerMove.up.z = value.Z;
        }
    }

    private Vector3f _origin = new();
    public Vector3f Origin
    {
        get
        {
            _origin.X = nativePlayerMove.origin.x;
            _origin.Y = nativePlayerMove.origin.y;
            _origin.Z = nativePlayerMove.origin.z;
            return _origin;
        }
        set
        {
            nativePlayerMove.origin.x = value.X;
            nativePlayerMove.origin.y = value.Y;
            nativePlayerMove.origin.z = value.Z;
        }
    }

    private Vector3f _angles = new();
    public Vector3f Angles
    {
        get
        {
            _angles.X = nativePlayerMove.angles.x;
            _angles.Y = nativePlayerMove.angles.y;
            _angles.Z = nativePlayerMove.angles.z;
            return _angles;
        }
        set
        {
            nativePlayerMove.angles.x = value.X;
            nativePlayerMove.angles.y = value.Y;
            nativePlayerMove.angles.z = value.Z;
        }
    }

    private Vector3f _oldAngles = new();
    public Vector3f OldAngles
    {
        get
        {
            _oldAngles.X = nativePlayerMove.oldangles.x;
            _oldAngles.Y = nativePlayerMove.oldangles.y;
            _oldAngles.Z = nativePlayerMove.oldangles.z;
            return _oldAngles;
        }
        set
        {
            nativePlayerMove.oldangles.x = value.X;
            nativePlayerMove.oldangles.y = value.Y;
            nativePlayerMove.oldangles.z = value.Z;
        }
    }

    private Vector3f _velocity = new();
    public Vector3f Velocity
    {
        get
        {
            _velocity.X = nativePlayerMove.velocity.x;
            _velocity.Y = nativePlayerMove.velocity.y;
            _velocity.Z = nativePlayerMove.velocity.z;
            return _velocity;
        }
        set
        {
            nativePlayerMove.velocity.x = value.X;
            nativePlayerMove.velocity.y = value.Y;
            nativePlayerMove.velocity.z = value.Z;
        }
    }

    private Vector3f _moveDir = new();
    public Vector3f MoveDir
    {
        get
        {
            _moveDir.X = nativePlayerMove.movedir.x;
            _moveDir.Y = nativePlayerMove.movedir.y;
            _moveDir.Z = nativePlayerMove.movedir.z;
            return _moveDir;
        }
        set
        {
            nativePlayerMove.movedir.x = value.X;
            nativePlayerMove.movedir.y = value.Y;
            nativePlayerMove.movedir.z = value.Z;
        }
    }

    private Vector3f _baseVelocity = new();
    public Vector3f BaseVelocity
    {
        get
        {
            _baseVelocity.X = nativePlayerMove.basevelocity.x;
            _baseVelocity.Y = nativePlayerMove.basevelocity.y;
            _baseVelocity.Z = nativePlayerMove.basevelocity.z;
            return _baseVelocity;
        }
        set
        {
            nativePlayerMove.basevelocity.x = value.X;
            nativePlayerMove.basevelocity.y = value.Y;
            nativePlayerMove.basevelocity.z = value.Z;
        }
    }

    private Vector3f _viewOfs = new();
    public Vector3f ViewOfs
    {
        get
        {
            _viewOfs.X = nativePlayerMove.view_ofs.x;
            _viewOfs.Y = nativePlayerMove.view_ofs.y;
            _viewOfs.Z = nativePlayerMove.view_ofs.z;
            return _viewOfs;
        }
        set
        {
            nativePlayerMove.view_ofs.x = value.X;
            nativePlayerMove.view_ofs.y = value.Y;
            nativePlayerMove.view_ofs.z = value.Z;
        }
    }

    public float DuckTime
    {
        get => nativePlayerMove.flDuckTime;
        set => nativePlayerMove.flDuckTime = value;
    }

    public bool InDuck
    {
        get => nativePlayerMove.bInDuck == QBoolean.TRUE;
        set => nativePlayerMove.bInDuck = value ? QBoolean.TRUE : QBoolean.FALSE;
    }

    public int TimeStepSound
    {
        get => nativePlayerMove.flTimeStepSound;
        set => nativePlayerMove.flTimeStepSound = value;
    }

    public int StepLeft
    {
        get => nativePlayerMove.iStepLeft;
        set => nativePlayerMove.iStepLeft = value;
    }

    public float FallVelocity
    {
        get => nativePlayerMove.flFallVelocity;
        set => nativePlayerMove.flFallVelocity = value;
    }

    private Vector3f _punchAngle = new();
    public Vector3f PunchAngle
    {
        get
        {
            _punchAngle.X = nativePlayerMove.punchangle.x;
            _punchAngle.Y = nativePlayerMove.punchangle.y;
            _punchAngle.Z = nativePlayerMove.punchangle.z;
            return _punchAngle;
        }
        set
        {
            nativePlayerMove.punchangle.x = value.X;
            nativePlayerMove.punchangle.y = value.Y;
            nativePlayerMove.punchangle.z = value.Z;
        }
    }

    public float SwimTime
    {
        get => nativePlayerMove.flSwimTime;
        set => nativePlayerMove.flSwimTime = value;
    }

    public float NextPrimaryAttack
    {
        get => nativePlayerMove.flNextPrimaryAttack;
        set => nativePlayerMove.flNextPrimaryAttack = value;
    }

    public int Effects
    {
        get => nativePlayerMove.effects;
        set => nativePlayerMove.effects = value;
    }

    public int Flags
    {
        get => nativePlayerMove.flags;
        set => nativePlayerMove.flags = value;
    }

    public int UseHull
    {
        get => nativePlayerMove.usehull;
        set => nativePlayerMove.usehull = value;
    }

    public float Gravity
    {
        get => nativePlayerMove.gravity;
        set => nativePlayerMove.gravity = value;
    }

    public float Friction
    {
        get => nativePlayerMove.friction;
        set => nativePlayerMove.friction = value;
    }

    public int OldButtons
    {
        get => nativePlayerMove.oldbuttons;
        set => nativePlayerMove.oldbuttons = value;
    }

    public float WaterJumpTime
    {
        get => nativePlayerMove.waterjumptime;
        set => nativePlayerMove.waterjumptime = value;
    }

    public bool Dead
    {
        get => nativePlayerMove.dead == QBoolean.TRUE;
        set => nativePlayerMove.dead = value ? QBoolean.TRUE : QBoolean.FALSE;
    }

    public int DeadFlag
    {
        get => nativePlayerMove.deadflag;
        set => nativePlayerMove.deadflag = value;
    }

    public int Spectator
    {
        get => nativePlayerMove.spectator;
        set => nativePlayerMove.spectator = value;
    }

    public int MoveType
    {
        get => nativePlayerMove.movetype;
        set => nativePlayerMove.movetype = value;
    }

    public int OnGround
    {
        get => nativePlayerMove.onground;
        set => nativePlayerMove.onground = value;
    }

    public int WaterLevel
    {
        get => nativePlayerMove.waterlevel;
        set => nativePlayerMove.waterlevel = value;
    }

    public int WaterType
    {
        get => nativePlayerMove.watertype;
        set => nativePlayerMove.watertype = value;
    }

    public int OldWaterLevel
    {
        get => nativePlayerMove.oldwaterlevel;
        set => nativePlayerMove.oldwaterlevel = value;
    }

    public string TextureName
    {
        get => System.Text.Encoding.UTF8.GetString(nativePlayerMove.sztexturename).TrimEnd('\0');
        set => nativePlayerMove.sztexturename = System.Text.Encoding.UTF8.GetBytes(value.PadRight(256, '\0'));
    }

    public char TextureType
    {
        get => (char)nativePlayerMove.chtexturetype;
        set => nativePlayerMove.chtexturetype = (byte)value;
    }

    public float MaxSpeed
    {
        get => nativePlayerMove.maxspeed;
        set => nativePlayerMove.maxspeed = value;
    }

    public float ClientMaxSpeed
    {
        get => nativePlayerMove.clientmaxspeed;
        set => nativePlayerMove.clientmaxspeed = value;
    }

    public int IUser1
    {
        get => nativePlayerMove.iuser1;
        set => nativePlayerMove.iuser1 = value;
    }

    public int IUser2
    {
        get => nativePlayerMove.iuser2;
        set => nativePlayerMove.iuser2 = value;
    }

    public int IUser3
    {
        get => nativePlayerMove.iuser3;
        set => nativePlayerMove.iuser3 = value;
    }

    public int IUser4
    {
        get => nativePlayerMove.iuser4;
        set => nativePlayerMove.iuser4 = value;
    }

    public float FUser1
    {
        get => nativePlayerMove.fuser1;
        set => nativePlayerMove.fuser1 = value;
    }

    public float FUser2
    {
        get => nativePlayerMove.fuser2;
        set => nativePlayerMove.fuser2 = value;
    }

    public float FUser3
    {
        get => nativePlayerMove.fuser3;
        set => nativePlayerMove.fuser3 = value;
    }

    public float FUser4
    {
        get => nativePlayerMove.fuser4;
        set => nativePlayerMove.fuser4 = value;
    }

    private Vector3f _vuser1 = new();
    public Vector3f VUser1
    {
        get
        {
            _vuser1.X = nativePlayerMove.vuser1.x;
            _vuser1.Y = nativePlayerMove.vuser1.y;
            _vuser1.Z = nativePlayerMove.vuser1.z;
            return _vuser1;
        }
        set
        {
            nativePlayerMove.vuser1.x = value.X;
            nativePlayerMove.vuser1.y = value.Y;
            nativePlayerMove.vuser1.z = value.Z;
        }
    }

    private Vector3f _vuser2 = new();
    public Vector3f VUser2
    {
        get
        {
            _vuser2.X = nativePlayerMove.vuser2.x;
            _vuser2.Y = nativePlayerMove.vuser2.y;
            _vuser2.Z = nativePlayerMove.vuser2.z;
            return _vuser2;
        }
        set
        {
            nativePlayerMove.vuser2.x = value.X;
            nativePlayerMove.vuser2.y = value.Y;
            nativePlayerMove.vuser2.z = value.Z;
        }
    }

    private Vector3f _vuser3 = new();
    public Vector3f VUser3
    {
        get
        {
            _vuser3.X = nativePlayerMove.vuser3.x;
            _vuser3.Y = nativePlayerMove.vuser3.y;
            _vuser3.Z = nativePlayerMove.vuser3.z;
            return _vuser3;
        }
        set
        {
            nativePlayerMove.vuser3.x = value.X;
            nativePlayerMove.vuser3.y = value.Y;
            nativePlayerMove.vuser3.z = value.Z;
        }
    }

    private Vector3f _vuser4 = new();
    public Vector3f VUser4
    {
        get
        {
            _vuser4.X = nativePlayerMove.vuser4.x;
            _vuser4.Y = nativePlayerMove.vuser4.y;
            _vuser4.Z = nativePlayerMove.vuser4.z;
            return _vuser4;
        }
        set
        {
            nativePlayerMove.vuser4.x = value.X;
            nativePlayerMove.vuser4.y = value.Y;
            nativePlayerMove.vuser4.z = value.Z;
        }
    }

    public override string ToString()
    {
        return $"PlayerIndex: {PlayerIndex}, Origin: {Origin}, Angles: {Angles}, Velocity: {Velocity}, MaxSpeed: {MaxSpeed}";
    }
}