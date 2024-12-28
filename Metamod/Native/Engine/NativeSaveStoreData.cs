using Metamod.Native.Common;
using System.Runtime.InteropServices;

namespace Metamod.Native.Engine;

[StructLayout(LayoutKind.Sequential)]
internal unsafe struct NativeSaveStoreData
{
    internal byte* pBaseData;        // Start of all entity save data
    internal byte* pCurrentData; // Current buffer pointer for sequential access
    internal int size;           // Current data size
    internal int bufferSize;     // Total space for data
    internal int tokenSize;      // Size of the linear list of tokens
    internal int tokenCount;     // Number of elements in the pTokens table
    internal byte** pTokens;     // Hash table of entity strings (sparse)
    internal int currentIndex;   // Holds a global entity table ID
    internal int tableCount;     // Number of elements in the entity table
    internal int connectionCount;// Number of elements in the levelList[]
    internal NativeEntityTable* pTable;        // Array of ENTITYTABLE elements (1 for each entity)
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    internal NativeLevelList[] levelList;     // List of connections from this level

    // smooth transition
    internal int fUseLandmark;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
    internal byte[] szLandmarkName;// landmark we'll spawn near in next level
    NativeVector3f vecLandmarkOffset;// for landmark transitions
    internal float time;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    internal byte[] szCurrentMapName;	// To check global entities
}
