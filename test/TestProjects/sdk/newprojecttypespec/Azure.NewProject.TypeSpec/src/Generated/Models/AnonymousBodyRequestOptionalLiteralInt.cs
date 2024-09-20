// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using System.Globalization;

namespace Azure.NewProject.TypeSpec.Models
{
    /// <summary> The AnonymousBodyRequest_optionalLiteralInt. </summary>
    public readonly partial struct AnonymousBodyRequestOptionalLiteralInt : IEquatable<AnonymousBodyRequestOptionalLiteralInt>
    {
        private readonly int _value;

        /// <summary> Initializes a new instance of <see cref="AnonymousBodyRequestOptionalLiteralInt"/>. </summary>
        public AnonymousBodyRequestOptionalLiteralInt(int value)
        {
            _value = value;
        }

        private const int _456Value = 456;

        /// <summary> 456. </summary>
        public static AnonymousBodyRequestOptionalLiteralInt _456 { get; } = new AnonymousBodyRequestOptionalLiteralInt(_456Value);

        internal int ToSerialInt32() => _value;

        /// <summary> Determines if two <see cref="AnonymousBodyRequestOptionalLiteralInt"/> values are the same. </summary>
        public static bool operator ==(AnonymousBodyRequestOptionalLiteralInt left, AnonymousBodyRequestOptionalLiteralInt right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AnonymousBodyRequestOptionalLiteralInt"/> values are not the same. </summary>
        public static bool operator !=(AnonymousBodyRequestOptionalLiteralInt left, AnonymousBodyRequestOptionalLiteralInt right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AnonymousBodyRequestOptionalLiteralInt"/>. </summary>
        public static implicit operator AnonymousBodyRequestOptionalLiteralInt(int value) => new AnonymousBodyRequestOptionalLiteralInt(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AnonymousBodyRequestOptionalLiteralInt other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AnonymousBodyRequestOptionalLiteralInt other) => Equals(_value, other._value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value.GetHashCode();
        /// <inheritdoc />
        public override string ToString() => _value.ToString(CultureInfo.InvariantCulture);
    }
}