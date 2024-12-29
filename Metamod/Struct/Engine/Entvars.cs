using Metamod.Native.Common;
using Metamod.Native.Engine;
using Metamod.Struct.Common;

namespace Metamod.Struct.Engine;

public class Entvars : BaseManaged<NativeEntvars>
{
    public Entvars(nint ptr) : base(ptr) { }
    public Entvars() : base() { }
    public Entvars(NativeEntvars obj) : base(obj) { }
    private readonly StringHandle _classname = new();
    public string ClassName
    {
        get
        {
            _classname._native = _native.classname;
            return _classname.GetString();
        }
        set
        {
            _classname.SetString(value);
            _native.classname = _classname._native;
        }
    }

    private readonly StringHandle _globalname = new();
    public string GlobalName
    {
        get
        {
            _globalname._native = _native.globalname;
            return _globalname.GetString();
        }
        set
        {
            _globalname.SetString(value);
            _native.globalname = _globalname._native;
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

    private Vector3f? _oldorigin;
    public Vector3f OldOrigin
    {
        get
        {
            _oldorigin ??= new Vector3f(_native.oldorigin);
            return _oldorigin;
        }
        set
        {
            _oldorigin ??= new Vector3f(_native.oldorigin);
            _oldorigin.X = value.X;
            _oldorigin.Y = value.Y;
            _oldorigin.Z = value.Z;
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

    private Vector3f? _clbasevelocity;
    public Vector3f ClBaseVelocity
    {
        get
        {
            _clbasevelocity ??= new Vector3f(_native.clbasevelocity);
            return _clbasevelocity;
        }
        set
        {
            _clbasevelocity ??= new Vector3f(_native.clbasevelocity);
            _clbasevelocity.X = value.X;
            _clbasevelocity.Y = value.Y;
            _clbasevelocity.Z = value.Z;
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

    private Vector3f? _avelocity;
    public Vector3f AVelocity
    {
        get
        {
            _avelocity ??= new Vector3f(_native.avelocity);
            return _avelocity;
        }
        set
        {
            _avelocity ??= new Vector3f(_native.avelocity);
            _avelocity.X = value.X;
            _avelocity.Y = value.Y;
            _avelocity.Z = value.Z;
        }
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

    private Vector3f? _v_angle;
    public Vector3f VAngle
    {
        get
        {
            _v_angle ??= new Vector3f(_native.v_angle);
            return _v_angle;
        }
        set
        {
            _v_angle ??= new Vector3f(_native.v_angle);
            _v_angle.X = value.X;
            _v_angle.Y = value.Y;
            _v_angle.Z = value.Z;
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

    public int FixAngle
    {
        get => _native.fixangle;
        set => _native.fixangle = value;
    }

    public float IdealPitch
    {
        get => _native.idealpitch;
        set => _native.idealpitch = value;
    }

    public float PitchSpeed
    {
        get => _native.pitch_speed;
        set => _native.pitch_speed = value;
    }

    public float IdealYaw
    {
        get => _native.ideal_yaw;
        set => _native.ideal_yaw = value;
    }

    public float YawSpeed
    {
        get => _native.yaw_speed;
        set => _native.yaw_speed = value;
    }

    public int ModelIndex
    {
        get => _native.modelindex;
        set => _native.modelindex = value;
    }

    private StringHandle _model = new();
    public string Model
    {
        get
        {
            _model._native = _native.model;
            return _model.ToString();
        }
        set
        {
            _model.SetString(value);
            _native.model = _model._native;
        }
    }

    public int ViewModel
    {
        get => _native.viewmodel;
        set => _native.viewmodel = value;
    }

    public int WeaponModel
    {
        get => _native.weaponmodel;
        set => _native.weaponmodel = value;
    }

    private Vector3f? _absmin;
    public Vector3f AbsMin
    {
        get
        {
            _absmin ??= new Vector3f(_native.absmin);
            return _absmin;
        }
        set
        {
            _absmin ??= new Vector3f(_native.absmin);
            _absmin.X = value.X;
            _absmin.Y = value.Y;
            _absmin.Z = value.Z;
        }
    }

    private Vector3f? _absmax;
    public Vector3f AbsMax
    {
        get
        {
            _absmax ??= new Vector3f(_native.absmax);
            return _absmax;
        }
        set
        {
            _absmax ??= new Vector3f(_native.absmax);
            _absmax.X = value.X;
            _absmax.Y = value.Y;
            _absmax.Z = value.Z;
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

    private Vector3f? _size;
    public Vector3f Size
    {
        get
        {
            _size ??= new Vector3f(_native.size);
            return _size;
        }
        set
        {
            _size ??= new Vector3f(_native.size);
            _size.X = value.X;
            _size.Y = value.Y;
            _size.Z = value.Z;
        }
    }

    public float LTime
    {
        get => _native.ltime;
        set => _native.ltime = value;
    }

    public float NextThink
    {
        get => _native.nextthink;
        set => _native.nextthink = value;
    }

    public int MoveType
    {
        get => _native.movetype;
        set => _native.movetype = value;
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

    public int Body
    {
        get => _native.body;
        set => _native.body = value;
    }

    public int Effects
    {
        get => _native.effects;
        set => _native.effects = value;
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

    public int LightLevel
    {
        get => _native.light_level;
        set => _native.light_level = value;
    }

    public int Sequence
    {
        get => _native.sequence;
        set => _native.sequence = value;
    }

    public int GaitSequence
    {
        get => _native.gaitsequence;
        set => _native.gaitsequence = value;
    }

    public float Frame
    {
        get => _native.frame;
        set => _native.frame = value;
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

    public float Scale
    {
        get => _native.scale;
        set => _native.scale = value;
    }

    public int RenderMode
    {
        get => _native.rendermode;
        set => _native.rendermode = value;
    }

    public float RenderAmt
    {
        get => _native.renderamt;
        set => _native.renderamt = value;
    }

    private Vector3f? _rendercolor;
    public Vector3f RenderColor
    {
        get
        {
            _rendercolor ??= new Vector3f(_native.rendercolor);
            return _rendercolor;
        }
        set
        {
            _rendercolor ??= new Vector3f(_native.rendercolor);
            _rendercolor.X = value.X;
            _rendercolor.Y = value.Y;
            _rendercolor.Z = value.Z;
        }
    }

    public int RenderFx
    {
        get => _native.renderfx;
        set => _native.renderfx = value;
    }

    public float Health
    {
        get => _native.health;
        set => _native.health = value;
    }

    public float Frags
    {
        get => _native.frags;
        set => _native.frags = value;
    }

    public int Weapons
    {
        get => _native.weapons;
        set => _native.weapons = value;
    }

    public float TakeDamage
    {
        get => _native.takedamage;
        set => _native.takedamage = value;
    }

    public int DeadFlag
    {
        get => _native.deadflag;
        set => _native.deadflag = value;
    }

    private Vector3f? _viewofs;
    public Vector3f ViewOfs
    {
        get
        {
            _viewofs ??= new Vector3f(_native.view_ofs);
            return _viewofs;
        }
        set
        {
            _viewofs ??= new Vector3f(_native.view_ofs);
            _viewofs.X = value.X;
            _viewofs.Y = value.Y;
            _viewofs.Z = value.Z;
        }
    }

    public int Button
    {
        get => _native.button;
        set => _native.button = value;
    }

    public int Impulse
    {
        get => _native.impulse;
        set => _native.impulse = value;
    }

    private Edict? _chain;
    public Edict Chain
    {
        get
        {
            unsafe
            {
                _chain ??= new Edict((nint)_native.chain);
            }
            return _chain;
        }
        set
        {
            unsafe
            {
                _chain ??= new Edict((nint)_native.chain);
                _chain = value;
#pragma warning disable CS8500
                _native.chain = (NativeEdict*)value.GetUnmanagedPtr();
#pragma warning restore CS8500
            }
        }
    }

    private Edict? _dmginflictor;
    public Edict DmgInflictor
    {
        get
        {
            unsafe
            {
                _dmginflictor ??= new Edict((nint)_native.dmg_inflictor);
            }
            return _dmginflictor;
        }
        set
        {
            unsafe
            {
                _dmginflictor ??= new Edict((nint)_native.dmg_inflictor);
                _dmginflictor = value;
#pragma warning disable CS8500
                _native.dmg_inflictor = (NativeEdict*)value.GetUnmanagedPtr();
#pragma warning restore CS8500
            }
        }
    }

    private Edict? _enemy;
    public Edict Enemy
    {
        get
        {
            unsafe
            {
                _enemy ??= new Edict((nint)_native.enemy);
            }
            return _enemy;
        }
        set
        {
            unsafe
            {
                _enemy ??= new Edict((nint)_native.enemy);
                _enemy = value;
#pragma warning disable CS8500
                _native.enemy = (NativeEdict*)value.GetUnmanagedPtr();
#pragma warning restore CS8500
            }
        }
    }

    private Edict? _aiment;
    public Edict Aiment
    {
        get
        {
            unsafe
            {
                _aiment ??= new Edict((nint)_native.aiment);
            }
            return _aiment;
        }
        set
        {
            unsafe
            {
                _aiment ??= new Edict((nint)_native.aiment);
                _aiment = value;
#pragma warning disable CS8500
                _native.aiment = (NativeEdict*)value.GetUnmanagedPtr();
#pragma warning restore CS8500
            }
        }
    }

    private Edict? _owner;
    public Edict Owner
    {
        get
        {
            unsafe
            {
                _owner ??= new Edict((nint)_native.owner);
            }
            return _owner;
        }
        set
        {
            unsafe
            {
                _owner ??= new Edict((nint)_native.owner);
                _owner = value;
#pragma warning disable CS8500
                _native.owner = (NativeEdict*)value.GetUnmanagedPtr();
#pragma warning restore CS8500
            }
        }
    }

    private Edict? _groundedict;
    public Edict GroundEntity
    {
        get
        {
            unsafe
            {
                _groundedict ??= new Edict((nint)_native.groundentity);
            }
            return _groundedict;
        }
        set
        {
            unsafe
            {
                _groundedict ??= new Edict((nint)_native.groundentity);
                _groundedict = value;
#pragma warning disable CS8500
                _native.groundentity = (NativeEdict*)value.GetUnmanagedPtr();
#pragma warning restore CS8500
            }
        }
    }

    public int SpawnFlags
    {
        get => _native.spawnflags;
        set => _native.spawnflags = value;
    }

    public int Flags
    {
        get => _native.flags;
        set => _native.flags = value;
    }

    public int ColorMap
    {
        get => _native.colormap;
        set => _native.colormap = value;
    }

    public int Team
    {
        get => _native.team;
        set => _native.team = value;
    }

    public float MaxHealth
    {
        get => _native.max_health;
        set => _native.max_health = value;
    }

    public float TeleportTime
    {
        get => _native.teleport_time;
        set => _native.teleport_time = value;
    }

    public float ArmorType
    {
        get => _native.armortype;
        set => _native.armortype = value;
    }

    public float ArmorValue
    {
        get => _native.armorvalue;
        set => _native.armorvalue = value;
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

    public string_t Target
    {
        get => _native.target;
        set => _native.target = value;
    }

    public string_t TargetName
    {
        get => _native.targetname;
        set => _native.targetname = value;
    }

    public string_t NetName
    {
        get => _native.netname;
        set => _native.netname = value;
    }

    public string_t Message
    {
        get => _native.message;
        set => _native.message = value;
    }

    public float DmgTake
    {
        get => _native.dmg_take;
        set => _native.dmg_take = value;
    }

    public float DmgSave
    {
        get => _native.dmg_save;
        set => _native.dmg_save = value;
    }

    public float Dmg
    {
        get => _native.dmg;
        set => _native.dmg = value;
    }

    public float DmgTime
    {
        get => _native.dmgtime;
        set => _native.dmgtime = value;
    }

    private StringHandle _noise = new();
    public string Noise
    {
        get
        {
            _noise._native = _native.noise;
            return _noise.GetString();
        }
        set
        {
            _noise.SetString(value);
            _native.noise = _noise._native;
        }
    }

    private StringHandle _noise1 = new();
    public string Noise1
    {
        get
        {
            _noise1._native = _native.noise1;
            return _noise1.GetString();
        }
        set
        {
            _noise1.SetString(value);
            _native.noise1 = _noise1._native;
        }
    }

    private StringHandle _noise2 = new();
    public string Noise2
    {
        get
        {
            _noise2._native = _native.noise2;
            return _noise2.GetString();
        }
        set
        {
            _noise2.SetString(value);
            _native.noise2 = _noise2._native;
        }
    }

    private StringHandle _noise3 = new();
    public string Noise3
    {
        get
        {
            _noise3._native = _native.noise3;
            return _noise3.GetString();
        }
        set
        {
            _noise3.SetString(value);
            _native.noise3 = _noise3._native;
        }
    }

    public float Speed
    {
        get => _native.speed;
        set => _native.speed = value;
    }

    public float AirFinished
    {
        get => _native.air_finished;
        set => _native.air_finished = value;
    }

    public float PainFinished
    {
        get => _native.pain_finished;
        set => _native.pain_finished = value;
    }

    public float RadsuitFinished
    {
        get => _native.radsuit_finished;
        set => _native.radsuit_finished = value;
    }

    private Edict? _containingentity;
    public Edict ContainingEntity
    {
        get
        {
            unsafe
            {
                _containingentity ??= new Edict((nint)_native.pContainingEntity);
            }
            return _containingentity;
        }
        set
        {
            unsafe
            {
                _containingentity ??= new Edict((nint)_native.pContainingEntity);
                _containingentity = value;
#pragma warning disable CS8500
                _native.pContainingEntity = (NativeEdict*)value.GetUnmanagedPtr();
#pragma warning restore CS8500
            }
        }
    }

    public int PlayerClass
    {
        get => _native.playerclass;
        set => _native.playerclass = value;
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

    public int PushMsec
    {
        get => _native.pushmsec;
        set => _native.pushmsec = value;
    }

    public int BInDuck
    {
        get => _native.bInDuck;
        set => _native.bInDuck = value;
    }

    public int FlTimeStepSound
    {
        get => _native.flTimeStepSound;
        set => _native.flTimeStepSound = value;
    }

    public int FlSwimTime
    {
        get => _native.flSwimTime;
        set => _native.flSwimTime = value;
    }

    public int FlDuckTime
    {
        get => _native.flDuckTime;
        set => _native.flDuckTime = value;
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

    public int GameState
    {
        get => _native.gamestate;
        set => _native.gamestate = value;
    }

    public int OldButton
    {
        get => _native.oldbuttons;
        set => _native.oldbuttons = value;
    }

    public int GroupInfo
    {
        get => _native.groupinfo;
        set => _native.groupinfo = value;
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

    private Edict? _euser1;
    public Edict Euser1
    {
        get
        {
            unsafe
            {
                _euser1 ??= new Edict((nint)_native.euser1);
            }
            return _euser1;
        }
        set
        {
            unsafe
            {
                _euser1 ??= new Edict((nint)_native.euser1);
                _euser1 = value;
#pragma warning disable CS8500
                _native.euser1 = (NativeEdict*)value.GetUnmanagedPtr();
#pragma warning restore CS8500
            }
        }
    }

    private Edict? _euser2;
    public Edict euser2
    {
        get
        {
            unsafe
            {
                _euser2 ??= new Edict((nint)_native.euser2);
            }
            return _euser2;
        }
        set
        {
            unsafe
            {
                _euser2 ??= new Edict((nint)_native.euser2);
                _euser2 = value;
#pragma warning disable CS8500
                _native.euser2 = (NativeEdict*)value.GetUnmanagedPtr();
#pragma warning restore CS8500
            }
        }
    }

    private Edict? _euser3;
    public Edict euser3
    {
        get
        {
            unsafe
            {
                _euser3 ??= new Edict((nint)_native.euser3);
            }
            return _euser3;
        }
        set
        {
            unsafe
            {
                _euser3 ??= new Edict((nint)_native.euser3);
                _euser3 = value;
#pragma warning disable CS8500
                _native.euser3 = (NativeEdict*)value.GetUnmanagedPtr();
#pragma warning restore CS8500
            }
        }
    }

    private Edict? _euser4;
    public Edict euser4
    {
        get
        {
            unsafe
            {
                _euser4 ??= new Edict((nint)_native.euser4);
            }
            return _euser4;
        }
        set
        {
            unsafe
            {
                _euser4 ??= new Edict((nint)_native.euser4);
                _euser4 = value;
#pragma warning disable CS8500
                _native.euser4 = (NativeEdict*)value.GetUnmanagedPtr();
#pragma warning restore CS8500
            }
        }
    }
}
