using Metamod.Native.Common;
using System.Runtime.InteropServices;
using System.Text;

namespace Metamod.Struct.Common;

public class ClientData(nint ptr) : BaseManaged<NativeClientData>(ptr)
{
    // cached offsets
    private static readonly int OffOrigin;
    private static readonly int OffVelocity;
    private static readonly int OffPunchAngle;
    private static readonly int OffViewOfs;
    private static readonly int OffVUser1;
    private static readonly int OffVUser2;
    private static readonly int OffVUser3;
    private static readonly int OffVUser4;

    private static readonly int OffStartposInVector; // offset of startpos inside NativeVector3f

    private static readonly int OffViewModel;
    private static readonly int OffFlags;
    private static readonly int OffWaterLevel;
    private static readonly int OffWaterType;
    private static readonly int OffHealth;
    private static readonly int OffBInDuck;
    private static readonly int OffWeapons;
    private static readonly int OffFlTimeStepSound;
    private static readonly int OffFlDuckTime;
    private static readonly int OffFlSwimTime;
    private static readonly int OffWaterJumpTime;
    private static readonly int OffMaxSpeed;
    private static readonly int OffFov;
    private static readonly int OffWeaponAnim;
    private static readonly int OffMId;
    private static readonly int OffAmmoShells;
    private static readonly int OffAmmoNails;
    private static readonly int OffAmmoCells;
    private static readonly int OffAmmoRockets;
    private static readonly int OffMFlNextAttack;
    private static readonly int OffTfState;
    private static readonly int OffPushMsec;
    private static readonly int OffDeadFlag;
    private static readonly int OffPhysInfo;
    private static readonly int PhysInfoSize;
    private static readonly int OffIUser1;
    private static readonly int OffIUser2;
    private static readonly int OffIUser3;
    private static readonly int OffIUser4;
    private static readonly int OffFUser1;
    private static readonly int OffFUser2;
    private static readonly int OffFUser3;
    private static readonly int OffFUser4;

