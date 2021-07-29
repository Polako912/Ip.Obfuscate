using Ip.Obfuscate.Core.Interfaces.Parsers;
using System.Net;

namespace Ip.Obfuscate.Core.Parsers
{
    public class StringParser : IStringParser
    {
        public string ParseIpv4(IPAddress inputIpAddress) =>
            inputIpAddress.ToString();

        public string ParseIpv6(IPAddress inIpAddress) =>
            inIpAddress.ToString();
    }
}
