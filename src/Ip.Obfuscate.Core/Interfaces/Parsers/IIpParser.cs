using System.Net;

namespace Ip.Obfuscate.Core.Interfaces.Parsers
{
    public interface IIpParser
    {
        IPAddress ParseIpv4(string inputIpAddress);
        IPAddress ParseIpv6(string inputIpAddress);
    }
}