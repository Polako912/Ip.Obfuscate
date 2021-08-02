namespace Ip.Obfuscate.Core.Extensions
{
    public static class StringExtensions
    {
        public static string BuildObfuscateString(char obfuscateChar) =>
            obfuscateChar + obfuscateChar.ToString() + obfuscateChar;

        public static string BuildMiddleObfuscatedString(char obfuscateChar) =>
            BuildObfuscateString(obfuscateChar) + "." + BuildObfuscateString(obfuscateChar);
    }
}