    static ClientData()
    {
        OffOrigin = Marshal.OffsetOf<NativeClientData>(nameof(NativeClientData.origin)).ToInt32();
        OffVelocity = Marshal.OffsetOf<NativeClientData>(nameof(NativeClientData.velocity)).ToInt32();
        OffPunchAngle = Marshal.OffsetOf<NativeClientData>(nameof(NativeClientData.punchangle)).ToInt32();
        OffViewOfs = Marshal.OffsetOf<NativeClientData>(nameof(NativeClientData.view_ofs)).ToInt32();
        OffVUser1 = Marshal.OffsetOf<NativeClientData>(nameof(NativeClientData.vuser1)).ToInt32();
        OffVUser2 = Marshal.OffsetOf<NativeClientData>(nameof(NativeClientData.vuser2)).ToInt32();
        OffVUser3 = Marshal.OffsetOf<NativeClientData>(nameof(NativeClientData.vuser3)).ToInt32();
        OffVUser4 = Marshal.OffsetOf<NativeClientData>(nameof(NativeClientData.vuser4)).ToInt32();

        OffStartposInVector = Marshal.OffsetOf<NativeVector3f>(nameof(NativeVector3f.startpos)).ToInt32();

        OffViewModel = Marshal.OffsetOf<NativeClientData>(nameof(NativeClientData.viewmodel)).ToInt32();
        OffFlags = Marshal.OffsetOf<NativeClientData>(nameof(NativeClientData.flags)).ToInt32();
        OffWaterLevel = Marshal.OffsetOf<NativeClientData>(nameof(NativeClientData.waterlevel)).ToInt32();
        OffWaterType = Marshal.OffsetOf<NativeClientData>(nameof(NativeClientData.watertype)).ToInt32();
        OffHealth = Marshal.OffsetOf<NativeClientData>(nameof(NativeClientData.health)).ToInt32();
        OffBInDuck = Marshal.OffsetOf<NativeClientData>(nameof(NativeClientData.bInDuck)).ToInt32();
        OffWeapons = Marshal.OffsetOf<NativeClientData>(nameof(NativeClientData.weapons)).ToInt32();
        OffFlTimeStepSound = Marshal.OffsetOf<NativeClientData>(nameof(NativeClientData.flTimeStepSound)).ToInt32();
        OffFlDuckTime = Marshal.OffsetOf<NativeClientData>(nameof(NativeClientData.flDuckTime)).ToInt32();
        OffFlSwimTime = Marshal.OffsetOf<NativeClientData>(nameof(NativeClientData.flSwimTime)).ToInt32();
        OffWaterJumpTime = Marshal.OffsetOf<NativeClientData>(nameof(NativeClientData.waterjumptime)).ToInt32();
        OffMaxSpeed = Marshal.OffsetOf<NativeClientData>(nameof(NativeClientData.maxspeed)).ToInt32();
        OffFov = Marshal.OffsetOf<NativeClientData>(nameof(NativeClientData.fov)).ToInt32();
        OffWeaponAnim = Marshal.OffsetOf<NativeClientData>(nameof(NativeClientData.weaponanim)).ToInt32();
        OffMId = Marshal.OffsetOf<NativeClientData>(nameof(NativeClientData.m_iId)).ToInt32();
        OffAmmoShells = Marshal.OffsetOf<NativeClientData>(nameof(NativeClientData.ammo_shells)).ToInt32();
        OffAmmoNails = Marshal.OffsetOf<NativeClientData>(nameof(NativeClientData.ammo_nails)).ToInt32();
        OffAmmoCells = Marshal.OffsetOf<NativeClientData>(nameof(NativeClientData.ammo_cells)).ToInt32();
        OffAmmoRockets = Marshal.OffsetOf<NativeClientData>(nameof(NativeClientData.ammo_rockets)).ToInt32();
        OffMFlNextAttack = Marshal.OffsetOf<NativeClientData>(nameof(NativeClientData.m_flNextAttack)).ToInt32();
        OffTfState = Marshal.OffsetOf<NativeClientData>(nameof(NativeClientData.tfstate)).ToInt32();
        OffPushMsec = Marshal.OffsetOf<NativeClientData>(nameof(NativeClientData.pushmsec)).ToInt32();
        OffDeadFlag = Marshal.OffsetOf<NativeClientData>(nameof(NativeClientData.deadflag)).ToInt32();
        OffPhysInfo = Marshal.OffsetOf<NativeClientData>(nameof(NativeClientData.physinfo)).ToInt32();
        PhysInfoSize = 256; // 与 NativeClientData 中 SizeConst 保持一致
        OffIUser1 = Marshal.OffsetOf<NativeClientData>(nameof(NativeClientData.iuser1)).ToInt32();
        OffIUser2 = Marshal.OffsetOf<NativeClientData>(nameof(NativeClientData.iuser2)).ToInt32();
        OffIUser3 = Marshal.OffsetOf<NativeClientData>(nameof(NativeClientData.iuser3)).ToInt32();
        OffIUser4 = Marshal.OffsetOf<NativeClientData>(nameof(NativeClientData.iuser4)).ToInt32();
        OffFUser1 = Marshal.OffsetOf<NativeClientData>(nameof(NativeClientData.fuser1)).ToInt32();
        OffFUser2 = Marshal.OffsetOf<NativeClientData>(nameof(NativeClientData.fuser2)).ToInt32();
        OffFUser3 = Marshal.OffsetOf<NativeClientData>(nameof(NativeClientData.fuser3)).ToInt32();
        OffFUser4 = Marshal.OffsetOf<NativeClientData>(nameof(NativeClientData.fuser4)).ToInt32();
    }

    // helper to get base unmanaged pointer without synchronization
    private nint BasePtr => GetRawUnmanagedPtr();

    private void EnsurePtr()
    {
        if (BasePtr == nint.Zero)
            throw new InvalidOperationException("Underlying unmanaged pointer is zero.");
    }

    private static Vector3f ReadVectorFromPointer(IntPtr p)
    {
        if (p == IntPtr.Zero) return new Vector3f();
        var x = BitConverter.Int32BitsToSingle(Marshal.ReadInt32(p, 0));
        var y = BitConverter.Int32BitsToSingle(Marshal.ReadInt32(p, 4));
        var z = BitConverter.Int32BitsToSingle(Marshal.ReadInt32(p, 8));
        return new Vector3f(x, y, z);
    }

