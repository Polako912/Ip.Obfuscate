using System;
using System.Collections.Generic;
using System.Linq;
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
                throw new ArgumentNullException(nameof(segments));

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

            var ipSegments = inputIpAddress.Split(".");

            if (ipSegments.Any(s => !CheckSegmentLength(s)))
                return string.Empty;

            return ipSegments.Length != 4
                ? string.Empty
                : BuildIpString(ObfuscateEdgeIpSegments(ipSegments[0], 2, obfuscateChar),
                    ObfuscateEdgeIpSegments(ipSegments[3], 0,
                        obfuscateChar), obfuscateChar);
        }

        private static bool CheckSegmentLength(string segment) =>
            segment.Length > 0;

        private static string ObfuscateEdgeIpSegments(string segment, int index, char obfuscateChar)
        {
            if (segment.Length != 3) return segment;

            var array = segment.ToCharArray();

            if (array.Length == 3)
                array[index] = obfuscateChar;

            return new string(array);
        }

        private static string BuildIpString(string firstIpSegment, string lastIpSegment, char obfuscateChar) =>
            firstIpSegment + "." + StringExtensions
                .BuildMiddleObfuscatedString(obfuscateChar) + "." + lastIpSegment;

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
