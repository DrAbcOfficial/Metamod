using Metamod.Enum.Metamod;
using Metamod.Interface;
using Metamod.Native.Engine;
using Metamod.Native.Metamod;
using Metamod.Struct.Engine;
using Metamod.Struct.Game;
using System.Runtime.InteropServices;

namespace Metamod.Struct.Metamod;

public class CMetaUtilFuncs(nint ptr) : BaseManaged<NativeMetaUtilFuncs>(ptr)
{
    public void LogConsole(string fmt, params string[] parm)
    {
        string str = string.Format(fmt, parm);
        nint strptr = Marshal.StringToHGlobalAnsi(str);
        unsafe
        {
            _native.pfnLogConsole((NativePluginInfo*)Global.PluginInfo.NavitePtr, (byte*)strptr);
        }
        Marshal.FreeHGlobal(strptr);
    }

    public void LogMessage(string fmt, params string[] parm)
    {
        string str = string.Format(fmt, parm);
        nint strptr = Marshal.StringToHGlobalAnsi(str);
        unsafe
        {
            _native.pfnLogMessage((NativePluginInfo*)Global.PluginInfo.NavitePtr, (byte*)strptr);
        }
        Marshal.FreeHGlobal(strptr);
    }

    public void LogError(string fmt, params string[] parm)
    {
        string str = string.Format(fmt, parm);
        nint strptr = Marshal.StringToHGlobalAnsi(str);
        unsafe
        {
            _native.pfnLogError((NativePluginInfo*)Global.PluginInfo.NavitePtr, (byte*)strptr);
        }
        Marshal.FreeHGlobal(strptr);
    }

    public void LogDeveloper(string fmt, params string[] parm)
    {
        string str = string.Format(fmt, parm);
        nint strptr = Marshal.StringToHGlobalAnsi(str);
        unsafe
        {
            _native.pfnLogDeveloper((NativePluginInfo*)Global.PluginInfo.NavitePtr, (byte*)strptr);
        }
        Marshal.FreeHGlobal(strptr);
    }

    public void CenterSay(string fmt, params string[] parm)
    {
        string str = string.Format(fmt, parm);
        nint strptr = Marshal.StringToHGlobalAnsi(str);
        unsafe
        {
            _native.pfnCenterSay((NativePluginInfo*)Global.PluginInfo.NavitePtr, (byte*)strptr);
        }
        Marshal.FreeHGlobal(strptr);
    }

    public void CenterSayPams(HudParams hudParams, string fmt, params string[] parm)
    {
        string str = string.Format(fmt, parm);
        nint strptr = Marshal.StringToHGlobalAnsi(str);
        unsafe
        {
            _native.pfnCenterSayParms((NativePluginInfo*)Global.PluginInfo.NavitePtr, hudParams._native, (byte*)strptr);
        }
        Marshal.FreeHGlobal(strptr);
    }

    public void CallGameEntity(string entStr, Entvars pev)
    {
        nint strptr = Marshal.StringToHGlobalAnsi(entStr);
        unsafe
        {
#pragma warning disable CS8500 // 这会获取托管类型的地址、获取其大小或声明指向它的指针
            _native.pfnCallGameEntity((NativePluginInfo*)Global.PluginInfo.NavitePtr, (byte*)strptr, (NativeEntvars*)pev.GetUnmanagedPtr());
#pragma warning restore CS8500 // 这会获取托管类型的地址、获取其大小或声明指向它的指针
        }
        Marshal.FreeHGlobal(strptr);
    }

    public int GetUserMessageId(string msgname, out int size)
    {
        nint temp = Marshal.AllocHGlobal(sizeof(int));
        nint strptr = Marshal.StringToHGlobalAnsi(msgname);
        int result = 0;
        unsafe
        {
#pragma warning disable CS8500 // 这会获取托管类型的地址、获取其大小或声明指向它的指针
            result = _native.pfnGetUserMsgID((NativePluginInfo*)Global.PluginInfo.NavitePtr, (byte*)strptr, (int*)temp);
#pragma warning restore CS8500 // 这会获取托管类型的地址、获取其大小或声明指向它的指针
        }
        size = Marshal.ReadInt32(temp);
        Marshal.FreeHGlobal(strptr);
        Marshal.FreeHGlobal(temp);
        return result;
    }

    public string GetUserMessageName(int msgid, out int size)
    {
        nint temp = Marshal.AllocHGlobal(sizeof(int));
        nint result = nint.Zero;
        unsafe
        {
            result = _native.pfnGetUserMsgName((NativePluginInfo*)Global.PluginInfo.NavitePtr, msgid, (int*)temp);
        }
        string? str = Marshal.PtrToStringUTF8(result);
        size = Marshal.ReadInt32(temp);
        Marshal.FreeHGlobal(temp);
        return str ?? string.Empty;
    }