    private static void WriteVectorToPointer(IntPtr p, Vector3f v)
    {
        if (p == IntPtr.Zero) throw new InvalidOperationException("vector startpos pointer is null.");
        Marshal.WriteInt32(p, 0, BitConverter.SingleToInt32Bits(v.X));
        Marshal.WriteInt32(p, 4, BitConverter.SingleToInt32Bits(v.Y));
        Marshal.WriteInt32(p, 8, BitConverter.SingleToInt32Bits(v.Z));
    }

    private IntPtr ReadVectorStartPtr(int vectorFieldOffset)
    {
        EnsurePtr();
        return Marshal.ReadIntPtr(new IntPtr(BasePtr), vectorFieldOffset + OffStartposInVector);
    }

    private Vector3f ReadVectorField(int vectorFieldOffset)
    {
        var start = ReadVectorStartPtr(vectorFieldOffset);
        return ReadVectorFromPointer(start);
    }

    private void WriteVectorField(int vectorFieldOffset, Vector3f v)
    {
        var start = ReadVectorStartPtr(vectorFieldOffset);
        WriteVectorToPointer(start, v);
    }

    // Properties — 直接按偏移读写非托管内存

    public Vector3f Origin
    {
        get => ReadVectorField(OffOrigin);
        set => WriteVectorField(OffOrigin, value);
    }

    public Vector3f Velocity
    {
        get => ReadVectorField(OffVelocity);
        set => WriteVectorField(OffVelocity, value);
    }

    public int ViewModel
    {
        get { EnsurePtr(); return Marshal.ReadInt32(new IntPtr(BasePtr), OffViewModel); }
        set { EnsurePtr(); Marshal.WriteInt32(new IntPtr(BasePtr), OffViewModel, value); }
    }

    public Vector3f PunchAngle
    {
        get => ReadVectorField(OffPunchAngle);
        set => WriteVectorField(OffPunchAngle, value);
    }

    public int Flags
    {
        get { EnsurePtr(); return Marshal.ReadInt32(new IntPtr(BasePtr), OffFlags); }
        set { EnsurePtr(); Marshal.WriteInt32(new IntPtr(BasePtr), OffFlags, value); }
    }

    public int WaterLevel
    {
        get { EnsurePtr(); return Marshal.ReadInt32(new IntPtr(BasePtr), OffWaterLevel); }
        set { EnsurePtr(); Marshal.WriteInt32(new IntPtr(BasePtr), OffWaterLevel, value); }
    }

    public int WaterType
    {
        get { EnsurePtr(); return Marshal.ReadInt32(new IntPtr(BasePtr), OffWaterType); }
        set { EnsurePtr(); Marshal.WriteInt32(new IntPtr(BasePtr), OffWaterType, value); }
    }

    public Vector3f ViewOfs
    {
        get => ReadVectorField(OffViewOfs);
        set => WriteVectorField(OffViewOfs, value);
    }

    public float Health
    {
        get { EnsurePtr(); return BitConverter.Int32BitsToSingle(Marshal.ReadInt32(new IntPtr(BasePtr), OffHealth)); }
        set { EnsurePtr(); Marshal.WriteInt32(new IntPtr(BasePtr), OffHealth, BitConverter.SingleToInt32Bits(value)); }
    }

    public int BInDuck
    {
        get { EnsurePtr(); return Marshal.ReadInt32(new IntPtr(BasePtr), OffBInDuck); }
        set { EnsurePtr(); Marshal.WriteInt32(new IntPtr(BasePtr), OffBInDuck, value); }
    }

    public int Weapons
    {
        get { EnsurePtr(); return Marshal.ReadInt32(new IntPtr(BasePtr), OffWeapons); }
        set { EnsurePtr(); Marshal.WriteInt32(new IntPtr(BasePtr), OffWeapons, value); }
    }

    public int FlTimeStepSound
    {
        get { EnsurePtr(); return Marshal.ReadInt32(new IntPtr(BasePtr), OffFlTimeStepSound); }
        set { EnsurePtr(); Marshal.WriteInt32(new IntPtr(BasePtr), OffFlTimeStepSound, value); }
    }

    public int FlDuckTime
    {
        get { EnsurePtr(); return Marshal.ReadInt32(new IntPtr(BasePtr), OffFlDuckTime); }
        set { EnsurePtr(); Marshal.WriteInt32(new IntPtr(BasePtr), OffFlDuckTime, value); }
    }

