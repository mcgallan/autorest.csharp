// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace AzureSample.ResourceManager.Storage.Models
{
    /// <summary> The status of blob restore progress. Possible values are: - InProgress: Indicates that blob restore is ongoing. - Complete: Indicates that blob restore has been completed successfully. - Failed: Indicates that blob restore is failed. </summary>
    public readonly partial struct BlobRestoreProgressStatus : IEquatable<BlobRestoreProgressStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BlobRestoreProgressStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BlobRestoreProgressStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InProgressValue = "InProgress";
        private const string CompleteValue = "Complete";
        private const string FailedValue = "Failed";

        /// <summary> InProgress. </summary>
        public static BlobRestoreProgressStatus InProgress { get; } = new BlobRestoreProgressStatus(InProgressValue);
        /// <summary> Complete. </summary>
        public static BlobRestoreProgressStatus Complete { get; } = new BlobRestoreProgressStatus(CompleteValue);
        /// <summary> Failed. </summary>
        public static BlobRestoreProgressStatus Failed { get; } = new BlobRestoreProgressStatus(FailedValue);
        /// <summary> Determines if two <see cref="BlobRestoreProgressStatus"/> values are the same. </summary>
        public static bool operator ==(BlobRestoreProgressStatus left, BlobRestoreProgressStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BlobRestoreProgressStatus"/> values are not the same. </summary>
        public static bool operator !=(BlobRestoreProgressStatus left, BlobRestoreProgressStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="BlobRestoreProgressStatus"/>. </summary>
        public static implicit operator BlobRestoreProgressStatus(string value) => new BlobRestoreProgressStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BlobRestoreProgressStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BlobRestoreProgressStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
