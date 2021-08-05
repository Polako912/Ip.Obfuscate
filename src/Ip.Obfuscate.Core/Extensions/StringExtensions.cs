﻿namespace Ip.Obfuscate.Core.Extensions
{
    public static class StringExtensions
    {
        public static string BuildSegmentObfuscatedString(char obfuscateChar) =>
            obfuscateChar + obfuscateChar.ToString() + obfuscateChar;

        public static string BuildMiddleObfuscatedString(char obfuscateChar) =>
            BuildSegmentObfuscatedString(obfuscateChar) + "." + BuildSegmentObfuscatedString(obfuscateChar);

        public static string BuildIpv6SegmentObfuscatedString(char obfuscateChar) =>
            obfuscateChar + obfuscateChar.ToString() + obfuscateChar + obfuscateChar;
    }
}
