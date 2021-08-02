namespace Ip.Obfuscate.Core.Interfaces.Parsers
{
    public interface IStringParser
    {
        string ParseIpv4<T>(T inputIpAddress);
        string ParseIpv6<T>(T inIpAddress);
    }
}