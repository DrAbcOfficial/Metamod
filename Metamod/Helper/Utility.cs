﻿using Metamod.Struct.Engine;

namespace Metamod.Helper;

public class CUtility
{
    public static string String(StringHandle str)
    {
        return str.ToString();
    }
    public static StringHandle MakeString(string str)
    {
        return new StringHandle(str);
    }
}
