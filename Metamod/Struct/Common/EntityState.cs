using Metamod.Enum.Metamod;
using Metamod.Native.Common;
using System.Text;

namespace Metamod.Struct.Common;

public class EntityState
{
    internal NativeEntityState nativeEntityState;

    public int EntityType
    {
        get => nativeEntityState.entityType;
        set => nativeEntityState.entityType = value;
    }

    public int Number
    {
        get => nativeEntityState.number;
        set => nativeEntityState.number = value;
    }

    public float MsgTime
    {
        get => nativeEntityState.msg_time;
        set => nativeEntityState.msg_time = value;
    }

    public int MessageNum
    {
        get => nativeEntityState.messagenum;
        set => nativeEntityState.messagenum = value;
    }

    private Vector3f _origin = new();
    public Vector3f Origin
    {
        get
        {
            _origin.X = nativeEntityState.origin.x;
            _origin.Y = nativeEntityState.origin.y;
            _origin.Z = nativeEntityState.origin.z;
            return _origin;
        }
        set
        {
            nativeEntityState.origin.x = value.X;
            nativeEntityState.origin.y = value.Y;
            nativeEntityState.origin.z = value.Z;
        }
    }

    private Vector3f _angles = new();
    public Vector3f Angles
    {
        get
        {
            _angles.X = nativeEntityState.angles.x;
            _angles.Y = nativeEntityState.angles.y;
            _angles.Z = nativeEntityState.angles.z;
            return _angles;
        }
        set
        {
            nativeEntityState.angles.x = value.X;
            nativeEntityState.angles.y = value.Y;
            nativeEntityState.angles.z = value.Z;
        }
    }

    public int ModelIndex
    {
        get => nativeEntityState.modelindex;
        set => nativeEntityState.modelindex = value;
    }

    public int Sequence
    {
        get => nativeEntityState.sequence;
        set => nativeEntityState.sequence = value;
    }

    public float Frame
    {
        get => nativeEntityState.frame;
        set => nativeEntityState.frame = value;
    }

    public int ColorMap
    {
        get => nativeEntityState.colormap;
        set => nativeEntityState.colormap = value;
    }

    public short Skin
    {
        get => nativeEntityState.skin;
        set => nativeEntityState.skin = value;
    }

    public short Solid
    {
        get => nativeEntityState.solid;
        set => nativeEntityState.solid = value;
    }

    public int Effects
    {
        get => nativeEntityState.effects;
        set => nativeEntityState.effects = value;
    }

    public float Scale
    {
        get => nativeEntityState.scale;
        set => nativeEntityState.scale = value;
    }

    public byte EFlags
    {
        get => nativeEntityState.eflags;
        set => nativeEntityState.eflags = value;
    }

    public int RenderMode
    {
        get => nativeEntityState.rendermode;
        set => nativeEntityState.rendermode = value;
    }

    public int RenderAmt
    {
        get => nativeEntityState.renderamt;
        set => nativeEntityState.renderamt = value;
    }

    private Color24 _renderColor = new();
    public Color24 RenderColor
    {
        get
        {
            _renderColor.R = nativeEntityState.rendercolor.r;
            _renderColor.G = nativeEntityState.rendercolor.g;
            _renderColor.B = nativeEntityState.rendercolor.b;
            return _renderColor;
        }
        set
        {
            nativeEntityState.rendercolor.r = value.R;
            nativeEntityState.rendercolor.g = value.G;
            nativeEntityState.rendercolor.b = value.B;
        }
    }

    public int RenderFx
    {
        get => nativeEntityState.renderfx;
        set => nativeEntityState.renderfx = value;
    }

    public int MoveType
    {
        get => nativeEntityState.movetype;
        set => nativeEntityState.movetype = value;
    }

    public float AnimTime
    {
        get => nativeEntityState.animtime;
        set => nativeEntityState.animtime = value;
    }

    public float FrameRate
    {
        get => nativeEntityState.framerate;
        set => nativeEntityState.framerate = value;
    }

    public int Body
    {
        get => nativeEntityState.body;
        set => nativeEntityState.body = value;
    }

    private readonly byte[] _controller = new byte[4];
    public byte[] Controller
    {
        get
        {
            _controller[0] = nativeEntityState.controller[0];
            _controller[1] = nativeEntityState.controller[1];
            _controller[2] = nativeEntityState.controller[2];
            _controller[3] = nativeEntityState.controller[3];
            return _controller;
        }
        set
        {
            nativeEntityState.controller[0] = value[0];
            nativeEntityState.controller[1] = value[1];
            nativeEntityState.controller[2] = value[2];
            nativeEntityState.controller[3] = value[3];
        }
    }

