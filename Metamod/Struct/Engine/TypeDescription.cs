using Metamod.Enum.Engine;
using Metamod.Native.Engine;
using System.Runtime.InteropServices;

namespace Metamod.Struct.Engine;

public class TypeDescription : BaseManaged<NativeTypeDescription>
{
    public FieldType FiledType
    {
        get => _native.fieldType;
        set => _native.fieldType = value;
    }

    public string FiledName
    {
        get
        {
            unsafe
            {
                return Marshal.PtrToStringUTF8((nint)_native.fieldName) ?? string.Empty;
            }
        }
    }

    public int FiledOffset
    {
        get => _native.fieldOffset;
        set => _native.fieldOffset = value;
    }

    public short FiledSize
    {
        get => _native.fieldSize;
        set => _native.fieldSize = value;
    }

    public short Flags
    {
        get => _native.flags;
        set => _native.flags = value;
    }
}