    public int FlSwimTime
    {
        get { EnsurePtr(); return Marshal.ReadInt32(new IntPtr(BasePtr), OffFlSwimTime); }
        set { EnsurePtr(); Marshal.WriteInt32(new IntPtr(BasePtr), OffFlSwimTime, value); }
    }

    public int WaterJumpTime
    {
        get { EnsurePtr(); return Marshal.ReadInt32(new IntPtr(BasePtr), OffWaterJumpTime); }
        set { EnsurePtr(); Marshal.WriteInt32(new IntPtr(BasePtr), OffWaterJumpTime, value); }
    }

    public float MaxSpeed
    {
        get { EnsurePtr(); return BitConverter.Int32BitsToSingle(Marshal.ReadInt32(new IntPtr(BasePtr), OffMaxSpeed)); }
        set { EnsurePtr(); Marshal.WriteInt32(new IntPtr(BasePtr), OffMaxSpeed, BitConverter.SingleToInt32Bits(value)); }
    }

    public float Fov
    {
        get { EnsurePtr(); return BitConverter.Int32BitsToSingle(Marshal.ReadInt32(new IntPtr(BasePtr), OffFov)); }
        set { EnsurePtr(); Marshal.WriteInt32(new IntPtr(BasePtr), OffFov, BitConverter.SingleToInt32Bits(value)); }
    }

    public int WeaponAnim
    {
        get { EnsurePtr(); return Marshal.ReadInt32(new IntPtr(BasePtr), OffWeaponAnim); }
        set { EnsurePtr(); Marshal.WriteInt32(new IntPtr(BasePtr), OffWeaponAnim, value); }
    }

    public int MId
    {
        get { EnsurePtr(); return Marshal.ReadInt32(new IntPtr(BasePtr), OffMId); }
        set { EnsurePtr(); Marshal.WriteInt32(new IntPtr(BasePtr), OffMId, value); }
    }

    public int AmmoShells
    {
        get { EnsurePtr(); return Marshal.ReadInt32(new IntPtr(BasePtr), OffAmmoShells); }
        set { EnsurePtr(); Marshal.WriteInt32(new IntPtr(BasePtr), OffAmmoShells, value); }
    }

    public int AmmoNails
    {
        get { EnsurePtr(); return Marshal.ReadInt32(new IntPtr(BasePtr), OffAmmoNails); }
        set { EnsurePtr(); Marshal.WriteInt32(new IntPtr(BasePtr), OffAmmoNails, value); }
    }

    public int AmmoCells
    {
        get { EnsurePtr(); return Marshal.ReadInt32(new IntPtr(BasePtr), OffAmmoCells); }
        set { EnsurePtr(); Marshal.WriteInt32(new IntPtr(BasePtr), OffAmmoCells, value); }
    }

    public int AmmoRockets
    {
        get { EnsurePtr(); return Marshal.ReadInt32(new IntPtr(BasePtr), OffAmmoRockets); }
        set { EnsurePtr(); Marshal.WriteInt32(new IntPtr(BasePtr), OffAmmoRockets, value); }
    }

    public float MFlNextAttack
    {
        get { EnsurePtr(); return BitConverter.Int32BitsToSingle(Marshal.ReadInt32(new IntPtr(BasePtr), OffMFlNextAttack)); }
        set { EnsurePtr(); Marshal.WriteInt32(new IntPtr(BasePtr), OffMFlNextAttack, BitConverter.SingleToInt32Bits(value)); }
    }

    public int TfState
    {
        get { EnsurePtr(); return Marshal.ReadInt32(new IntPtr(BasePtr), OffTfState); }
        set { EnsurePtr(); Marshal.WriteInt32(new IntPtr(BasePtr), OffTfState, value); }
    }

    public int PushMsec
    {
        get { EnsurePtr(); return Marshal.ReadInt32(new IntPtr(BasePtr), OffPushMsec); }
        set { EnsurePtr(); Marshal.WriteInt32(new IntPtr(BasePtr), OffPushMsec, value); }
    }

    public int DeadFlag
    {
        get { EnsurePtr(); return Marshal.ReadInt32(new IntPtr(BasePtr), OffDeadFlag); }
        set { EnsurePtr(); Marshal.WriteInt32(new IntPtr(BasePtr), OffDeadFlag, value); }
    }

