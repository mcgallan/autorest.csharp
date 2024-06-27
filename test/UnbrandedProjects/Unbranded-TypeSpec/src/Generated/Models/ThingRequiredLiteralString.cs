// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace UnbrandedTypeSpec.Models
{
    /// <summary> The Thing_requiredLiteralString. </summary>
    public readonly partial struct ThingRequiredLiteralString : IEquatable<ThingRequiredLiteralString>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ThingRequiredLiteralString"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ThingRequiredLiteralString(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AcceptValue = "accept";

        /// <summary> accept. </summary>
        public static ThingRequiredLiteralString Accept { get; } = new ThingRequiredLiteralString(AcceptValue);
        /// <summary> Determines if two <see cref="ThingRequiredLiteralString"/> values are the same. </summary>
        public static bool operator ==(ThingRequiredLiteralString left, ThingRequiredLiteralString right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ThingRequiredLiteralString"/> values are not the same. </summary>
        public static bool operator !=(ThingRequiredLiteralString left, ThingRequiredLiteralString right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ThingRequiredLiteralString"/>. </summary>
        public static implicit operator ThingRequiredLiteralString(string value) => new ThingRequiredLiteralString(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ThingRequiredLiteralString other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ThingRequiredLiteralString other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
