using Metamod.Native.Game;

namespace Metamod.Struct.Game;

public class ServerBlendInterface : BaseManaged<NativeServerBlendInterface>
{
    internal ServerBlendInterface(nint address) : base(address) { }

    public int Version
    {
        get => _native.version;
        set => _native.version = value;
    }

    public void SV_SudioSetupBones(nint pModel, float frame, int sequence, nint angles, nint origin, nint pcontroller, nint pblending, int iBone, nint pEdict)
    {
        _native.SV_StudioSetupBones(pModel, frame, sequence, angles, origin, pcontroller, pblending, iBone, pEdict);
    }
}
