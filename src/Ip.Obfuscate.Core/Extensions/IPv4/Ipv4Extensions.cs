using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ip.Obfuscate.Core.Extensions.IPv4
{
    public static class Ipv4Extensions
    {
        public static string CustomObfuscateExtension(string inputIpAddress, char obfuscateChar, List<int> segments = null)
        {
            if (string.IsNullOrEmpty(inputIpAddress))
                return string.Empty;

            if(segments is null)
                throw new ArgumentNullException("segments");

            var ipSegments = inputIpAddress.Split(".");

            foreach (var segment in segments)
            {
                ipSegments[segment] = StringExtensions.BuildObfuscateString(obfuscateChar);
            }

            return string.Join(".", ipSegments);
        }

        public static string BasicObfuscateExtension(string inputIpAddress, char obfuscateChar)
        {
            if (string.IsNullOrEmpty(inputIpAddress))
                return string.Empty;

            return string.Empty;
        }

        public static string WholeObfuscateExtension(string inputIpAddress, char obfuscateChar)
        {
            if (string.IsNullOrEmpty(inputIpAddress))
                return string.Empty;

            var regex = new Regex(@"(\d+)", RegexOptions.Compiled);

            return regex.Replace(inputIpAddress, StringExtensions.BuildObfuscateString(obfuscateChar));
        }

        public static string RandomObfuscateExtension(string inputIpAddress, char obfuscateChar)
        {
            if (string.IsNullOrEmpty(inputIpAddress))
                return string.Empty;

            return string.Empty;
        }
    }
}
