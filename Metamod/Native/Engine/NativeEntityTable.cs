using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Metamod.Native.Engine;

[StructLayout(LayoutKind.Sequential)]
internal unsafe struct NativeEntityTable
{
    internal int id;             // Ordinal ID of this entity (used for entity <--> pointer conversions)
    internal NativeEdict* pent;          // Pointer to the in-game entity

    internal int location;       // Offset from the base data of this entity
    internal int size;           // Byte size of this entity's data
    internal int flags;          // This could be a short -- bit mask of transitions that this entity is in the PVS of
    internal string_t classname;		// entity class name
}
