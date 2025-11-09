using Metamod.Native.Engine;
using Metamod.Struct.Common;

namespace Metamod.Struct.Engine;

public class GlobalVars(nint ptr) : BaseManaged<NativeGlobalVars>(ptr)
{
    public float Time
    {
        get => _native.time;
        set => _native.time = value;
    }
    public float Frametime
    {
        get => _native.frametime;
        set => _native.frametime = value;
    }
    public float ForceRetouch
    {
        get => _native.force_retouch;
        set => _native.force_retouch = value;
    }

    private StringHandle? _mapname;
    public StringHandle Mapname
    {
        get
        {
            _mapname ??= new(_native.mapname);
            return _mapname;
        }
        set
        {
            _mapname = value;
            _native.mapname = value._native;
        }
    }

    private StringHandle? _startpos;
    public StringHandle Startpos
    {
        get
        {
            _startpos ??= new(_native.startspot);
            return _startpos;
        }
        set
        {
            _startpos = value;
            _native.startspot = value._native;
        }
    }

    public float DeathMatch
    {
        get => _native.deathmatch;
        set => _native.deathmatch = value;
    }

    public float Coop
    {
        get => _native.coop;
        set => _native.coop = value;
    }

    public float TeamPlay
    {
        get => _native.teamplay;
        set => _native.teamplay = value;
    }

    public float ServerFlags
    {
        get => _native.serverflags;
        set => _native.serverflags = value;
    }

    public float FoundSecrets
    {
        get => _native.found_secrets;
        set => _native.found_secrets = value;
    }

    private Vector3f? _v_forward;
    public Vector3f VForward
    {
        get
        {
            _v_forward ??= new Vector3f(_native.v_forward);
            return _v_forward;
        }
        set
        {
            _v_forward = value;
            _native.v_forward = value._native;
        }
    }

    private Vector3f? _v_up;
    public Vector3f VUp
    {
        get
        {
            _v_up ??= new Vector3f(_native.v_up);
            return _v_up;
        }
        set
        {
            _v_up = value;
            _native.v_up = value._native;
        }
    }

    private Vector3f? _v_right;
    public Vector3f VRight
    {
        get
        {
            _v_right ??= new Vector3f(_native.v_right);
            return _v_right;
        }
        set
        {
            _v_right = value;
            _native.v_right = value._native;
        }
    }

    public float TraceAllSolid
    {
        get => _native.trace_allsolid;
        set => _native.trace_allsolid = value;
    }

    public float TraceStartSolid
    {
        get => _native.trace_startsolid;
        set => _native.trace_startsolid = value;
    }

    public float TraceFraction
    {
        get => _native.trace_fraction;
        set => _native.trace_fraction = value;
    }

    private Vector3f? _trace_endpos;
    public Vector3f TraceEndpos
    {
        get
        {
            _trace_endpos ??= new(_native.trace_endpos);
            return _trace_endpos;
        }
        set
        {
            _trace_endpos = value;
            _native.trace_endpos = value._native;
        }
    }

    private Vector3f? _trace_plane_normal;
    public Vector3f TracePlaneNormal
    {
        get
        {
            _trace_plane_normal ??= new(_native.trace_plane_normal);
            return _trace_plane_normal;
        }
        set
        {
            _trace_plane_normal = value;
            _native.trace_plane_normal = value._native;
        }
    }

    public float TracePlaneDist
    {
        get => _native.trace_plane_dist;
        set => _native.trace_plane_dist = value;
    }

    private Edict? _trace_ent;
    public Edict TraceEnt
    {
        get
        {
            _trace_ent ??= new(_native.trace_ent);
            return _trace_ent;
        }
        set
        {
            _trace_ent = value;
            _native.trace_ent = value.GetUnmanagedPtr();
        }
    }

    public float TraceInOpen
    {
        get => _native.trace_inopen;
        set => _native.trace_inopen = value;
    }

    public float TraceInWater
    {
        get => _native.trace_inwater;
        set => _native.trace_inwater = value;
    }

    public int TraceHitgroup
    {
        get => _native.trace_hitgroup;
        set => _native.trace_hitgroup = value;
    }

    public int TraceFlags
    {
        get => _native.trace_flags;
        set => _native.trace_flags = value;
    }

    public int MsgEntity
    {
        get => _native.msg_entity;
        set => _native.msg_entity = value;
    }

    public int CdAudioTrack
    {
        get => _native.cdAudioTrack;
        set => _native.cdAudioTrack = value;
    }

    public int MaxClients
    {
        get => _native.maxClients;
        set => _native.maxClients = value;
    }

    public int MaxEntities
    {
        get => _native.maxEntities;
        set => _native.maxEntities = value;
    }

    public nint StringBase
    {
        get => _native.pStringBase;
        set => _native.pStringBase = value;
    }

    public nint SaveData
    {
        get => _native.pSaveData;
        set => _native.pSaveData = value;
    }

    private Vector3f? _vecLandmarkOffset;
    public Vector3f LandmarkOffset
    {
        get
        {
            _vecLandmarkOffset ??= new(_native.vecLandmarkOffset);
            return _vecLandmarkOffset;
        }
        set
        {
            _vecLandmarkOffset = value;
            _native.vecLandmarkOffset = value._native;
        }
    }
}
