// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PostgreSql.Models
{
    /// <summary> The key type like &apos;AzureKeyVault&apos;. </summary>
    public readonly partial struct PostgreSqlServerKeyType : IEquatable<PostgreSqlServerKeyType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlServerKeyType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PostgreSqlServerKeyType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AzureKeyVaultValue = "AzureKeyVault";

        /// <summary> AzureKeyVault. </summary>
        public static PostgreSqlServerKeyType AzureKeyVault { get; } = new PostgreSqlServerKeyType(AzureKeyVaultValue);
        /// <summary> Determines if two <see cref="PostgreSqlServerKeyType"/> values are the same. </summary>
        public static bool operator ==(PostgreSqlServerKeyType left, PostgreSqlServerKeyType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PostgreSqlServerKeyType"/> values are not the same. </summary>
        public static bool operator !=(PostgreSqlServerKeyType left, PostgreSqlServerKeyType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PostgreSqlServerKeyType"/>. </summary>
        public static implicit operator PostgreSqlServerKeyType(string value) => new PostgreSqlServerKeyType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PostgreSqlServerKeyType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PostgreSqlServerKeyType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
