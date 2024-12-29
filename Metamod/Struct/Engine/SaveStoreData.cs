using Metamod.Native.Engine;
using Metamod.Struct.Common;
using System.Runtime.InteropServices;
using System.Text;

namespace Metamod.Struct.Engine;

public class SaveStoreData : BaseManaged<NativeSaveStoreData>
{
    public nint BaseData
    {
        get
        {
            unsafe
            {
                return (nint)_native.pBaseData;
            }
        }
        set
        {
            unsafe
            {
                _native.pBaseData = (byte*)value;
            }
        }
    }

    public nint CurrentData
    {
        get
        {
            unsafe
            {
                return (nint)_native.pCurrentData;
            }
        }
        set
        {
            unsafe
            {
                _native.pCurrentData = (byte*)value;
            }
        }
    }

    public int Size
    {
        get => _native.size;
        set => _native.size = value;
    }

    public int BufferSize
    {
        get => _native.bufferSize;
        set => _native.bufferSize = value;
    }

    public int TokenSize
    {
        get => _native.tokenSize;
        set => _native.tokenSize = value;
    }

    public int TokenCount
    {
        get => _native.tokenCount;
        set => _native.tokenCount = value;
    }

    public nint Tokens
    {
        get
        {
            unsafe
            {
                return (nint)_native.pTokens;
            }
        }
        set
        {
            unsafe
            {
                _native.pTokens = (byte**)value;
            }
        }
    }

    public int CurrentIndex
    {
        get => _native.currentIndex;
        set => _native.currentIndex = value;
    }

    public int TableCount
    {
        get => _native.tableCount;
        set => _native.tableCount = value;
    }

    public int ConnectionCount
    {
        get => _native.connectionCount;
        set => _native.connectionCount = value;
    }

    public nint Table
    {
        get
        {
            unsafe
            {
                return (nint)_native.pTable;
            }
        }
        set
        {
            unsafe
            {
                _native.pTable = (NativeEntityTable*)value;
            }
        }
    }

    private LevelList[]? _levelList;
    public LevelList[] LevelList
    {
        get
        {
            if (_levelList == null)
            {
                _levelList = new LevelList[_native.levelList.Length];
                for (int i = 0; i < _levelList.Length; i++)
                {
                    _levelList[i] = new LevelList(_native.levelList[i]);
                }
            }
            return _levelList;
        }
        set
        {
            if (value.Length > _native.levelList.Length)
            {
                throw new ArgumentException($"Level list length max is {_native.levelList.Length}");
            }
            for (int i = 0; i < value.Length; i++)
            {
                _native.levelList[i] = value[i]._native;
            }
            _levelList = value;
        }
    }
    
    public int UseLandmarl
    {
        get => _native.fUseLandmark;
        set => _native.fUseLandmark = value;
    }

    string LandmarkName
    {
        get => Encoding.UTF8.GetString(_native.szLandmarkName);
        set
        {
            var bytes = Encoding.UTF8.GetBytes(value);
            Array.Copy(bytes, _native.szLandmarkName, Math.Min(bytes.Length, _native.szLandmarkName.Length));
            if (bytes.Length < _native.szLandmarkName.Length)
                _native.szLandmarkName[bytes.Length] = 0;
            else
                _native.szLandmarkName[^1] = 0;
        }
    }

    private Vector3f? _landmarkOffset;
    public Vector3f? LandmarkOffset
    {
        get
        {
            _landmarkOffset ??= new Vector3f();
            unsafe
            {
                _landmarkOffset.X = _native.vecLandmarkOffset.startpos[0];
                _landmarkOffset.Y = _native.vecLandmarkOffset.startpos[1];
                _landmarkOffset.Z = _native.vecLandmarkOffset.startpos[2];
            }
            return _landmarkOffset;
        }
        set
        {
            _landmarkOffset = value;
            unsafe
            {
                _native.vecLandmarkOffset.startpos[0] = value.X;
                _native.vecLandmarkOffset.startpos[1] = value.Y;
                _native.vecLandmarkOffset.startpos[2] = value.Z;
            }
        }
    }

    public float Time
    {
        get => _native.time;
        set => _native.time = value;
    }

    public string CurrentMapName
    {
        get => Encoding.UTF8.GetString(_native.szCurrentMapName);
        set
        {
            var bytes = Encoding.UTF8.GetBytes(value);
            Array.Copy(bytes, _native.szCurrentMapName, Math.Min(bytes.Length, _native.szCurrentMapName.Length));
            if (bytes.Length < _native.szCurrentMapName.Length)
                _native.szCurrentMapName[bytes.Length] = 0;
            else
                _native.szCurrentMapName[^1] = 0;
        }
    }
}
