// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.4.5, generator: @autorest/powershell@3.0.438)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support
{

    /// <summary>Health state for storage account</summary>
    public partial class StorageAccountHealthStateTypeConverter :
        global::System.Management.Automation.PSTypeConverter
    {

        /// <summary>
        /// Determines if the converter can convert the <see cref="sourceValue"/> parameter to the <see cref="destinationType" />
        /// parameter.
        /// </summary>
        /// <param name="sourceValue">the <see cref="System.Object"/> to convert from</param>
        /// <param name="destinationType">the <see cref="System.Type" /> to convert to</param>
        /// <returns>
        /// <c>true</c> if the converter can convert the <see cref="sourceValue"/> parameter to the <see cref="destinationType" />
        /// parameter, otherwise <c>false</c>.
        /// </returns>
        public override bool CanConvertFrom(object sourceValue, global::System.Type destinationType) => true;

        /// <summary>
        /// Determines if the converter can convert the <see cref="sourceValue"/> parameter to the <see cref="destinationType" />
        /// parameter.
        /// </summary>
        /// <param name="sourceValue">the <see cref="System.Object"/> to convert from</param>
        /// <param name="destinationType">the <see cref="System.Type" /> to convert to</param>
        /// <returns>
        /// <c>true</c> if the converter can convert the <see cref="sourceValue"/> parameter to the <see cref="destinationType" />
        /// parameter, otherwise <c>false</c>.
        /// </returns>
        public override bool CanConvertTo(object sourceValue, global::System.Type destinationType) => false;

        /// <summary>
        /// Converts the <see cref="sourceValue" /> parameter to the <see cref="destinationType" /> parameter using <see cref="formatProvider"
        /// /> and <see cref="ignoreCase" />
        /// </summary>
        /// <param name="sourceValue">the <see cref="System.Object"/> to convert from</param>
        /// <param name="destinationType">the <see cref="System.Type" /> to convert to</param>
        /// <param name="formatProvider">not used by this TypeConverter.</param>
        /// <param name="ignoreCase">when set to <c>true</c>, will ignore the case when converting.</param>
        /// <returns>
        /// an instance of <see cref="StorageAccountHealthState" />, or <c>null</c> if there is no suitable conversion.
        /// </returns>
        public override object ConvertFrom(object sourceValue, global::System.Type destinationType, global::System.IFormatProvider formatProvider, bool ignoreCase) => StorageAccountHealthState.CreateFrom(sourceValue);

        /// <summary>NotImplemented -- this will return <c>null</c></summary>
        /// <param name="sourceValue">the <see cref="System.Object"/> to convert from</param>
        /// <param name="destinationType">the <see cref="System.Type" /> to convert to</param>
        /// <param name="formatProvider">not used by this TypeConverter.</param>
        /// <param name="ignoreCase">when set to <c>true</c>, will ignore the case when converting.</param>
        /// <returns>will always return <c>null</c>.</returns>
        public override object ConvertTo(object sourceValue, global::System.Type destinationType, global::System.IFormatProvider formatProvider, bool ignoreCase) => null;
    }
}