using Ip.Obfuscate.Core.Extensions.IPv4;
using NUnit.Framework;


namespace Ip.Obfuscate.Tests.Extensions
{
    [TestFixture]
    public class Ipv4ExtensionsTests
    {
        [TestCase("111.111.111.111", 'X', ExpectedResult= "XXX.XXX.XXX.XXX")]
        [TestCase("11.111.111.111", 'X', ExpectedResult= "XXX.XXX.XXX.XXX")]
        [TestCase("111.11.111.111", 'X', ExpectedResult= "XXX.XXX.XXX.XXX")]
        [TestCase("111.111.11.111", 'X', ExpectedResult= "XXX.XXX.XXX.XXX")]
        [TestCase("111.111.111.11", 'X', ExpectedResult= "XXX.XXX.XXX.XXX")]
        [TestCase("111.111.111.111", '*', ExpectedResult= "***.***.***.***")]
        [TestCase("", '*', ExpectedResult= "")]
        [TestCase(null, '*', ExpectedResult= "")]
        public string WholeObfuscateExtension_ValidInout_ReturnsCorrectValue(string inputAddress, char obfuscateChar) =>
            Ipv4Extensions.WholeObfuscateExtension(inputAddress, obfuscateChar);
    }
}
