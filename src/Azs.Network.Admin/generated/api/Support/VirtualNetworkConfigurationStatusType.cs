// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.4.5, generator: @autorest/powershell@3.0.438)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support
{

    /// <summary>The virtual network configuration status.</summary>
    public partial struct VirtualNetworkConfigurationStatusType :
        System.IEquatable<VirtualNetworkConfigurationStatusType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.VirtualNetworkConfigurationStatusType Failure = @"Failure";

        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.VirtualNetworkConfigurationStatusType InProgress = @"InProgress";

        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.VirtualNetworkConfigurationStatusType Success = @"Success";

        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.VirtualNetworkConfigurationStatusType Uninitialized = @"Uninitialized";

        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.VirtualNetworkConfigurationStatusType Unknown = @"Unknown";

        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.VirtualNetworkConfigurationStatusType Warning = @"Warning";

        /// <summary>
        /// the value for an instance of the <see cref="VirtualNetworkConfigurationStatusType" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to VirtualNetworkConfigurationStatusType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="VirtualNetworkConfigurationStatusType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new VirtualNetworkConfigurationStatusType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type VirtualNetworkConfigurationStatusType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.VirtualNetworkConfigurationStatusType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>
        /// Compares values of enum type VirtualNetworkConfigurationStatusType (override for Object)
        /// </summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is VirtualNetworkConfigurationStatusType && Equals((VirtualNetworkConfigurationStatusType)obj);
        }

        /// <summary>Returns hashCode for enum VirtualNetworkConfigurationStatusType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for VirtualNetworkConfigurationStatusType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>
        /// Creates an instance of the <see cref="VirtualNetworkConfigurationStatusType" Enum class./>
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private VirtualNetworkConfigurationStatusType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Implicit operator to convert string to VirtualNetworkConfigurationStatusType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="VirtualNetworkConfigurationStatusType" />.</param>

        public static implicit operator VirtualNetworkConfigurationStatusType(string value)
        {
            return new VirtualNetworkConfigurationStatusType(value);
        }

        /// <summary>Implicit operator to convert VirtualNetworkConfigurationStatusType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="VirtualNetworkConfigurationStatusType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.VirtualNetworkConfigurationStatusType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum VirtualNetworkConfigurationStatusType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.VirtualNetworkConfigurationStatusType e1, Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.VirtualNetworkConfigurationStatusType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum VirtualNetworkConfigurationStatusType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.VirtualNetworkConfigurationStatusType e1, Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.VirtualNetworkConfigurationStatusType e2)
        {
            return e2.Equals(e1);
        }
    }
}