    public string PhysInfo
    {
        get
        {
            EnsurePtr();
            var buf = new byte[PhysInfoSize];
            Marshal.Copy(IntPtr.Add(new IntPtr(BasePtr), OffPhysInfo), buf, 0, PhysInfoSize);
            return Encoding.UTF8.GetString(buf).TrimEnd('\0');
        }
        set
        {
            EnsurePtr();
            var bytes = Encoding.UTF8.GetBytes(value);
            var buf = new byte[PhysInfoSize];
            Array.Clear(buf, 0, buf.Length);
            Array.Copy(bytes, buf, Math.Min(bytes.Length, buf.Length));
            Marshal.Copy(buf, 0, IntPtr.Add(new IntPtr(BasePtr), OffPhysInfo), PhysInfoSize);
        }
    }

    public int IUser1
    {
        get { EnsurePtr(); return Marshal.ReadInt32(new IntPtr(BasePtr), OffIUser1); }
        set { EnsurePtr(); Marshal.WriteInt32(new IntPtr(BasePtr), OffIUser1, value); }
    }

    public int IUser2
    {
        get { EnsurePtr(); return Marshal.ReadInt32(new IntPtr(BasePtr), OffIUser2); }
        set { EnsurePtr(); Marshal.WriteInt32(new IntPtr(BasePtr), OffIUser2, value); }
    }

    public int IUser3
    {
        get { EnsurePtr(); return Marshal.ReadInt32(new IntPtr(BasePtr), OffIUser3); }
        set { EnsurePtr(); Marshal.WriteInt32(new IntPtr(BasePtr), OffIUser3, value); }
    }

    public int IUser4
    {
        get { EnsurePtr(); return Marshal.ReadInt32(new IntPtr(BasePtr), OffIUser4); }
        set { EnsurePtr(); Marshal.WriteInt32(new IntPtr(BasePtr), OffIUser4, value); }
    }

    public float FUser1
    {
        get { EnsurePtr(); return BitConverter.Int32BitsToSingle(Marshal.ReadInt32(new IntPtr(BasePtr), OffFUser1)); }
        set { EnsurePtr(); Marshal.WriteInt32(new IntPtr(BasePtr), OffFUser1, BitConverter.SingleToInt32Bits(value)); }
    }

    public float FUser2
    {
        get { EnsurePtr(); return BitConverter.Int32BitsToSingle(Marshal.ReadInt32(new IntPtr(BasePtr), OffFUser2)); }
        set { EnsurePtr(); Marshal.WriteInt32(new IntPtr(BasePtr), OffFUser2, BitConverter.SingleToInt32Bits(value)); }
    }

    public float FUser3
    {
        get { EnsurePtr(); return BitConverter.Int32BitsToSingle(Marshal.ReadInt32(new IntPtr(BasePtr), OffFUser3)); }
        set { EnsurePtr(); Marshal.WriteInt32(new IntPtr(BasePtr), OffFUser3, BitConverter.SingleToInt32Bits(value)); }
    }

    public float FUser4
    {
        get { EnsurePtr(); return BitConverter.Int32BitsToSingle(Marshal.ReadInt32(new IntPtr(BasePtr), OffFUser4)); }
        set { EnsurePtr(); Marshal.WriteInt32(new IntPtr(BasePtr), OffFUser4, BitConverter.SingleToInt32Bits(value)); }
    }

    public Vector3f VUser1
    {
        get => ReadVectorField(OffVUser1);
        set => WriteVectorField(OffVUser1, value);
    }

    public Vector3f VUser2
    {
        get => ReadVectorField(OffVUser2);
        set => WriteVectorField(OffVUser2, value);
    }

    public Vector3f VUser3
    {
        get => ReadVectorField(OffVUser3);
        set => WriteVectorField(OffVUser3, value);
    }

    public Vector3f VUser4
    {
        get => ReadVectorField(OffVUser4);
        set => WriteVectorField(OffVUser4, value);
    }

    public override string ToString()
    {
        var o = Origin;
        var v = Velocity;
        return $"Origin: {o}, Velocity: {v}, Health: {Health}, MaxSpeed: {MaxSpeed}";
    }
}