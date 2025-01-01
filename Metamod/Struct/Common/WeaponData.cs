using Metamod.Native.Common;

namespace Metamod.Struct.Common;

public class WeaponData(nint ptr) : BaseManaged<NativeWeaponData>(ptr)
{
    public int Id
    {
        get => _native.m_iId;
        set => _native.m_iId = value;
    }

    public int Clip
    {
        get => _native.m_iClip;
        set => _native.m_iClip = value;
    }

    public float NextPrimaryAttack
    {
        get => _native.m_flNextPrimaryAttack;
        set => _native.m_flNextPrimaryAttack = value;
    }

    public float NextSecondaryAttack
    {
        get => _native.m_flNextSecondaryAttack;
        set => _native.m_flNextSecondaryAttack = value;
    }

    public float TimeWeaponIdle
    {
        get => _native.m_flTimeWeaponIdle;
        set => _native.m_flTimeWeaponIdle = value;
    }

    public int InReload
    {
        get => _native.m_fInReload;
        set => _native.m_fInReload = value;
    }

    public int InSpecialReload
    {
        get => _native.m_fInSpecialReload;
        set => _native.m_fInSpecialReload = value;
    }

    public float NextReload
    {
        get => _native.m_flNextReload;
        set => _native.m_flNextReload = value;
    }

    public float PumpTime
    {
        get => _native.m_flPumpTime;
        set => _native.m_flPumpTime = value;
    }

    public float ReloadTime
    {
        get => _native.m_fReloadTime;
        set => _native.m_fReloadTime = value;
    }

    public float AimedDamage
    {
        get => _native.m_fAimedDamage;
        set => _native.m_fAimedDamage = value;
    }

    public float NextAimBonus
    {
        get => _native.m_fNextAimBonus;
        set => _native.m_fNextAimBonus = value;
    }

    public int InZoom
    {
        get => _native.m_fInZoom;
        set => _native.m_fInZoom = value;
    }

    public int WeaponState
    {
        get => _native.m_iWeaponState;
        set => _native.m_iWeaponState = value;
    }

    public int IUser1
    {
        get => _native.iuser1;
        set => _native.iuser1 = value;
    }

    public int IUser2
    {
        get => _native.iuser2;
        set => _native.iuser2 = value;
    }

    public int IUser3
    {
        get => _native.iuser3;
        set => _native.iuser3 = value;
    }

    public int IUser4
    {
        get => _native.iuser4;
        set => _native.iuser4 = value;
    }

    public float FUser1
    {
        get => _native.fuser1;
        set => _native.fuser1 = value;
    }

    public float FUser2
    {
        get => _native.fuser2;
        set => _native.fuser2 = value;
    }

    public float FUser3
    {
        get => _native.fuser3;
        set => _native.fuser3 = value;
    }

    public float FUser4
    {
        get => _native.fuser4;
        set => _native.fuser4 = value;
    }

    public override string ToString()
    {
        return $"Id: {Id}, Clip: {Clip}, NextPrimaryAttack: {NextPrimaryAttack}, NextSecondaryAttack: {NextSecondaryAttack}, TimeWeaponIdle: {TimeWeaponIdle}";
    }
}

