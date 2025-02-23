// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ConnectedVMware.Models
{
    /// <summary> Defines the different types of operations for guest agent. </summary>
    public readonly partial struct ProvisioningAction : IEquatable<ProvisioningAction>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ProvisioningAction"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ProvisioningAction(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InstallValue = "install";
        private const string UninstallValue = "uninstall";
        private const string RepairValue = "repair";

        /// <summary> install. </summary>
        public static ProvisioningAction Install { get; } = new ProvisioningAction(InstallValue);
        /// <summary> uninstall. </summary>
        public static ProvisioningAction Uninstall { get; } = new ProvisioningAction(UninstallValue);
        /// <summary> repair. </summary>
        public static ProvisioningAction Repair { get; } = new ProvisioningAction(RepairValue);
        /// <summary> Determines if two <see cref="ProvisioningAction"/> values are the same. </summary>
        public static bool operator ==(ProvisioningAction left, ProvisioningAction right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ProvisioningAction"/> values are not the same. </summary>
        public static bool operator !=(ProvisioningAction left, ProvisioningAction right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ProvisioningAction"/>. </summary>
        public static implicit operator ProvisioningAction(string value) => new ProvisioningAction(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ProvisioningAction other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ProvisioningAction other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
