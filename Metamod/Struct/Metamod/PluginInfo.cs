using Metamod.Enum.Metamod;
using Metamod.Native.Metamod;
using System.Runtime.InteropServices;

namespace Metamod.Struct.Metamod;

public class PluginInfo : IDisposable
{
    public required InterfaceVersion InterfaceVersion;             // meta_interface version
    public required string Name;                   // full name of plugin
    public required string Version;                // version
    public required string Date;                   // date
    public required string Author;             // author name/email
    public required string Url;                    // URL
    public required string LogTag;             // log message prefix (unused right now)
    public required PluginLoadTime Loadable;     // when loadable
    public required PluginLoadTime Unloadable;   // when unloadable

    public string GetInterfaceVersionString()
    {
        string str = InterfaceVersion.ToString();
        str = str.Remove(0).Replace('_', ':');
        return str;
    }

    internal NativePluginInfo nativePluginInfo;
    PluginInfo()
    {
        nativePluginInfo = new()
        {
            ifvers = Marshal.StringToHGlobalAnsi(GetInterfaceVersionString()),
            name = Marshal.StringToHGlobalAnsi(Name),
            version = Marshal.StringToHGlobalAnsi(Version),
            date = Marshal.StringToHGlobalAnsi(Date),
            author = Marshal.StringToHGlobalAnsi(Author),
            url = Marshal.StringToHGlobalAnsi(Url),
            logtag = Marshal.StringToHGlobalAnsi(LogTag),
            loadable = (int)Loadable,
            unloadable = (int)Unloadable
        };
    }
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            if (nativePluginInfo.ifvers != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(nativePluginInfo.ifvers);
                nativePluginInfo.ifvers = IntPtr.Zero;
            }
            if (nativePluginInfo.name != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(nativePluginInfo.name);
                nativePluginInfo.name = IntPtr.Zero;
            }
            if (nativePluginInfo.version != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(nativePluginInfo.version);
                nativePluginInfo.version = IntPtr.Zero;
            }
            if (nativePluginInfo.date != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(nativePluginInfo.date);
                nativePluginInfo.date = IntPtr.Zero;
            }
            if (nativePluginInfo.author != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(nativePluginInfo.author);
                nativePluginInfo.author = IntPtr.Zero;
            }
            if (nativePluginInfo.url != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(nativePluginInfo.url);
                nativePluginInfo.url = IntPtr.Zero;
            }
            if (nativePluginInfo.logtag != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(nativePluginInfo.logtag);
                nativePluginInfo.logtag = IntPtr.Zero;
            }
        }
    }
}
