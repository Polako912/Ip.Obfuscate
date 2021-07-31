namespace Ip.Obfuscate.Core.Enums
{
    /// <summary>
    /// Supported obfuscation types.
    /// <example> For example:
    /// <code>
    /// None - no obfuscation;
    /// Custom - provide which segments of each IP address type should be obfuscated;
    /// Basic - "111.111.111.111" -> "X11.XXX.XXX.11X";
    /// Whole - "111.111.111.111" -> "XXX.XXX.XXX.XXX";
    /// Random - random segments of each IP address type will be obfuscated;
    /// </code>
    /// </example>
    /// </summary>
    public enum ObfuscationType
    {
        None = 0,
        Custom = 1,
        Basic = 2,
        Whole = 3,
        Random = 4
    }
}
