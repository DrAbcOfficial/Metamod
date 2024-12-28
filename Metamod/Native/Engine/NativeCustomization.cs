﻿using Metamod.Enum.Metamod;
using System.Runtime.InteropServices;

namespace Metamod.Native.Engine;


[StructLayout(LayoutKind.Sequential)]
internal unsafe struct NativeCustomization
{
    internal QBoolean bInUse;     // Is this customization in use;
    internal NativeResource resource; // The resource_t for this customization
    internal QBoolean bTranslated; // Has the raw data been translated into a useable format?  
                                   //  (e.g., raw decal .wad make into texture_t *)
    internal int nUserData1; // Customization specific data
    internal int nUserData2; // Customization specific data
    internal nint pInfo;          // Buffer that holds the data structure that references the data (e.g., the cachewad_t)
    internal nint pBuffer;       // Buffer that holds the data for the customization (the raw .wad data)
    internal NativeCustomization* pNext; // Next in chain
}