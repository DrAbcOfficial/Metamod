using Metamod.Native.Game;
using Metamod.Struct.Engine;
using System.Runtime.InteropServices;

namespace Metamod.Interface;

public delegate void OnFreeEntPrivateDataDelegate(Edict pEnt);
public delegate void GameShutdownDelegate();
public delegate int ShouldCollideDelegate(Edict pentTouched, Edict pentOther);
public delegate void CvarValueDelegate(Edict pEnt, string value);
public delegate void CvarValue2Delegate(Edict pEnt, int requestID, string cvarName, string value);

public class NewDllFunctions
{
    public static OnFreeEntPrivateDataDelegate? pfnOnFreeEntPrivateData;
    public static GameShutdownDelegate? pfnGameShutdown;
    public static ShouldCollideDelegate? pfnShouldCollide;
    public static CvarValueDelegate? pfnCvarValue;
    public static CvarValue2Delegate? pfnCvarValue2;

    internal static NativeOnFreeEntPrivateDataDelegate nativeOnFreeEntPrivateDataCaller = (nint pEnt) =>
    {
        pfnOnFreeEntPrivateData?.Invoke(new(pEnt));
    };
    internal static NativeGameShutdownDelegate nativeGameShutdown = () =>
    {
        pfnGameShutdown?.Invoke();
    };
    internal static NativeShouldCollideDelegate nativeShouldCollide = (nint pentTouched, nint pentOther) =>
    {
        if (pfnShouldCollide != null)
            return pfnShouldCollide.Invoke(new(pentTouched), new(pentOther));
        return 0;
    };
    internal static NativeCvarValueDelegate nativeCvarValue = (nint pEnt, nint value) =>
    {
        if (pfnCvarValue != null)
        {
            string str = Marshal.PtrToStringAnsi(value) ?? string.Empty;
            pfnCvarValue.Invoke(new(pEnt), str);
        }
    };
    internal static NativeCvarValue2Delegate nativeCvarValue2 = (nint pEnt, int requestID, nint cvarName, nint value) =>
    {
        if (pfnCvarValue2 != null)
        {
            string name = Marshal.PtrToStringAnsi(cvarName) ?? string.Empty;
            string v = Marshal.PtrToStringAnsi(value) ?? string.Empty;
            pfnCvarValue2.Invoke(new(pEnt), requestID, name, v);
        }
    };
    public static NativeNewDllFuncs GetNativeTable()
    {
#pragma warning disable CS8601 // 引用类型赋值可能为 null。
        return new()
        {
            pfnOnFreeEntPrivateData = pfnOnFreeEntPrivateData == null ? null : nativeOnFreeEntPrivateDataCaller,
            pfnGameShutdown = pfnGameShutdown == null ? null : nativeGameShutdown,
            pfnShouldCollide = pfnShouldCollide == null ? null : nativeShouldCollide,
            pfnCvarValue = pfnCvarValue == null ? null : nativeCvarValue,
            pfnCvarValue2 = pfnCvarValue2 == null ? null : nativeCvarValue2
        };
#pragma warning restore CS8601 // 引用类型赋值可能为 null。
    }
}

public class NewDllFunctions_Post
{
    public static OnFreeEntPrivateDataDelegate? pfnOnFreeEntPrivateData;
    public static GameShutdownDelegate? pfnGameShutdown;
    public static ShouldCollideDelegate? pfnShouldCollide;
    public static CvarValueDelegate? pfnCvarValue;
    public static CvarValue2Delegate? pfnCvarValue2;

    internal static NativeOnFreeEntPrivateDataDelegate nativeOnFreeEntPrivateDataCaller = (nint pEnt) =>
    {
        pfnOnFreeEntPrivateData?.Invoke(new(pEnt));
    };
    internal static NativeGameShutdownDelegate nativeGameShutdown = () =>
    {
        pfnGameShutdown?.Invoke();
    };
    internal static NativeShouldCollideDelegate nativeShouldCollide = (nint pentTouched, nint pentOther) =>
    {
        if (pfnShouldCollide != null)
            return pfnShouldCollide.Invoke(new(pentTouched), new(pentOther));
        return 0;
    };
    internal static NativeCvarValueDelegate nativeCvarValue = (nint pEnt, nint value) =>
    {
        if (pfnCvarValue != null)
        {
            string str = Marshal.PtrToStringAnsi(value) ?? string.Empty;
            pfnCvarValue.Invoke(new(pEnt), str);
        }
    };
    internal static NativeCvarValue2Delegate nativeCvarValue2 = (nint pEnt, int requestID, nint cvarName, nint value) =>
    {
        if (pfnCvarValue2 != null)
        {
            string name = Marshal.PtrToStringAnsi(cvarName) ?? string.Empty;
            string v = Marshal.PtrToStringAnsi(value) ?? string.Empty;
            pfnCvarValue2.Invoke(new(pEnt), requestID, name, v);
        }
    };
    public static NativeNewDllFuncs GetNativeTable()
    {
#pragma warning disable CS8601 // 引用类型赋值可能为 null。
        return new()
        {
            pfnOnFreeEntPrivateData = pfnOnFreeEntPrivateData == null ? null : nativeOnFreeEntPrivateDataCaller,
            pfnGameShutdown = pfnGameShutdown == null ? null : nativeGameShutdown,
            pfnShouldCollide = pfnShouldCollide == null ? null : nativeShouldCollide,
            pfnCvarValue = pfnCvarValue == null ? null : nativeCvarValue,
            pfnCvarValue2 = pfnCvarValue2 == null ? null : nativeCvarValue2
        };
#pragma warning restore CS8601 // 引用类型赋值可能为 null。
    }
}