using System.Runtime.InteropServices;

namespace Metamod.Native.Game;

[StructLayout(LayoutKind.Sequential)]
internal unsafe struct NativeGameDllFuncs
{
    internal NativeDllFuncs* dllapi_table;
    internal NativeNewDllFuncs* newapi_table;

    // 2022-07-02 Added by hzqst
    internal NativeServerBlendInterface* studio_blend_api;
}