    private readonly byte[] _blending = new byte[4];
    public byte[] Blending
    {
        get
        {
            _blending[0] = nativeEntityState.blending[0];
            _blending[1] = nativeEntityState.blending[1];
            _blending[2] = nativeEntityState.blending[2];
            _blending[3] = nativeEntityState.blending[3];
            return _blending;
        }
        set
        {
            nativeEntityState.blending[0] = value[0];
            nativeEntityState.blending[1] = value[1];
            nativeEntityState.blending[2] = value[2];
            nativeEntityState.blending[3] = value[3];
        }
    }

    private Vector3f _velocity = new();
    public Vector3f Velocity
    {
        get
        {
            _velocity.X = nativeEntityState.velocity.x;
            _velocity.Y = nativeEntityState.velocity.y;
            _velocity.Z = nativeEntityState.velocity.z;
            return _velocity;
        }
        set
        {
            nativeEntityState.velocity.x = value.X;
            nativeEntityState.velocity.y = value.Y;
            nativeEntityState.velocity.z = value.Z;
        }
    }

    private Vector3f _mins = new();
    public Vector3f Mins
    {
        get 
        {
            _mins.X = nativeEntityState.mins.x;
            _mins.Y = nativeEntityState.mins.y;
            _mins.Z = nativeEntityState.mins.z;
            return _mins;
        }
        set
        {
            nativeEntityState.mins.x = value.X;
            nativeEntityState.mins.y = value.Y;
            nativeEntityState.mins.z = value.Z;
        }
    }

    private Vector3f _maxs = new();
    public Vector3f Maxs
    {
        get
        {
            _maxs.X = nativeEntityState.maxs.x;
            _maxs.Y = nativeEntityState.maxs.y;
            _maxs.Z = nativeEntityState.maxs.z;
            return _maxs;
        }
        set
        {
            nativeEntityState.maxs.x = value.X;
            nativeEntityState.maxs.y = value.Y;
            nativeEntityState.maxs.z = value.Z;
        }
    }

    public int Aiment
    {
        get => nativeEntityState.aiment;
        set => nativeEntityState.aiment = value;
    }

    public int Owner
    {
        get => nativeEntityState.owner;
        set => nativeEntityState.owner = value;
    }

    public float Friction
    {
        get => nativeEntityState.friction;
        set => nativeEntityState.friction = value;
    }

    public float Gravity
    {
        get => nativeEntityState.gravity;
        set => nativeEntityState.gravity = value;
    }

    public int Team
    {
        get => nativeEntityState.team;
        set => nativeEntityState.team = value;
    }

    public int PlayerClass
    {
        get => nativeEntityState.playerclass;
        set => nativeEntityState.playerclass = value;
    }

    public int Health
    {
        get => nativeEntityState.health;
        set => nativeEntityState.health = value;
    }

    public bool Spectator
    {
        get => nativeEntityState.spectator == QBoolean.TRUE;
        set => nativeEntityState.spectator = value ? QBoolean.TRUE : QBoolean.FALSE;
    }

    public int WeaponModel
    {
        get => nativeEntityState.weaponmodel;
        set => nativeEntityState.weaponmodel = value;
    }

    public int GaitSequence
    {
        get => nativeEntityState.gaitsequence;
        set => nativeEntityState.gaitsequence = value;
    }

    private Vector3f _baseVelocity = new();
    public Vector3f BaseVelocity
    {
        get
        {
            _baseVelocity.X = nativeEntityState.basevelocity.x;
            _baseVelocity.Y = nativeEntityState.basevelocity.y;
            _baseVelocity.Z = nativeEntityState.basevelocity.z;
            return _baseVelocity;
        }
        set
        {
            nativeEntityState.basevelocity.x = value.X;
            nativeEntityState.basevelocity.y = value.Y;
            nativeEntityState.basevelocity.z = value.Z;
        }
    }

    public int UseHull
    {
        get => nativeEntityState.usehull;
        set => nativeEntityState.usehull = value;
    }

    public int OldButtons
    {
        get => nativeEntityState.oldbuttons;
        set => nativeEntityState.oldbuttons = value;
    }

    public int OnGround
    {
        get => nativeEntityState.onground;
        set => nativeEntityState.onground = value;
    }

    public int IStepLeft
    {
        get => nativeEntityState.iStepLeft;
        set => nativeEntityState.iStepLeft = value;
    }

    public float FlFallVelocity
    {
        get => nativeEntityState.flFallVelocity;
        set => nativeEntityState.flFallVelocity = value;
    }

    public float Fov
    {
        get => nativeEntityState.fov;
        set => nativeEntityState.fov = value;
    }

