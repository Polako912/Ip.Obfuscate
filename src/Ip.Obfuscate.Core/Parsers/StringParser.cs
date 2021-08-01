using Ip.Obfuscate.Core.Interfaces.Parsers;

namespace Ip.Obfuscate.Core.Parsers
{
    public class StringParser : IStringParser
    {
        public string ParseIpv4<T>(T inputIpAddress) =>
            inputIpAddress.ToString();

        public string ParseIpv6<T>(T inIpAddress) =>
            inIpAddress.ToString();
    }
}
