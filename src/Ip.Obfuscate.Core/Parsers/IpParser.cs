using Ip.Obfuscate.Core.Interfaces.Parsers;
using System.Net;

namespace Ip.Obfuscate.Core.Parsers
{
    public class IpParser : IIpParser
    {
        public IPAddress ParseIpv4(string inputIpAddress) =>
            IPAddress.Parse(inputIpAddress);

        public IPAddress ParseIpv6(string inputIpAddress) =>
            IPAddress.Parse(inputIpAddress);
    }
}
