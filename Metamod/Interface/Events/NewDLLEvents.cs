using Metamod.Native.Game;
using Metamod.Struct.Engine;
using System.Runtime.InteropServices;

namespace Metamod.Interface.Events;

#region delegates
#region new dll functions
public delegate void OnFreeEntPrivateDataDelegate(Edict pEnt);
public delegate void GameShutdownDelegate();
public delegate int ShouldCollideDelegate(Edict pentTouched, Edict pentOther);
public delegate void CvarValueDelegate(Edict pEnt, string value);
public delegate void CvarValue2Delegate(Edict pEnt, int requestID, string cvarName, string value);
#endregion
#endregion

public class NewDLLEvents
{
    #region new dll functions
    public event OnFreeEntPrivateDataDelegate? OnFreeEntPrivateData;
    public event GameShutdownDelegate? GameShutdown;
    public event ShouldCollideDelegate? ShouldCollide;
    public event CvarValueDelegate? CvarValue;
    public event CvarValue2Delegate? CvarValue2;
    #endregion

    #region Invoker
    internal void InvokeOnFreeEntPrivateData(Edict pEnt)
    {
        OnFreeEntPrivateData?.Invoke(pEnt);
    }
    internal void InvokeGameShutdown()
    {
        GameShutdown?.Invoke();
    }
    internal int InvokeShouldCollide(Edict pentTouched, Edict pentOther)
    {
        return ShouldCollide?.Invoke(pentTouched, pentOther) ?? 0;
    }
    internal void InvokeCvarValue(Edict pEnt, string value)
    {
        CvarValue?.Invoke(pEnt, value);
    }
    internal void InvokeCvarValue2(Edict pEnt, int requestID, string cvarName, string value)
    {
        CvarValue2?.Invoke(pEnt, requestID, cvarName, value);
    }
    #endregion

    #region Null Checker
    internal bool IsOnFreeEntPrivateDataNull => OnFreeEntPrivateData == null;
    internal bool IsGameShutdownNull => GameShutdown == null;
    internal bool IsShouldCollideNull => ShouldCollide == null;
    internal bool IsCvarValueNull => CvarValue == null;
    internal bool IsCvarValue2Null => CvarValue2 == null;
    #endregion
}