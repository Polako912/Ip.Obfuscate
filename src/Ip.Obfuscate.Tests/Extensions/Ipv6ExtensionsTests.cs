﻿using Ip.Obfuscate.Core.Extensions.IPv6;
using NUnit.Framework;

namespace Ip.Obfuscate.Tests.Extensions
{
    [TestFixture]
    public class Ipv6ExtensionsTests
    {
        [TestCase("2001:0db8:85a3:0000:0000:8a2e:0370:7334", '*', ExpectedResult = "20**:****:****:****:****:****:****:**34")]
        [TestCase("2001:::0000:0000:8a2e:0370:7334", '*', ExpectedResult = "20**:::****:****:****:****:**34")]
        [TestCase("", '*', ExpectedResult = "")]
        [TestCase(null, '*', ExpectedResult = "")]
        public string BasicObfuscateExtension_ValidInout_ReturnsCorrectValue(string inputAddress, char obfuscateChar) =>
            Ipv6Extensions.BasicObfuscateExtension(inputAddress, obfuscateChar);

        [TestCase("2001:0db8:85a3:0000:0000:8a2e:0370:7334", 'X', ExpectedResult = "XXXX:XXXX:XXXX:XXXX:XXXX:XXXX:XXXX:XXXX")]
        [TestCase("2001:::0000:0000:8a2e:0370:7334", '*', ExpectedResult = "****:::****:****:****:****:****")]
        [TestCase("", '*', ExpectedResult = "")]
        [TestCase(null, '*', ExpectedResult = "")]
        public string WholeObfuscateExtension_ValidInout_ReturnsCorrectValue(string inputAddress, char obfuscateChar) =>
            Ipv6Extensions.WholeObfuscateExtension(inputAddress, obfuscateChar);
    }
}
