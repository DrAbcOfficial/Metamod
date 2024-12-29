using Metamod.Native.Engine;

namespace Metamod.Struct.Engine;

public class KeyValueData : BaseManaged<NativeKeyValueData>
{
    private StringHandle _classname = new();
    public string ClassName
    {
        get
        {
            unsafe
            {
                _classname.SetPtr((nint)_native.szClassName);
            }
            return _classname.ToString();
        }
        set
        {
            _classname.SetString(value);
            unsafe
            {
                _native.szClassName = (byte*)_classname.GetPtr();
            }
        }
    }

    private StringHandle _keyname = new();
    public string KeyName
    {
        get
        {
            unsafe
            {
                _keyname.SetPtr((nint)_native.szKeyName);
            }
            return _keyname.ToString();
        }
        set
        {
            _keyname.SetString(value);
            unsafe
            {
                _native.szKeyName = (byte*)_keyname.GetPtr();
            }
        }
    }

    private StringHandle _value = new();
    public string Value
    {
        get
        {
            unsafe
            {
                _value.SetPtr((nint)_native.szValue);
            }
            return _value.ToString();
        }
        set
        {
            _value.SetString(value);
            unsafe
            {
                _native.szValue = (byte*)_value.GetPtr();
            }
        }
    }

    public int Handled
    {
        get => _native.fHandled;
        set => _native.fHandled = value;
    }
}
