// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Scm._Type.Property.ValueTypes.Models
{
    /// <summary> Enum for property in UnionStringLiteralProperty. </summary>
    public readonly partial struct UnionStringLiteralPropertyProperty : IEquatable<UnionStringLiteralPropertyProperty>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="UnionStringLiteralPropertyProperty"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public UnionStringLiteralPropertyProperty(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HelloValue = "hello";
        private const string WorldValue = "world";

        /// <summary> hello. </summary>
        public static UnionStringLiteralPropertyProperty Hello { get; } = new UnionStringLiteralPropertyProperty(HelloValue);
        /// <summary> world. </summary>
        public static UnionStringLiteralPropertyProperty World { get; } = new UnionStringLiteralPropertyProperty(WorldValue);
        /// <summary> Determines if two <see cref="UnionStringLiteralPropertyProperty"/> values are the same. </summary>
        public static bool operator ==(UnionStringLiteralPropertyProperty left, UnionStringLiteralPropertyProperty right) => left.Equals(right);
        /// <summary> Determines if two <see cref="UnionStringLiteralPropertyProperty"/> values are not the same. </summary>
        public static bool operator !=(UnionStringLiteralPropertyProperty left, UnionStringLiteralPropertyProperty right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="UnionStringLiteralPropertyProperty"/>. </summary>
        public static implicit operator UnionStringLiteralPropertyProperty(string value) => new UnionStringLiteralPropertyProperty(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is UnionStringLiteralPropertyProperty other && Equals(other);
        /// <inheritdoc />
        public bool Equals(UnionStringLiteralPropertyProperty other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
