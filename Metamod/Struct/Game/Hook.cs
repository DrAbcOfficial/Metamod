using Metamod.Native.Game;
using System.Runtime.InteropServices;

namespace Metamod.Struct.Game;

public class Hook(nint ptr) : BaseManaged<NativeHook>(ptr)
{
    public int Type
    {
        get => _native.iType;
        set => _native.iType = value;
    }

    public int Committed
    {
        get => _native.bCommitted;
        set => _native.bCommitted = value;
    }

    public nint OldFuncAddr
    {
        get => _native.pOldFuncAddr;
        set => _native.pOldFuncAddr = value;
    }

    public nint NewFuncAddr
    {
        get => _native.pNewFuncAddr;
        set => _native.pNewFuncAddr = value;
    }

    public nint OriginalCall
    {
        get => _native.pOrginalCall;
        set => _native.pOrginalCall = value;
    }

    public nint Class
    {
        get => _native.pClass;
        set => _native.pClass = value;
    }

    public int TableIndex
    {
        get => _native.iTableIndex;
        set => _native.iTableIndex = value;
    }

    public int FuncIndex
    {
        get => _native.iFuncIndex;
        set => _native.iFuncIndex = value;
    }

    public nint Module
    {
        get => _native.hModule;
        set => _native.hModule = value;
    }

    public string ModuleName
    {
        get => Marshal.PtrToStringUTF8(_native.pszModuleName) ?? string.Empty;
    }

    public string FuncName
    {
        get => Marshal.PtrToStringUTF8(_native.pszFuncName) ?? string.Empty;
    }

    public Hook Next
    {
        get
        {
            return new Hook(_native.pNext);
        }
        set => _native.pNext = value._native.pNext;
    }

    public nint Info
    {
        get => _native.pInfo;
        set => _native.pInfo = value;
    }
}
