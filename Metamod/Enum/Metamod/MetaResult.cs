﻿namespace Metamod.Enum.Metamod;
// Flags returned by a plugin's api function.
// NOTE: order is crucial, as greater/less comparisons are made.
public enum MetaResult
{
    MRES_UNSET = 0,
    MRES_IGNORED,       // plugin didn't take any action
    MRES_HANDLED,       // plugin did something, but real function should still be called
    MRES_OVERRIDE,      // call real function, but use my return value
    MRES_SUPERCEDE,		// skip real function; use my return value
}
