using Metamod.Native.Common;
using System.Runtime.InteropServices;

namespace Metamod.Native.Engine;

[StructLayout(LayoutKind.Sequential)]
#pragma warning disable CS8500 // 这会获取托管类型的地址、获取其大小或声明指向它的指针
internal unsafe struct NativeEntityTable
{
    internal int id;             // Ordinal ID of this entity (used for entity <--> pointer conversions)
    internal NativeEdict* pent;          // Pointer to the in-game entity

    internal int location;       // Offset from the base data of this entity
    internal int size;           // Byte size of this entity's data
    internal int flags;          // This could be a short -- bit mask of transitions that this entity is in the PVS of
    internal string_t classname;		// entity class name
}
#pragma warning restore CS8500 // 这会获取托管类型的地址、获取其大小或声明指向它的指针