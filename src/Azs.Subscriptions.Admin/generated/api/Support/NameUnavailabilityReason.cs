// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.4.5, generator: @autorest/powershell@3.0.438)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support
{

    /// <summary>The reason that the name is not available.</summary>
    public partial struct NameUnavailabilityReason :
        System.IEquatable<NameUnavailabilityReason>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.NameUnavailabilityReason AlreadyExists = @"AlreadyExists";

        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.NameUnavailabilityReason Invalid = @"Invalid";

        /// <summary>the value for an instance of the <see cref="NameUnavailabilityReason" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to NameUnavailabilityReason</summary>
        /// <param name="value">the value to convert to an instance of <see cref="NameUnavailabilityReason" />.</param>
        internal static object CreateFrom(object value)
        {
            return new NameUnavailabilityReason(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type NameUnavailabilityReason</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.NameUnavailabilityReason e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type NameUnavailabilityReason (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is NameUnavailabilityReason && Equals((NameUnavailabilityReason)obj);
        }

        /// <summary>Returns hashCode for enum NameUnavailabilityReason</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="NameUnavailabilityReason" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private NameUnavailabilityReason(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for NameUnavailabilityReason</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to NameUnavailabilityReason</summary>
        /// <param name="value">the value to convert to an instance of <see cref="NameUnavailabilityReason" />.</param>

        public static implicit operator NameUnavailabilityReason(string value)
        {
            return new NameUnavailabilityReason(value);
        }

        /// <summary>Implicit operator to convert NameUnavailabilityReason to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="NameUnavailabilityReason" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.NameUnavailabilityReason e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum NameUnavailabilityReason</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.NameUnavailabilityReason e1, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.NameUnavailabilityReason e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum NameUnavailabilityReason</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.NameUnavailabilityReason e1, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.NameUnavailabilityReason e2)
        {
            return e2.Equals(e1);
        }
    }
}