    public string GetPluginPath()
    {
        nint result = nint.Zero;
        unsafe
        {
            result = _native.pfnGetPluginPath((NativePluginInfo*)Global.PluginInfo.NavitePtr);
        }
        string? str = Marshal.PtrToStringUTF8(result);
        return str ?? string.Empty;
    }

    public string GetGameInfo(GetGameInfoType type)
    {
        nint result = nint.Zero;
        unsafe
        {
            result = _native.pfnGetGameInfo((NativePluginInfo*)Global.PluginInfo.NavitePtr, type);
        }
        string? str = Marshal.PtrToStringUTF8(result);
        return str ?? string.Empty;
    }

    public bool LoadPlugin(string cmdline, PluginLoadTime now, out nint pluginHandle)
    {
        nint strptr = Marshal.StringToHGlobalAnsi(cmdline);
        int res = 0;
        unsafe
        {
            res = _native.pfnLoadPlugin((NativePluginInfo*)Global.PluginInfo.NavitePtr, (byte*)strptr, now, out pluginHandle);
        }
        Marshal.FreeHGlobal(strptr);
        return res != 0;
    }

    public bool UnloadPlugin(string cmdline, PluginLoadTime now, PluginUnloadReason reason)
    {
        nint strptr = Marshal.StringToHGlobalAnsi(cmdline);
        int res = 0;
        unsafe
        {
            res = _native.pfnUnloadPlugin((NativePluginInfo*)Global.PluginInfo.NavitePtr, (byte*)strptr, now, reason);
        }
        Marshal.FreeHGlobal(strptr);
        return res != 0;
    }

    public bool UnloadPluginByHandle(nint handle, PluginLoadTime now, PluginUnloadReason reason)
    {
        int res = 0;
        unsafe
        {
            res = _native.pfnUnloadPluginByHandle((NativePluginInfo*)Global.PluginInfo.NavitePtr, handle, now, reason);
        }
        return res != 0;
    }

    public string IsQueryingClientCVar(Edict player)
    {
        nint result = nint.Zero;
        unsafe
        {
#pragma warning disable CS8500 // 这会获取托管类型的地址、获取其大小或声明指向它的指针
            result = _native.pfnIsQueryingClientCvar((NativePluginInfo*)Global.PluginInfo.NavitePtr, (NativeEdict*)player.GetUnmanagedPtr());
#pragma warning restore CS8500 // 这会获取托管类型的地址、获取其大小或声明指向它的指针
        }
        return Marshal.PtrToStringUTF8(result) ?? string.Empty;
    }

    public int MakeRequestID()
    {
        int res = 0;
        unsafe
        {
            res = _native.pfnMakeRequestID((NativePluginInfo*)Global.PluginInfo.NavitePtr);
        }
        return res;
    }

    //TODO: Finish it
    public void GetHookTables(/*out*/ CEngineFuncs peng, /*out*/ int pdll, /*out*/ int pnewdll)
    {

    }

    public nint GetModuleBaseByHandle(nint handle)
    {
        return _native.pfnGetModuleBaseByHandle(handle);
    }

    public nint GetModuleHandle(string modulename)
    {
        nint strptr = Marshal.StringToHGlobalAnsi(modulename);
        nint result = nint.Zero;
        unsafe
        {
            result = _native.pfnGetModuleHandle((byte*)strptr);
        }
        Marshal.FreeHGlobal(strptr);
        return result;
    }

    public nint GetModuleBaseByName(string name)
    {
        nint strptr = Marshal.StringToHGlobalAnsi(name);
        nint result = nint.Zero;
        unsafe
        {
            result = _native.pfnGetModuleBaseByName((byte*)strptr);
        }
        Marshal.FreeHGlobal(strptr);
        return result;
    }

    public uint GetImageSize(nint imageBase)
    {
        return _native.pfnGetImageSize(imageBase);
    }

    public bool IsAddressInModuleRange(nint lpAddress, nint lpModuleBase)
    {
        return _native.pfnIsAddressInModuleRange(lpAddress, lpModuleBase) == QBoolean.TRUE;
    }

    public nint GetGameDllHandle()
    {
        return _native.pfnGetGameDllHandle();
    }

    public nint GetGameDllBase()
    {
        return _native.pfnGetGameDllBase();
    }

    public nint GetEngineHandle()
    {
        return _native.pfnGetEngineHandle();
    }

    public nint GetEngineBase()
    {
        return _native.pfnGetEngineBase();
    }

    public nint GetEngineEnd()
    {
        return _native.pfnGetEngineEnd();
    }

    public nint GetEngineCodeBase()
    {
        return _native.pfnGetEngineCodeBase();
    }

    public nint GetEngineCodeEnd()
    {
        return _native.pfnGetEngineCodeEnd();
    }

    public bool IsValidCodePointerInEngine(nint ptr)
    {
        return _native.pfnIsValidCodePointerInEngine(ptr) == QBoolean.TRUE;
    }

