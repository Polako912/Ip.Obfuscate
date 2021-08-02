using Ip.Obfuscate.Core.Enums;
using Ip.Obfuscate.Core.Extensions.IPv4;
using Ip.Obfuscate.Core.Interfaces.Obfuscators;
using System;
using System.Collections.Generic;

namespace Ip.Obfuscate.Core.Obfuscators
{
    public class Ipv4Obfuscator : IIpv4Obfuscator
    {
        public string Obfuscate(string inputIpAddress, char obfuscateChar, ObfuscationType obfuscationType, List<int> segments = null)
        {
            return obfuscationType switch
            {
                ObfuscationType.None => inputIpAddress,
                ObfuscationType.Custom => Ipv4Extensions.CustomObfuscateExtension(inputIpAddress, obfuscateChar, segments),
                ObfuscationType.Basic => Ipv4Extensions.BasicObfuscateExtension(inputIpAddress, obfuscateChar),
                ObfuscationType.Whole => Ipv4Extensions.WholeObfuscateExtension(inputIpAddress, obfuscateChar),
                ObfuscationType.Random => Ipv4Extensions.RandomObfuscateExtension(inputIpAddress, obfuscateChar),
                _ => throw new NotSupportedException($"Obfuscation Type {obfuscationType} is not supported")
            };
        }
    }
}
