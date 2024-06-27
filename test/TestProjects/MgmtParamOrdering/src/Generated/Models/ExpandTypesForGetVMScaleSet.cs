// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace MgmtParamOrdering.Models
{
    /// <summary> The ExpandTypesForGetVMScaleSet. </summary>
    public readonly partial struct ExpandTypesForGetVMScaleSet : IEquatable<ExpandTypesForGetVMScaleSet>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ExpandTypesForGetVMScaleSet"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ExpandTypesForGetVMScaleSet(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UserDataValue = "userData";

        /// <summary> userData. </summary>
        public static ExpandTypesForGetVMScaleSet UserData { get; } = new ExpandTypesForGetVMScaleSet(UserDataValue);
        /// <summary> Determines if two <see cref="ExpandTypesForGetVMScaleSet"/> values are the same. </summary>
        public static bool operator ==(ExpandTypesForGetVMScaleSet left, ExpandTypesForGetVMScaleSet right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ExpandTypesForGetVMScaleSet"/> values are not the same. </summary>
        public static bool operator !=(ExpandTypesForGetVMScaleSet left, ExpandTypesForGetVMScaleSet right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ExpandTypesForGetVMScaleSet"/>. </summary>
        public static implicit operator ExpandTypesForGetVMScaleSet(string value) => new ExpandTypesForGetVMScaleSet(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ExpandTypesForGetVMScaleSet other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ExpandTypesForGetVMScaleSet other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
