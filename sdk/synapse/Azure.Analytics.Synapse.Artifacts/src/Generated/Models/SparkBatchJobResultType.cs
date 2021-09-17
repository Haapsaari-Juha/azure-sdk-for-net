// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The Spark batch job result. </summary>
    public readonly partial struct SparkBatchJobResultType : IEquatable<SparkBatchJobResultType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SparkBatchJobResultType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SparkBatchJobResultType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UncertainValue = "Uncertain";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CancelledValue = "Cancelled";

        /// <summary> Uncertain. </summary>
        public static SparkBatchJobResultType Uncertain { get; } = new SparkBatchJobResultType(UncertainValue);
        /// <summary> Succeeded. </summary>
        public static SparkBatchJobResultType Succeeded { get; } = new SparkBatchJobResultType(SucceededValue);
        /// <summary> Failed. </summary>
        public static SparkBatchJobResultType Failed { get; } = new SparkBatchJobResultType(FailedValue);
        /// <summary> Cancelled. </summary>
        public static SparkBatchJobResultType Cancelled { get; } = new SparkBatchJobResultType(CancelledValue);
        /// <summary> Determines if two <see cref="SparkBatchJobResultType"/> values are the same. </summary>
        public static bool operator ==(SparkBatchJobResultType left, SparkBatchJobResultType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SparkBatchJobResultType"/> values are not the same. </summary>
        public static bool operator !=(SparkBatchJobResultType left, SparkBatchJobResultType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SparkBatchJobResultType"/>. </summary>
        public static implicit operator SparkBatchJobResultType(string value) => new SparkBatchJobResultType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SparkBatchJobResultType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SparkBatchJobResultType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
