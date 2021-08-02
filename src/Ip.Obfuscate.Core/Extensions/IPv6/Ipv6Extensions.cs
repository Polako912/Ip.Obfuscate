﻿using System;
using System.Collections.Generic;

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

            return string.Empty;
        }

        public static string WholeObfuscateExtension(string inputIpAddress, char obfuscateChar)
        {
            if (string.IsNullOrEmpty(inputIpAddress))
                return string.Empty;

            return string.Empty;
        }

        public static string RandomObfuscateExtension(string inputIpAddress, char obfuscateChar)
        {
            if (string.IsNullOrEmpty(inputIpAddress))
                return string.Empty;

            return string.Empty;
        }
    }
}
