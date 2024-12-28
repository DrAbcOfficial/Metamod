using Metamod.Native.Common;

namespace Metamod.Struct.Common;

public class WeaponData
{
    internal NativeWeaponData nativeWeaponData;

    public int Id
    {
        get => nativeWeaponData.m_iId;
        set => nativeWeaponData.m_iId = value;
    }

    public int Clip
    {
        get => nativeWeaponData.m_iClip;
        set => nativeWeaponData.m_iClip = value;
    }

    public float NextPrimaryAttack
    {
        get => nativeWeaponData.m_flNextPrimaryAttack;
        set => nativeWeaponData.m_flNextPrimaryAttack = value;
    }

    public float NextSecondaryAttack
    {
        get => nativeWeaponData.m_flNextSecondaryAttack;
        set => nativeWeaponData.m_flNextSecondaryAttack = value;
    }

    public float TimeWeaponIdle
    {
        get => nativeWeaponData.m_flTimeWeaponIdle;
        set => nativeWeaponData.m_flTimeWeaponIdle = value;
    }

    public int InReload
    {
        get => nativeWeaponData.m_fInReload;
        set => nativeWeaponData.m_fInReload = value;
    }

    public int InSpecialReload
    {
        get => nativeWeaponData.m_fInSpecialReload;
        set => nativeWeaponData.m_fInSpecialReload = value;
    }

    public float NextReload
    {
        get => nativeWeaponData.m_flNextReload;
        set => nativeWeaponData.m_flNextReload = value;
    }

    public float PumpTime
    {
        get => nativeWeaponData.m_flPumpTime;
        set => nativeWeaponData.m_flPumpTime = value;
    }

    public float ReloadTime
    {
        get => nativeWeaponData.m_fReloadTime;
        set => nativeWeaponData.m_fReloadTime = value;
    }

    public float AimedDamage
    {
        get => nativeWeaponData.m_fAimedDamage;
        set => nativeWeaponData.m_fAimedDamage = value;
    }

    public float NextAimBonus
    {
        get => nativeWeaponData.m_fNextAimBonus;
        set => nativeWeaponData.m_fNextAimBonus = value;
    }

    public int InZoom
    {
        get => nativeWeaponData.m_fInZoom;
        set => nativeWeaponData.m_fInZoom = value;
    }

    public int WeaponState
    {
        get => nativeWeaponData.m_iWeaponState;
        set => nativeWeaponData.m_iWeaponState = value;
    }

    public int IUser1
    {
        get => nativeWeaponData.iuser1;
        set => nativeWeaponData.iuser1 = value;
    }

    public int IUser2
    {
        get => nativeWeaponData.iuser2;
        set => nativeWeaponData.iuser2 = value;
    }

    public int IUser3
    {
        get => nativeWeaponData.iuser3;
        set => nativeWeaponData.iuser3 = value;
    }

    public int IUser4
    {
        get => nativeWeaponData.iuser4;
        set => nativeWeaponData.iuser4 = value;
    }

    public float FUser1
    {
        get => nativeWeaponData.fuser1;
        set => nativeWeaponData.fuser1 = value;
    }

    public float FUser2
    {
        get => nativeWeaponData.fuser2;
        set => nativeWeaponData.fuser2 = value;
    }

    public float FUser3
    {
        get => nativeWeaponData.fuser3;
        set => nativeWeaponData.fuser3 = value;
    }

    public float FUser4
    {
        get => nativeWeaponData.fuser4;
        set => nativeWeaponData.fuser4 = value;
    }

    public override string ToString()
    {
        return $"Id: {Id}, Clip: {Clip}, NextPrimaryAttack: {NextPrimaryAttack}, NextSecondaryAttack: {NextSecondaryAttack}, TimeWeaponIdle: {TimeWeaponIdle}";
    }
}

