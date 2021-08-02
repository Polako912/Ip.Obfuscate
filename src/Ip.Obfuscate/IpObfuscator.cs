using Ip.Obfuscate.Core.Enums;
using Ip.Obfuscate.Core.Interfaces.Obfuscators;
using Ip.Obfuscate.Core.Interfaces.Parsers;
using System;
using System.Collections.Generic;
using System.Net;

namespace Ip.Obfuscate
{
    public class IpObfuscator
    {
        private readonly IStringParser _stringParser;

        private readonly IIpv4Obfuscator _ipv4Obfuscator;
        private readonly IIpv6Obfuscator _ipv6Obfuscator;

        public IpObfuscator(IStringParser stringParser,
            IIpv4Obfuscator ipv4Obfuscator,
            IIpv6Obfuscator ipv6Obfuscator)
        {
            _stringParser = stringParser;
            _ipv4Obfuscator = ipv4Obfuscator;
            _ipv6Obfuscator = ipv6Obfuscator;
        }

        /// <summary>
        /// Method to obfuscate Ipv4 addresses.
        /// If ObfuscationType is Custom, parameter segments cannot be null.
        /// <example>
        /// <code>
        /// segments = new [] {1,3};
        /// "111.111.111.111" -> "111.XXX.111.XXX"
        /// </code>
        /// </example>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="inputIpAddress"></param>
        /// <param name="obfuscateChar"></param>
        /// <param name="obfuscationType"></param>
        /// <param name="segments"></param>
        /// <returns></returns>
        public string ObfuscateIpv4<T>(T inputIpAddress, char obfuscateChar, ObfuscationType obfuscationType, List<int> segments = null)
        {
            return typeof(T) switch
            {
                { } ipAddressType when ipAddressType == typeof(IPAddress) => _ipv4Obfuscator.Obfuscate(
                    _stringParser.ParseIpv4(inputIpAddress), obfuscateChar, obfuscationType, segments),
                { } stringAddress when stringAddress == typeof(string) => _ipv4Obfuscator.Obfuscate(
                    inputIpAddress.ToString(), obfuscateChar, obfuscationType, segments),
                _ => throw new NotSupportedException($"Type {typeof(T)} is not currently supported")
            };
        }

        /// <summary>
        /// Method to obfuscate Ipv6 addresses.
        /// If ObfuscationType is Custom, parameter segments cannot be null.
        /// <example> 
        /// <code>
        /// segments = new [] {1,3, 5};
        /// "2001:0db8:85a3:0000:0000:8a2e:0370:7334" -> "2001:XXXX:85a3:XXXX:0000:XXXX:0370:7334"
        /// </code>
        /// </example>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="inputIpAddress"></param>
        /// <param name="obfuscateChar"></param>
        /// <param name="obfuscationType"></param>
        /// <param name="segments"></param>
        /// <returns></returns>
        private string ObfuscateIpv6<T>(T inputIpAddress, char obfuscateChar, ObfuscationType obfuscationType, List<int> segments = null)
        {
            return typeof(T) switch
            {
                { } ipAddressType when ipAddressType == typeof(IPAddress) => _ipv6Obfuscator.Obfuscate(
                    _stringParser.ParseIpv4(inputIpAddress), obfuscateChar, obfuscationType, segments),
                { } stringAddress when stringAddress == typeof(string) => _ipv6Obfuscator.Obfuscate(
                    inputIpAddress.ToString(), obfuscateChar, obfuscationType, segments),
                _ => throw new NotSupportedException($"Type {typeof(T)} is not currently supported")
            };
        }
    }
}
