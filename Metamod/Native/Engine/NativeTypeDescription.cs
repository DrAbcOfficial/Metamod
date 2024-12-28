using Metamod.Enum.Engine;
namespace Metamod.Native.Engine;

internal unsafe struct NativeTypeDescription
{
    internal FieldType fieldType;
    internal byte* fieldName;
    internal int fieldOffset;
    internal short fieldSize;
    internal short flags;
}
