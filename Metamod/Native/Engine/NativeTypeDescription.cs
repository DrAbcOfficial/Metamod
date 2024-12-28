using Metamod.Enum.Engine;
using System.Runtime.InteropServices;
namespace Metamod.Native.Engine;

[StructLayout(LayoutKind.Sequential)]
internal unsafe struct NativeTypeDescription
{
    internal FieldType fieldType;
    internal byte* fieldName;
    internal int fieldOffset;
    internal short fieldSize;
    internal short flags;
}
