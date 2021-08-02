using Ip.Obfuscate.Core.Enums;
using Ip.Obfuscate.Core.Extensions.IPv6;
using System;
using System.Collections.Generic;
using Ip.Obfuscate.Core.Interfaces.Obfuscators;

namespace Ip.Obfuscate.Core.Obfuscators
{
    public class Ipv6Obfuscator : IIpv6Obfuscator
    {
        public string Obfuscate(string inputIpAddress, char obfuscateChar, ObfuscationType obfuscationType, List<int> segments = null)
        {
            return obfuscationType switch
            {
                ObfuscationType.None => inputIpAddress,
                ObfuscationType.Custom => Ipv6Extensions.CustomObfuscateExtension(inputIpAddress, obfuscateChar, segments),
                ObfuscationType.Basic => Ipv6Extensions.BasicObfuscateExtension(inputIpAddress, obfuscateChar),
                ObfuscationType.Whole => Ipv6Extensions.WholeObfuscateExtension(inputIpAddress, obfuscateChar),
                ObfuscationType.Random => Ipv6Extensions.RandomObfuscateExtension(inputIpAddress, obfuscateChar),
                _ => throw new NotSupportedException($"Obfuscation Type {obfuscationType} is not supported")
            };
        }
    }
}