    public bool UnHook(Hook pHook)
    {
        bool res = false;
        unsafe
        {
            res = _native.pfnUnHook(pHook._native) == QBoolean.TRUE;
        }
        return res;
    }

    public Hook InlineHook(nint pOldFuncAddr, nint pNewFuncAddr, out nint pOrigialCall, bool bTranscation)
    {
        nint ptr = nint.Zero;
        unsafe
        {
            ptr = (nint)_native.pfnInlineHook(pOldFuncAddr, pNewFuncAddr, out pOrigialCall, bTranscation);
        }
        return new Hook(ptr);
    }

    public nint GetNextCallAddr(nint pAddress, int dwCout)
    {
        return _native.pfnGetNextCallAddr(pAddress, dwCout);
    }

    public nint SearchPattern(nint pStartSearch, uint dwSearchLen, byte[] szPattern, uint dwPatternLen)
    {
        nint result = nint.Zero;
        unsafe
        {
            fixed (byte* pPattern = szPattern)
            {
                result = _native.pfnSearchPattern(pStartSearch, dwSearchLen, pPattern, dwPatternLen);
            }
        }
        return result;
    }

    public nint ReverseSearchPattern(nint pStartSearch, uint dwSearchLen, byte[] szPattern, uint dwPatternLen)
    {
        nint result = nint.Zero;
        unsafe
        {
            fixed (byte* pPattern = szPattern)
            {
                result = _native.pfnReverseSearchPattern(pStartSearch, dwSearchLen, pPattern, dwPatternLen);
            }
        }
        return result;
    }

    public int DisasmSingleInstruction(nint address, DisasmSingleCallbackDelegate fnDisasmSingleCallback, nint context)
    {
        nint ptr = Marshal.GetFunctionPointerForDelegate(fnDisasmSingleCallback);
        return _native.pfnDisasmSingleInstruction(address, ptr, context); ;
    }

    public bool DisasmRange(nint disasmBase, uint disasmSize, DisasmCallbackDelegate fnDisasmCallback, int depth, nint context)
    {
        nint ptr = Marshal.GetFunctionPointerForDelegate(fnDisasmCallback);
        return _native.pfnDisasmRanges(disasmBase, disasmSize, ptr, depth, context) == QBoolean.TRUE;
    }

    public nint ReverseSearchFunctionBegin(nint searchBegin, uint searchSize)
    {
        return _native.pfnReverseSearchFunctionBegin(searchBegin, searchSize);
    }

    public nint ReverseSearchFuntionBeginEx(nint searchBegin, uint searchSize, FindAddressCallbackDelegate findAddressCallback)
    {
        nint ptr = Marshal.GetFunctionPointerForDelegate(findAddressCallback);
        return _native.pfnReverseSearchFunctionBeginEx(searchBegin, searchSize, ptr);
    }

    public void CloseModuleHandle(nint hModule)
    {
        _native.pfnCloseModuleHandle(hModule);
    }

    public nint LoadLibrary(string szModuleName)
    {
        nint strptr = Marshal.StringToHGlobalAnsi(szModuleName);
        nint result = nint.Zero;
        unsafe
        {
            result = _native.pfnLoadLibrary((byte*)strptr);
        }
        Marshal.FreeHGlobal(strptr);
        return result;
    }

    public void FreeLibrary(nint hModule)
    {
        _native.pfnFreeLibrary(hModule);
    }

    public nint GetProcAddress(nint hModule, string szProcName)
    {
        nint strptr = Marshal.StringToHGlobalAnsi(szProcName);
        nint result = nint.Zero;
        unsafe
        {
            result = _native.pfnGetProcAddress(hModule, (byte*)strptr);
        }
        Marshal.FreeHGlobal(strptr);
        return result;
    }

    public ServerBlendInterface GetServerStudioBlendInterface()
    {
        nint ptr = nint.Zero;
        unsafe
        {
            ptr = (nint)_native.pfnGetServerStudioBlendInterface();
        }
        return new ServerBlendInterface(ptr);
    }

    public ServerBlendInterface GetEngineStudioBlendInterface()
    {
        nint ptr = nint.Zero;
        unsafe
        {
            ptr = (nint)_native.pfnGetServerStudioBlendInterface();
        }
        return new ServerBlendInterface(ptr);
    }

    public ServerStudioAPI GetEngineStudioAPI()
    {
        nint ptr = nint.Zero;
        unsafe
        {
            ptr = (nint)_native.pfnGetEngineStudioAPI();
        }
        return new ServerStudioAPI(ptr);
    }

    public nint GetRotationMatrix() => _native.pfnGetRotationMatrix();
    public nint GetBoneMatrix() => _native.pfnGetBoneMatrix();

    public string GetEngineType()
    {
        string? str = string.Empty;
        unsafe
        {
            str = Marshal.PtrToStringUTF8((nint)_native.pfnGetEngineType());
        }
        return str ?? string.Empty;
    }
}
