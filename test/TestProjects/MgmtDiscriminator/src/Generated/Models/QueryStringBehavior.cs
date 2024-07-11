// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace MgmtDiscriminator.Models
{
    /// <summary> Caching behavior for the requests. </summary>
    public readonly partial struct QueryStringBehavior : IEquatable<QueryStringBehavior>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="QueryStringBehavior"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public QueryStringBehavior(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IncludeValue = "Include";
        private const string IncludeAllValue = "IncludeAll";
        private const string ExcludeValue = "Exclude";
        private const string ExcludeAllValue = "ExcludeAll";

        /// <summary> Include. </summary>
        public static QueryStringBehavior Include { get; } = new QueryStringBehavior(IncludeValue);
        /// <summary> IncludeAll. </summary>
        public static QueryStringBehavior IncludeAll { get; } = new QueryStringBehavior(IncludeAllValue);
        /// <summary> Exclude. </summary>
        public static QueryStringBehavior Exclude { get; } = new QueryStringBehavior(ExcludeValue);
        /// <summary> ExcludeAll. </summary>
        public static QueryStringBehavior ExcludeAll { get; } = new QueryStringBehavior(ExcludeAllValue);
        /// <summary> Determines if two <see cref="QueryStringBehavior"/> values are the same. </summary>
        public static bool operator ==(QueryStringBehavior left, QueryStringBehavior right) => left.Equals(right);
        /// <summary> Determines if two <see cref="QueryStringBehavior"/> values are not the same. </summary>
        public static bool operator !=(QueryStringBehavior left, QueryStringBehavior right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="QueryStringBehavior"/>. </summary>
        public static implicit operator QueryStringBehavior(string value) => new QueryStringBehavior(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is QueryStringBehavior other && Equals(other);
        /// <inheritdoc />
        public bool Equals(QueryStringBehavior other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
