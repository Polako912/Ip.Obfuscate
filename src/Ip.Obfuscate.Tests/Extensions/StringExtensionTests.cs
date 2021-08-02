using Ip.Obfuscate.Core.Extensions;
using NUnit.Framework;

namespace Ip.Obfuscate.Tests.Extensions
{
    [TestFixture]
    public class StringExtensionTests
    {
        [TestCase('X', ExpectedResult = "XXX")]
        [TestCase('*', ExpectedResult = "***")]
        public string BuildSegmentObfuscatedString_ValidParameter_ReturnsCorrectString(char obfuscateChar) =>
            StringExtensions.BuildSegmentObfuscatedString(obfuscateChar);

        [TestCase('X', ExpectedResult = "XXX.XXX")]
        [TestCase('*', ExpectedResult = "***.***")]
        public string BuildMiddleObfuscatedString_ValidParameter_ReturnsCorrectString(char obfuscateChar) =>
            StringExtensions.BuildMiddleObfuscatedString(obfuscateChar);
    }
}
