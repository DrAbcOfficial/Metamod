﻿using System.Runtime.InteropServices;

namespace Metamod.Native.Game;

[StructLayout(LayoutKind.Sequential)]
public struct NativeHook
{
    internal int iType;
    internal int bCommitted;
    internal nint pOldFuncAddr;
    internal nint pNewFuncAddr;
    internal nint pOrginalCall;
    internal nint pClass;
    internal int iTableIndex;
    internal int iFuncIndex;
    internal nint hModule;
    internal nint pszModuleName;
    internal nint pszFuncName;
    internal nint pNext;
    internal nint pInfo;
};
