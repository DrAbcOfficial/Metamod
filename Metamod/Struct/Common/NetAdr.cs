using Metamod.Enum.Common;
using Metamod.Native.Common;
using System.Net;

namespace Metamod.Struct.Common;

public class NetAdr : BaseManaged<NativeNetAdr>
{
    public NetAdrType Type
    {
        get => _native.type;
        set => _native.type = value;
    }
    public IPAddress IPAddress
    {
        get
        {
            return new IPAddress(_native.ip);
        }
        set
        {
            byte[] ip = value.GetAddressBytes();
            for (int i = 0; i < 4; i++)
            {
                _native.ip[i] = ip[i];
            }
        }
    }
    private readonly byte[] _ipx = new byte[10];
    public byte[] IPX
    {
        get
        {
            for (int i = 0; i < _ipx.Length; i++)
            {
                _ipx[i] = _native.ipx[i];
            }
            return _ipx;
        }
        set
        {
            for (int i = 0; i < _native.ipx.Length; i++)
            {
                _native.ipx[i] = value[i];
            }
        }
    }
    public ushort Port
    {
        get => _native.port;
        set => _native.port = value;
    }
    public NetAdr()
    {
        _native = new NativeNetAdr();
    }
}
