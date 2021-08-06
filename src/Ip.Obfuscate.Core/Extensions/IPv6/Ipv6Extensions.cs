using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Ip.Obfuscate.Core.Extensions.IPv6
{
    public static class Ipv6Extensions
    {
        public static string CustomObfuscateExtension(string inputIpAddress, char obfuscateChar, List<int> segments = null)
        {
            if (segments is null)
                throw new ArgumentNullException(nameof(segments));

            if (string.IsNullOrEmpty(inputIpAddress))
                return string.Empty;

            return string.Empty;
        }

        public static string BasicObfuscateExtension(string inputIpAddress, char obfuscateChar)
        {
            if (string.IsNullOrEmpty(inputIpAddress))
                return string.Empty;

            var ipSegments = inputIpAddress.Split(":");

            if (ipSegments.All(s => !CheckSegmentLength(s)))
                return string.Empty;

            foreach (var ipSegment in ipSegments)
            {

            }

            var firstSegment = ipSegments.First(x => !string.IsNullOrEmpty(x));

            var lastSegment = ipSegments.Last(x => !string.IsNullOrEmpty(x));
        }

        private static bool CheckSegmentLength(string segment) =>
            segment.Length > 0;

        private static string ObfuscateFirstIpSegments(string segment, char obfuscateChar)
        {
            return segment.Length switch
            {
                1 => segment,
                2 => segment,
                3 => ObfuscateFirstSegment(segment, obfuscateChar),
                4 => ObfuscateFirstSegment(segment, obfuscateChar),
                _ => string.Empty
            };
        }

        private static string ObfuscateFirstSegment(string segment, char obfuscateChar)
        {
            var charArray = segment.ToCharArray();

            switch (charArray.Length)
            {
                case 3:
                    charArray[2] = obfuscateChar;
                    break;
                case 4:
                    charArray[2] = obfuscateChar;
                    charArray[3] = obfuscateChar;
                    break;
            }

            return new string(charArray);
        }

        private static string ObfuscateLastIpSegment(string segment, char obfuscateChar)
        {
            return segment.Length switch
            {
                1 => segment,
                2 => segment,
                3 => ObfuscateLastSegment(segment, obfuscateChar),
                4 => ObfuscateLastSegment(segment, obfuscateChar),
                _ => string.Empty
            };
        }

        private static string ObfuscateLastSegment(string segment, char obfuscateChar)
        {
            var charArray = segment.ToCharArray();

            switch (charArray.Length)
            {
                case 3:
                    charArray[0] = obfuscateChar;
                    break;
                case 4:
                    charArray[0] = obfuscateChar;
                    charArray[1] = obfuscateChar;
                    break;
            }

            return new string(charArray);
        }

        private static string BuildIpString(string firstIpSegment, string lastIpSegment, char obfuscateChar) =>
            firstIpSegment + "." + StringExtensions
                .BuildMiddleObfuscatedString(obfuscateChar) + "." + lastIpSegment;

        public static string WholeObfuscateExtension(string inputIpAddress, char obfuscateChar)
        {
            if (string.IsNullOrEmpty(inputIpAddress))
                return string.Empty;

            var regex = new Regex(@"[a-zA-Z\d]+", RegexOptions.Compiled);

            return regex.Replace(inputIpAddress, StringExtensions.BuildIpv6SegmentObfuscatedString(obfuscateChar));
        }

        public static string RandomObfuscateExtension(string inputIpAddress, char obfuscateChar)
        {
            if (string.IsNullOrEmpty(inputIpAddress))
                return string.Empty;

            return string.Empty;
        }
    }
}
