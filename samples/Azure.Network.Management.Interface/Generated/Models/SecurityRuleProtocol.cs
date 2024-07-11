// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Network.Management.Interface.Models
{
    /// <summary> Network protocol this rule applies to. </summary>
    public readonly partial struct SecurityRuleProtocol : IEquatable<SecurityRuleProtocol>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SecurityRuleProtocol"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SecurityRuleProtocol(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TcpValue = "Tcp";
        private const string UdpValue = "Udp";
        private const string IcmpValue = "Icmp";
        private const string EspValue = "Esp";
        private const string AsteriskValue = "*";
        private const string AhValue = "Ah";

        /// <summary> Tcp. </summary>
        public static SecurityRuleProtocol Tcp { get; } = new SecurityRuleProtocol(TcpValue);
        /// <summary> Udp. </summary>
        public static SecurityRuleProtocol Udp { get; } = new SecurityRuleProtocol(UdpValue);
        /// <summary> Icmp. </summary>
        public static SecurityRuleProtocol Icmp { get; } = new SecurityRuleProtocol(IcmpValue);
        /// <summary> Esp. </summary>
        public static SecurityRuleProtocol Esp { get; } = new SecurityRuleProtocol(EspValue);
        /// <summary> *. </summary>
        public static SecurityRuleProtocol Asterisk { get; } = new SecurityRuleProtocol(AsteriskValue);
        /// <summary> Ah. </summary>
        public static SecurityRuleProtocol Ah { get; } = new SecurityRuleProtocol(AhValue);
        /// <summary> Determines if two <see cref="SecurityRuleProtocol"/> values are the same. </summary>
        public static bool operator ==(SecurityRuleProtocol left, SecurityRuleProtocol right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SecurityRuleProtocol"/> values are not the same. </summary>
        public static bool operator !=(SecurityRuleProtocol left, SecurityRuleProtocol right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SecurityRuleProtocol"/>. </summary>
        public static implicit operator SecurityRuleProtocol(string value) => new SecurityRuleProtocol(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SecurityRuleProtocol other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SecurityRuleProtocol other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
