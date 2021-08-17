// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.4.5, generator: @autorest/powershell@3.0.438)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support
{

    /// <summary>The linked operation.</summary>
    public partial struct LinkedOperation :
        System.IEquatable<LinkedOperation>
    {
        /// <summary>Move resources between resource groups within the same subscription.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.LinkedOperation CrossResourceGroupResourceMove = @"CrossResourceGroupResourceMove";

        /// <summary>Move resources across subscriptions.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.LinkedOperation CrossSubscriptionResourceMove = @"CrossSubscriptionResourceMove";

        /// <summary>The operation is none.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.LinkedOperation None = @"None";

        /// <summary>the value for an instance of the <see cref="LinkedOperation" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to LinkedOperation</summary>
        /// <param name="value">the value to convert to an instance of <see cref="LinkedOperation" />.</param>
        internal static object CreateFrom(object value)
        {
            return new LinkedOperation(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type LinkedOperation</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.LinkedOperation e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type LinkedOperation (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is LinkedOperation && Equals((LinkedOperation)obj);
        }

        /// <summary>Returns hashCode for enum LinkedOperation</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="LinkedOperation" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private LinkedOperation(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for LinkedOperation</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to LinkedOperation</summary>
        /// <param name="value">the value to convert to an instance of <see cref="LinkedOperation" />.</param>

        public static implicit operator LinkedOperation(string value)
        {
            return new LinkedOperation(value);
        }

        /// <summary>Implicit operator to convert LinkedOperation to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="LinkedOperation" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.LinkedOperation e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum LinkedOperation</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.LinkedOperation e1, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.LinkedOperation e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum LinkedOperation</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.LinkedOperation e1, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.LinkedOperation e2)
        {
            return e2.Equals(e1);
        }
    }
}