using Ip.Obfuscate.Core.Enums;
using System.Collections.Generic;

namespace Ip.Obfuscate
{
    public class IpObfuscator
    {
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
            return string.Empty;
        }

        /// <summary>
        /// Method to obfuscate Ipv6 addresses.
        /// If ObfuscationType is Custom, parameter segments cannot be null.
        /// /// <example>
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
            return string.Empty;
        }
    }
}
