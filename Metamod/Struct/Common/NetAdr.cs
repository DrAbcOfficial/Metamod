using Metamod.Enum.Common;
using Metamod.Native.Common;
using System.Net;

namespace Metamod.Struct.Common;

public class NetAdr
{
    internal NativeNetAdr native;
    public NetAdrType Type
    {
        get => native.type;
        set => native.type = value;
    }
    public IPAddress IPAddress
    {
        get
        {
            return new IPAddress(native.ip);
        }
        set
        {
            byte[] ip = value.GetAddressBytes();
            for (int i = 0; i < 4; i++)
            {
                native.ip[i] = ip[i];
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
                _ipx[i] = native.ipx[i];
            }
            return _ipx;
        }
        set
        {
            for (int i = 0; i < native.ipx.Length; i++)
            {
                native.ipx[i] = value[i];
            }
        }
    }
    public ushort Port
    {
        get => native.port;
        set => native.port = value;
    }
    public NetAdr()
    {
        native = new NativeNetAdr();
    }
}
