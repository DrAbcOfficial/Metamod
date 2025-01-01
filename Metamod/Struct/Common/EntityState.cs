using Metamod.Enum.Metamod;
using Metamod.Native.Common;

namespace Metamod.Struct.Common;

public class EntityState(nint ptr) : BaseManaged<NativeEntityState>(ptr)
{
    public int EntityType
    {
        get => _native.entityType;
        set => _native.entityType = value;
    }

    public int Number
    {
        get => _native.number;
        set => _native.number = value;
    }

    public float MsgTime
    {
        get => _native.msg_time;
        set => _native.msg_time = value;
    }

    public int MessageNum
    {
        get => _native.messagenum;
        set => _native.messagenum = value;
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

    public int ModelIndex
    {
        get => _native.modelindex;
        set => _native.modelindex = value;
    }

    public int Sequence
    {
        get => _native.sequence;
        set => _native.sequence = value;
    }

    public float Frame
    {
        get => _native.frame;
        set => _native.frame = value;
    }

    public int ColorMap
    {
        get => _native.colormap;
        set => _native.colormap = value;
    }

    public short Skin
    {
        get => _native.skin;
        set => _native.skin = value;
    }

    public short Solid
    {
        get => _native.solid;
        set => _native.solid = value;
    }

    public int Effects
    {
        get => _native.effects;
        set => _native.effects = value;
    }

    public float Scale
    {
        get => _native.scale;
        set => _native.scale = value;
    }

    public byte EFlags
    {
        get => _native.eflags;
        set => _native.eflags = value;
    }

    public int RenderMode
    {
        get => _native.rendermode;
        set => _native.rendermode = value;
    }

    public int RenderAmt
    {
        get => _native.renderamt;
        set => _native.renderamt = value;
    }

    private Color24 _renderColor = new();
    public Color24 RenderColor
    {
        get
        {
            _renderColor.R = _native.rendercolor.r;
            _renderColor.G = _native.rendercolor.g;
            _renderColor.B = _native.rendercolor.b;
            return _renderColor;
        }
        set
        {
            _native.rendercolor.r = value.R;
            _native.rendercolor.g = value.G;
            _native.rendercolor.b = value.B;
        }
    }

    public int RenderFx
    {
        get => _native.renderfx;
        set => _native.renderfx = value;
    }

    public int MoveType
    {
        get => _native.movetype;
        set => _native.movetype = value;
    }

    public float AnimTime
    {
        get => _native.animtime;
        set => _native.animtime = value;
    }

    public float FrameRate
    {
        get => _native.framerate;
        set => _native.framerate = value;
    }

    public int Body
    {
        get => _native.body;
        set => _native.body = value;
    }

    private readonly byte[] _controller = new byte[4];
    public byte[] Controller
    {
        get
        {
            _controller[0] = _native.controller[0];
            _controller[1] = _native.controller[1];
            _controller[2] = _native.controller[2];
            _controller[3] = _native.controller[3];
            return _controller;
        }
        set
        {
            _native.controller[0] = value[0];
            _native.controller[1] = value[1];
            _native.controller[2] = value[2];
            _native.controller[3] = value[3];
        }
    }

    private readonly byte[] _blending = new byte[4];
    public byte[] Blending
    {
        get
        {
            _blending[0] = _native.blending[0];
            _blending[1] = _native.blending[1];
            _blending[2] = _native.blending[2];
            _blending[3] = _native.blending[3];
            return _blending;
        }
        set
        {
            _native.blending[0] = value[0];
            _native.blending[1] = value[1];
            _native.blending[2] = value[2];
            _native.blending[3] = value[3];
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

    public int Aiment
    {
        get => _native.aiment;
        set => _native.aiment = value;
    }

    public int Owner
    {
        get => _native.owner;
        set => _native.owner = value;
    }

    public float Friction
    {
        get => _native.friction;
        set => _native.friction = value;
    }

    public float Gravity
    {
        get => _native.gravity;
        set => _native.gravity = value;
    }

    public int Team
    {
        get => _native.team;
        set => _native.team = value;
    }

    public int PlayerClass
    {
        get => _native.playerclass;
        set => _native.playerclass = value;
    }

    public int Health
    {
        get => _native.health;
        set => _native.health = value;
    }

    public bool Spectator
    {
        get => _native.spectator == QBoolean.TRUE;
        set => _native.spectator = value ? QBoolean.TRUE : QBoolean.FALSE;
    }

    public int WeaponModel
    {
        get => _native.weaponmodel;
        set => _native.weaponmodel = value;
    }

    public int GaitSequence
    {
        get => _native.gaitsequence;
        set => _native.gaitsequence = value;
    }

    private Vector3f? _basevelocity ;
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

    public int UseHull
    {
        get => _native.usehull;
        set => _native.usehull = value;
    }

    public int OldButtons
    {
        get => _native.oldbuttons;
        set => _native.oldbuttons = value;
    }

    public int OnGround
    {
        get => _native.onground;
        set => _native.onground = value;
    }

    public int IStepLeft
    {
        get => _native.iStepLeft;
        set => _native.iStepLeft = value;
    }

    public float FlFallVelocity
    {
        get => _native.flFallVelocity;
        set => _native.flFallVelocity = value;
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

    private Vector3f? _startpos;
    public Vector3f StartPos
    {
        get
        {
            _startpos ??= new Vector3f(_native.startpos);
            return _startpos;
        }
        set
        {
            _startpos ??= new Vector3f(_native.startpos);
            _startpos.X = value.X;
            _startpos.Y = value.Y;
            _startpos.Z = value.Z;
        }
    }

    private Vector3f? _endpos;
    public Vector3f EndPos
    {
        get
        {
            _endpos ??= new Vector3f(_native.endpos);
            return _endpos;
        }
        set
        {
            _endpos ??= new Vector3f(_native.endpos);
            _endpos.X = value.X;
            _endpos.Y = value.Y;
            _endpos.Z = value.Z;
        }
    }

    public float ImpactTime
    {
        get => _native.impacttime;
        set => _native.impacttime = value;
    }

    public float StartTime
    {
        get => _native.starttime;
        set => _native.starttime = value;
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
        return $"EntityType: {EntityType}, Number: {Number}, Origin: {Origin}, Angles: {Angles}, Health: {Health}";
    }
}
