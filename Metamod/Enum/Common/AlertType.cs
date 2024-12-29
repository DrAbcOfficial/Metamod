﻿namespace Metamod.Enum.Common;

public enum AlertType
{
    at_notice,
    at_console,     // same as at_notice, but forces a ConPrintf, not a message box
    at_aiconsole,   // same as at_console, but only shown if developer level is 2!
    at_warning,
    at_error,
    at_logged		// Server print to console ( only in multiplayer games ).
}
