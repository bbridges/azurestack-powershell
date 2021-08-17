// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.4.5, generator: @autorest/powershell@3.0.438)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Subscription.Support
{

    /// <summary>Subscription notification state.</summary>
    public partial struct SubscriptionState :
        System.IEquatable<SubscriptionState>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Subscription.Support.SubscriptionState Deleted = @"Deleted";

        public static Microsoft.Azure.PowerShell.Cmdlets.Subscription.Support.SubscriptionState Disabled = @"Disabled";

        public static Microsoft.Azure.PowerShell.Cmdlets.Subscription.Support.SubscriptionState Enabled = @"Enabled";

        public static Microsoft.Azure.PowerShell.Cmdlets.Subscription.Support.SubscriptionState NotDefined = @"NotDefined";

        public static Microsoft.Azure.PowerShell.Cmdlets.Subscription.Support.SubscriptionState PastDue = @"PastDue";

        public static Microsoft.Azure.PowerShell.Cmdlets.Subscription.Support.SubscriptionState Warned = @"Warned";

        /// <summary>the value for an instance of the <see cref="SubscriptionState" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to SubscriptionState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="SubscriptionState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new SubscriptionState(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type SubscriptionState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Subscription.Support.SubscriptionState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type SubscriptionState (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is SubscriptionState && Equals((SubscriptionState)obj);
        }

        /// <summary>Returns hashCode for enum SubscriptionState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="SubscriptionState" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private SubscriptionState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for SubscriptionState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to SubscriptionState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="SubscriptionState" />.</param>

        public static implicit operator SubscriptionState(string value)
        {
            return new SubscriptionState(value);
        }

        /// <summary>Implicit operator to convert SubscriptionState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="SubscriptionState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Subscription.Support.SubscriptionState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum SubscriptionState</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Subscription.Support.SubscriptionState e1, Microsoft.Azure.PowerShell.Cmdlets.Subscription.Support.SubscriptionState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum SubscriptionState</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Subscription.Support.SubscriptionState e1, Microsoft.Azure.PowerShell.Cmdlets.Subscription.Support.SubscriptionState e2)
        {
            return e2.Equals(e1);
        }
    }
}