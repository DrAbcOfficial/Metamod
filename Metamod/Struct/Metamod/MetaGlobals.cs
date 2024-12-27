using Metamod.Enum.Metamod;
using System.Runtime.InteropServices;

namespace Metamod.Struct.Metamod;

// Variables provided to plugins.
[StructLayout(LayoutKind.Sequential)]
public struct MetaGlobals
{
    MetaResult mres;          // writable; plugin's return flag
    MetaResult prev_mres;     // readable; return flag of the previous plugin called
    MetaResult status;        // readable; "highest" return flag so far
    nint orig_ret;         // readable; return value from "real" function
    nint override_ret;		// readable; return value from overriding/superceding plugin
}
