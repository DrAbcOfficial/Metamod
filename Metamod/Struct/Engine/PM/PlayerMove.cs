using Metamod.Enum.Metamod;
using Metamod.Native.Engine.PM;
using Metamod.Struct.Common;

namespace Metamod.Struct.Engine.PM;

public class PlayerMove(nint ptr) : BaseManaged<NativePlayerMove>(ptr)
{
    public int PlayerIndex
    {
        get => _native.player_index;
        set => _native.player_index = value;
    }

    public bool Server
    {
        get => _native.server == QBoolean.TRUE;
        set => _native.server = value ? QBoolean.TRUE : QBoolean.FALSE;
    }

    public bool Multiplayer
    {
        get => _native.multiplayer == QBoolean.TRUE;
        set => _native.multiplayer = value ? QBoolean.TRUE : QBoolean.FALSE;
    }

    public float Time
    {
        get => _native.time;
        set => _native.time = value;
    }

    public float FrameTime
    {
        get => _native.frametime;
        set => _native.frametime = value;
    }

    private Vector3f? _forward;
    public Vector3f Forward
    {
        get
        {
            _forward ??= new Vector3f(_native.forward);
            return _forward;
        }
        set
        {
            _forward ??= new Vector3f(_native.forward);
            _forward.X = value.X;
            _forward.Y = value.Y;
            _forward.Z = value.Z;
        }
    }

    private Vector3f? _right;
    public Vector3f Right
    {
        get
        {
            _right ??= new Vector3f(_native.right);
            return _right;
        }
        set
        {
            _right ??= new Vector3f(_native.right);
            _right.X = value.X;
            _right.Y = value.Y;
            _right.Z = value.Z;
        }
    }

    private Vector3f? _up;
    public Vector3f Up
    {
        get
        {
            _up ??= new Vector3f(_native.up);
            return _up;
        }
        set
        {
            _up ??= new Vector3f(_native.up);
            _up.X = value.X;
            _up.Y = value.Y;
            _up.Z = value.Z;
        }
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

    private Vector3f? _oldangles;
    public Vector3f OldAngles
    {
        get
        {
            _oldangles ??= new Vector3f(_native.oldangles);
            return _oldangles;
        }
        set
        {
            _oldangles ??= new Vector3f(_native.oldangles);
            _oldangles.X = value.X;
            _oldangles.Y = value.Y;
            _oldangles.Z = value.Z;
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

    private Vector3f? _movedir;
    public Vector3f MoveDir
    {
        get
        {
            _movedir ??= new Vector3f(_native.movedir);
            return _movedir;
        }
        set
        {
            _movedir ??= new Vector3f(_native.movedir);
            _movedir.X = value.X;
            _movedir.Y = value.Y;
            _movedir.Z = value.Z;
        }
    }

    private Vector3f? _basevelocity;
    public Vector3f BaseVelocity
    {
        get
        {
            _basevelocity ??= new Vector3f(_native.basevelocity);
            return _basevelocity;
        }
        set
        {
            _basevelocity ??= new Vector3f(_native.basevelocity);
            _basevelocity.X = value.X;
            _basevelocity.Y = value.Y;
            _basevelocity.Z = value.Z;
        }
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

    public float DuckTime
    {
        get => _native.flDuckTime;
        set => _native.flDuckTime = value;
    }

    public bool InDuck
    {
        get => _native.bInDuck == QBoolean.TRUE;
        set => _native.bInDuck = value ? QBoolean.TRUE : QBoolean.FALSE;
    }

    public int TimeStepSound
    {
        get => _native.flTimeStepSound;
        set => _native.flTimeStepSound = value;
    }

    public int StepLeft
    {
        get => _native.iStepLeft;
        set => _native.iStepLeft = value;
    }

    public float FallVelocity
    {
        get => _native.flFallVelocity;
        set => _native.flFallVelocity = value;
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

    public float SwimTime
    {
        get => _native.flSwimTime;
        set => _native.flSwimTime = value;
    }

    public float NextPrimaryAttack
    {
        get => _native.flNextPrimaryAttack;
        set => _native.flNextPrimaryAttack = value;
    }

    public int Effects
    {
        get => _native.effects;
        set => _native.effects = value;
    }

    public int Flags
    {
        get => _native.flags;
        set => _native.flags = value;
    }

    public int UseHull
    {
        get => _native.usehull;
        set => _native.usehull = value;
    }

    public float Gravity
    {
        get => _native.gravity;
        set => _native.gravity = value;
    }

    public float Friction
    {
        get => _native.friction;
        set => _native.friction = value;
    }

    public int OldButtons
    {
        get => _native.oldbuttons;
        set => _native.oldbuttons = value;
    }

    public float WaterJumpTime
    {
        get => _native.waterjumptime;
        set => _native.waterjumptime = value;
    }

    public bool Dead
    {
        get => _native.dead == QBoolean.TRUE;
        set => _native.dead = value ? QBoolean.TRUE : QBoolean.FALSE;
    }

    public int DeadFlag
    {
        get => _native.deadflag;
        set => _native.deadflag = value;
    }

    public int Spectator
    {
        get => _native.spectator;
        set => _native.spectator = value;
    }

    public int MoveType
    {
        get => _native.movetype;
        set => _native.movetype = value;
    }

    public int OnGround
    {
        get => _native.onground;
        set => _native.onground = value;
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

    public int OldWaterLevel
    {
        get => _native.oldwaterlevel;
        set => _native.oldwaterlevel = value;
    }

    public string TextureName
    {
        get => System.Text.Encoding.UTF8.GetString(_native.sztexturename).TrimEnd('\0');
        set => _native.sztexturename = System.Text.Encoding.UTF8.GetBytes(value.PadRight(256, '\0'));
    }

    public char TextureType
    {
        get => (char)_native.chtexturetype;
        set => _native.chtexturetype = (byte)value;
    }

    public float MaxSpeed
    {
        get => _native.maxspeed;
        set => _native.maxspeed = value;
    }

    public float ClientMaxSpeed
    {
        get => _native.clientmaxspeed;
        set => _native.clientmaxspeed = value;
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
        return $"PlayerIndex: {PlayerIndex}, Origin: {Origin}, Angles: {Angles}, Velocity: {Velocity}, MaxSpeed: {MaxSpeed}";
    }
}