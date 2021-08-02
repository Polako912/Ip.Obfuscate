using Ip.Obfuscate.Core.Extensions.IPv4;
using NUnit.Framework;
using System.Linq;


namespace Ip.Obfuscate.Tests.Extensions
{
    [TestFixture]
    public class Ipv4ExtensionsTests
    {
        [TestCase("111.111.111.111", 'X', new[] {0, 1, 2, 3}, ExpectedResult = "XXX.XXX.XXX.XXX")]
        [TestCase("111.111.111.111", 'X', new[] {0, 2, 3}, ExpectedResult = "XXX.111.XXX.XXX")]
        [TestCase("111.111.111.111", 'X', new[] {0, 3}, ExpectedResult = "XXX.111.111.XXX")]
        [TestCase("111.111.111.111", 'X', new[] {0}, ExpectedResult = "XXX.111.111.111")]
        [TestCase("", '*', new[] { 0 }, ExpectedResult = "")]
        [TestCase(null, '*', new[] { 0 }, ExpectedResult = "")]
        public string CustomObfuscateExtension_ValidInout_ReturnsCorrectValue(string inputAddress, char obfuscateChar,
            int[] segments) =>
            Ipv4Extensions.CustomObfuscateExtension(inputAddress, obfuscateChar, segments.ToList());

        [TestCase("111.111.111.111", 'X', ExpectedResult = "11X.XXX.XXX.X11")]
        [TestCase("11.111.111.111", 'X', ExpectedResult = "11.XXX.XXX.X11")]
        [TestCase("111.11.111.111", 'X', ExpectedResult = "11X.XXX.XXX.X11")]
        [TestCase("111.111.11.111", 'X', ExpectedResult = "11X.XXX.XXX.X11")]
        [TestCase("111.111.111.11", 'X', ExpectedResult = "11X.XXX.XXX.11")]
        [TestCase("111.111.111.111", '*', ExpectedResult = "11*.***.***.*11")]
        [TestCase("", '*', ExpectedResult = "")]
        [TestCase(null, '*', ExpectedResult = "")]
        public string BasicObfuscateExtension_ValidInout_ReturnsCorrectValue(string inputAddress, char obfuscateChar) =>
            Ipv4Extensions.BasicObfuscateExtension(inputAddress, obfuscateChar);

        [TestCase("111.111.111.111", 'X', ExpectedResult = "XXX.XXX.XXX.XXX")]
        [TestCase("11.111.111.111", 'X', ExpectedResult = "XXX.XXX.XXX.XXX")]
        [TestCase("111.11.111.111", 'X', ExpectedResult = "XXX.XXX.XXX.XXX")]
        [TestCase("111.111.11.111", 'X', ExpectedResult = "XXX.XXX.XXX.XXX")]
        [TestCase("111.111.111.11", 'X', ExpectedResult = "XXX.XXX.XXX.XXX")]
        [TestCase("111.111.111.111", '*', ExpectedResult = "***.***.***.***")]
        [TestCase("", '*', ExpectedResult = "")]
        [TestCase(null, '*', ExpectedResult = "")]
        public string WholeObfuscateExtension_ValidInout_ReturnsCorrectValue(string inputAddress, char obfuscateChar) =>
            Ipv4Extensions.WholeObfuscateExtension(inputAddress, obfuscateChar);
    }
}
