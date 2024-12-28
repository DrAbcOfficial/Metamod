﻿using System.Runtime.InteropServices;

namespace Metamod.Native.Metamod;

[StructLayout(LayoutKind.Sequential)]
internal struct NativePluginInfo
{
    internal nint ifvers;             // meta_interface version
    internal nint name;                   // full name of plugin
    internal nint version;                // version
    internal nint date;                   // date
    internal nint author;             // author name/email
    internal nint url;                    // URL
    internal nint logtag;             // log message prefix (unused right now)
    internal int loadable;     // when loadable
    internal int unloadable;   // when unloadable
};