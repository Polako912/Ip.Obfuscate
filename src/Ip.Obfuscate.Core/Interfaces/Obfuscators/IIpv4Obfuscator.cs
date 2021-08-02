using Ip.Obfuscate.Core.Enums;
using System.Collections.Generic;

namespace Ip.Obfuscate.Core.Interfaces.Obfuscators
{
    public interface IIpv4Obfuscator
    {
        string Obfuscate(string inputIpAddress, char obfuscateChar, ObfuscationType obfuscationType, List<int> segments = null);
    }
}