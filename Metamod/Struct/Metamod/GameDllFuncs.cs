using Metamod.Native.Metamod;
using Metamod.Struct.Game;

namespace Metamod.Struct.Metamod;

public class GameDllFuncs : BaseManaged<NativeGameDllFuncs>
{
    public DllFuncs? DllFuncs;
    public NewDllFuncs? NewDllFuncs;
    public ServerBlendInterface? ServerBlendInterface;
    internal GameDllFuncs(nint ptr) : base(ptr)
    {
        DllFuncs = new(_native.dllapi_table);
        NewDllFuncs = new(_native.newapi_table);
        ServerBlendInterface = new(_native.studio_blend_api);
    }
}