    public int WeaponAnim
    {
        get => nativeEntityState.weaponanim;
        set => nativeEntityState.weaponanim = value;
    }

    private Vector3f _startPos = new();
    public Vector3f StartPos
    {
        get
        {
            _startPos.X = nativeEntityState.startpos.x;
            _startPos.Y = nativeEntityState.startpos.y;
            _startPos.Z = nativeEntityState.startpos.z;
            return _startPos;
        }
        set
        {
            nativeEntityState.startpos.x = value.X;
            nativeEntityState.startpos.y = value.Y;
            nativeEntityState.startpos.z = value.Z;
        }
    }

    private Vector3f _endPos = new();
    public Vector3f EndPos
    {
        get
        {
            _endPos.X = nativeEntityState.endpos.x;
            _endPos.Y = nativeEntityState.endpos.y;
            _endPos.Z = nativeEntityState.endpos.z;
            return _endPos;
        }
        set
        {
            nativeEntityState.endpos.x = value.X;
            nativeEntityState.endpos.y = value.Y;
            nativeEntityState.endpos.z = value.Z;
        }
    }

    public float ImpactTime
    {
        get => nativeEntityState.impacttime;
        set => nativeEntityState.impacttime = value;
    }

    public float StartTime
    {
        get => nativeEntityState.starttime;
        set => nativeEntityState.starttime = value;
    }

    public int IUser1
    {
        get => nativeEntityState.iuser1;
        set => nativeEntityState.iuser1 = value;
    }

    public int IUser2
    {
        get => nativeEntityState.iuser2;
        set => nativeEntityState.iuser2 = value;
    }

    public int IUser3
    {
        get => nativeEntityState.iuser3;
        set => nativeEntityState.iuser3 = value;
    }

    public int IUser4
    {
        get => nativeEntityState.iuser4;
        set => nativeEntityState.iuser4 = value;
    }

    public float FUser1
    {
        get => nativeEntityState.fuser1;
        set => nativeEntityState.fuser1 = value;
    }

    public float FUser2
    {
        get => nativeEntityState.fuser2;
        set => nativeEntityState.fuser2 = value;
    }

    public float FUser3
    {
        get => nativeEntityState.fuser3;
        set => nativeEntityState.fuser3 = value;
    }

    public float FUser4
    {
        get => nativeEntityState.fuser4;
        set => nativeEntityState.fuser4 = value;
    }

    private Vector3f _vuser1 = new();
    public Vector3f VUser1
    {
        get
        {
            _vuser1.X = nativeEntityState.vuser1.x;
            _vuser1.Y = nativeEntityState.vuser1.y;
            _vuser1.Z = nativeEntityState.vuser1.z;
            return _vuser1;
        }
        set
        {
            nativeEntityState.vuser1.x = value.X;
            nativeEntityState.vuser1.y = value.Y;
            nativeEntityState.vuser1.z = value.Z;
        }
    }

    private Vector3f _vuser2 = new();
    public Vector3f VUser2
    {
        get
        {
            _vuser2.X = nativeEntityState.vuser2.x;
            _vuser2.Y = nativeEntityState.vuser2.y;
            _vuser2.Z = nativeEntityState.vuser2.z;
            return _vuser2;
        }
        set
        {
            nativeEntityState.vuser2.x = value.X;
            nativeEntityState.vuser2.y = value.Y;
            nativeEntityState.vuser2.z = value.Z;
        }
    }

    private Vector3f _vuser3 = new();
    public Vector3f VUser3
    {
        get
        {
            _vuser3.X = nativeEntityState.vuser3.x;
            _vuser3.Y = nativeEntityState.vuser3.y;
            _vuser3.Z = nativeEntityState.vuser3.z;
            return _vuser3;
        }
        set
        {
            nativeEntityState.vuser3.x = value.X;
            nativeEntityState.vuser3.y = value.Y;
            nativeEntityState.vuser3.z = value.Z;
        }
    }

    private Vector3f _vuser4 = new();
    public Vector3f VUser4
    {
        get
        {
            _vuser4.X = nativeEntityState.vuser4.x;
            _vuser4.Y = nativeEntityState.vuser4.y;
            _vuser4.Z = nativeEntityState.vuser4.z;
            return _vuser4;
        }
        set
        {
            nativeEntityState.vuser4.x = value.X;
            nativeEntityState.vuser4.y = value.Y;
            nativeEntityState.vuser4.z = value.Z;
        }
    }

    public override string ToString()
    {
        return $"EntityType: {EntityType}, Number: {Number}, Origin: {Origin}, Angles: {Angles}, Health: {Health}";
    }
}
