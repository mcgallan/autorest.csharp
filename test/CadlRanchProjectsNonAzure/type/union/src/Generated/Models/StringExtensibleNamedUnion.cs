// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Scm._Type.Union.Models
{
    /// <summary> The StringExtensibleNamedUnion. </summary>
    public readonly partial struct StringExtensibleNamedUnion : IEquatable<StringExtensibleNamedUnion>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StringExtensibleNamedUnion"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StringExtensibleNamedUnion(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OptionBValue = "b";
        private const string CValue = "c";

        /// <summary> b. </summary>
        public static StringExtensibleNamedUnion OptionB { get; } = new StringExtensibleNamedUnion(OptionBValue);
        /// <summary> c. </summary>
        public static StringExtensibleNamedUnion C { get; } = new StringExtensibleNamedUnion(CValue);
        /// <summary> Determines if two <see cref="StringExtensibleNamedUnion"/> values are the same. </summary>
        public static bool operator ==(StringExtensibleNamedUnion left, StringExtensibleNamedUnion right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StringExtensibleNamedUnion"/> values are not the same. </summary>
        public static bool operator !=(StringExtensibleNamedUnion left, StringExtensibleNamedUnion right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="StringExtensibleNamedUnion"/>. </summary>
        public static implicit operator StringExtensibleNamedUnion(string value) => new StringExtensibleNamedUnion(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StringExtensibleNamedUnion other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StringExtensibleNamedUnion other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
