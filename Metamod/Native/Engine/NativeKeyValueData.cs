using System.Runtime.InteropServices;

namespace Metamod.Native.Engine;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct NativeKeyValueData
{
    internal byte* szClassName;  // in: entity classname
    internal byte* szKeyName;        // in: name of key
    internal byte* szValue;      // in: value of key
    internal int fHandled;		// out: DLL sets to true if key-value pair was understood
}
