using Metamod.Native.Game;
using System.Runtime.InteropServices;

namespace Metamod.Struct.Game;

public class ServerStudioAPI : BaseManaged<NativeServerStudioAPI>
{
    internal ServerStudioAPI(nint ptr) : base(ptr) { }

    public nint MemCalloc(int number, uint size) => _native.Mem_Calloc(number, size);
    public nint CacheCheck(nint cacheUser) => _native.Cache_Check(cacheUser);
    public void LoadCacheFile(string path, nint cacheUser)
    {
        nint ptr = Marshal.StringToHGlobalAnsi(path);
        unsafe
        {
            _native.LoadCacheFile((byte*)ptr, cacheUser);
        }
        Marshal.FreeHGlobal(ptr);
    }
    public nint ModExtradata(nint model) => _native.Mod_Extradata(model);
}
