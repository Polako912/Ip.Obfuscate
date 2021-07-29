using System.Net;

namespace Ip.Obfuscate.Core.Interfaces.Parsers
{
    public interface IStringParser
    {
        string ParseIpv4(IPAddress inputIpAddress);
        string ParseIpv6(IPAddress inIpAddress);
    }
}