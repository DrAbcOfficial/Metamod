using Metamod.Native.Common;
using Metamod.Native.Engine;
using Metamod.Struct.Common;
using System.Text;

namespace Metamod.Struct.Engine;

public class LevelList : BaseManaged<NativeLevelList>
{
    public LevelList(NativeLevelList level) : base(level) { }
    public string MapName
    {
        get => Encoding.UTF8.GetString(_native.mapName);
        set
        {
            var bytes = Encoding.UTF8.GetBytes(value);
            Array.Copy(bytes, _native.mapName, Math.Min(bytes.Length, _native.mapName.Length));
            if (bytes.Length < _native.mapName.Length)
                _native.mapName[bytes.Length] = 0;
            else
                _native.mapName[^1] = 0;
        }
    }

    public string LandmarkName
    {
        get => Encoding.UTF8.GetString(_native.landmarkName);
        set
        {
            var bytes = Encoding.UTF8.GetBytes(value);
            Array.Copy(bytes, _native.landmarkName, Math.Min(bytes.Length, _native.landmarkName.Length));
            if (bytes.Length < _native.landmarkName.Length)
                _native.landmarkName[bytes.Length] = 0;
            else
                _native.landmarkName[^1] = 0;
        }
    }

    private Edict? _pentLandmark;
    public Edict PentLandmark
    {
        get
        {
            unsafe
            {
                _pentLandmark = new Edict((nint)_native.pentLandmark);
            }
            return _pentLandmark;
        }
        set
        {
            _pentLandmark = value;
            unsafe
            {
#pragma warning disable CS8500 // 这会获取托管类型的地址、获取其大小或声明指向它的指针
                _native.pentLandmark = (NativeEdict*)value.GetUnmanagedPtr();
#pragma warning restore CS8500 // 这会获取托管类型的地址、获取其大小或声明指向它的指针
            }
        }
    }

    private Vector3f? _vecLandmarkOrigin;
    public Vector3f LandmarkOrigin
    {
        get
        {
            _vecLandmarkOrigin ??= new Vector3f();
            unsafe
            {
                _vecLandmarkOrigin.X = _native.vecLandmarkOrigin.startpos[0];
                _vecLandmarkOrigin.Y = _native.vecLandmarkOrigin.startpos[1];
                _vecLandmarkOrigin.Z = _native.vecLandmarkOrigin.startpos[2];
            }
            return _vecLandmarkOrigin;
        }
        set
        {
            _vecLandmarkOrigin = value;
            unsafe
            {
                _native.vecLandmarkOrigin.startpos[0] = value.X;
                _native.vecLandmarkOrigin.startpos[1] = value.Y;
                _native.vecLandmarkOrigin.startpos[2] = value.Z;
            }
        }
    }
}
