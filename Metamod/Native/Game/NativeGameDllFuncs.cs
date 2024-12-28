using System.Runtime.InteropServices;

namespace Metamod.Native.Game;

[StructLayout(LayoutKind.Sequential)]
#pragma warning disable CS8500 // 这会获取托管类型的地址、获取其大小或声明指向它的指针
internal unsafe struct NativeGameDllFuncs
{
    internal NativeDllFuncs* dllapi_table;
    internal NativeNewDllFuncs* newapi_table;

    // 2022-07-02 Added by hzqst
    internal NativeServerBlendInterface* studio_blend_api;
}
#pragma warning restore CS8500 // 这会获取托管类型的地址、获取其大小或声明指向它的指针