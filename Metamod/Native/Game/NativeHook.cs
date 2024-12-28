using System.Runtime.InteropServices;

namespace Metamod.Native.Game;

[StructLayout(LayoutKind.Sequential)]
internal unsafe struct NativeHook
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
    internal byte* pszModuleName;
    internal byte* pszFuncName;
    internal NativeHook* pNext;
    internal nint pInfo;
};
