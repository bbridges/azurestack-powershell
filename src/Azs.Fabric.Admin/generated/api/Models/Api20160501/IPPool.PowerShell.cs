namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501
{
    using Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.PowerShell;

    /// <summary>
    /// This resource defines the range of IP addresses from which addresses are allocated for nodes within a subnet.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(IPPoolTypeConverter))]
    public partial class IPPool
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IPPool"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPool" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPool DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new IPPool(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IPPool"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPool" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPool DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new IPPool(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="IPPool" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPool FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IPPool"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal IPPool(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPoolInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPoolModel) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPoolInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IPPoolModelTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ResourceTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPoolInternal)this).StartIPAddress = (string) content.GetValueForProperty("StartIPAddress",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPoolInternal)this).StartIPAddress, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPoolInternal)this).EndIPAddress = (string) content.GetValueForProperty("EndIPAddress",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPoolInternal)this).EndIPAddress, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPoolInternal)this).AddressPrefix = (string) content.GetValueForProperty("AddressPrefix",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPoolInternal)this).AddressPrefix, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPoolInternal)this).NumberOfIPAddresses = (long?) content.GetValueForProperty("NumberOfIPAddresses",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPoolInternal)this).NumberOfIPAddresses, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPoolInternal)this).NumberOfAllocatedIPAddresses = (long?) content.GetValueForProperty("NumberOfAllocatedIPAddresses",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPoolInternal)this).NumberOfAllocatedIPAddresses, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPoolInternal)this).NumberOfIPAddressesInTransition = (long?) content.GetValueForProperty("NumberOfIPAddressesInTransition",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPoolInternal)this).NumberOfIPAddressesInTransition, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IPPool"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal IPPool(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPoolInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPoolModel) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPoolInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IPPoolModelTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ResourceTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPoolInternal)this).StartIPAddress = (string) content.GetValueForProperty("StartIPAddress",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPoolInternal)this).StartIPAddress, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPoolInternal)this).EndIPAddress = (string) content.GetValueForProperty("EndIPAddress",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPoolInternal)this).EndIPAddress, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPoolInternal)this).AddressPrefix = (string) content.GetValueForProperty("AddressPrefix",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPoolInternal)this).AddressPrefix, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPoolInternal)this).NumberOfIPAddresses = (long?) content.GetValueForProperty("NumberOfIPAddresses",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPoolInternal)this).NumberOfIPAddresses, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPoolInternal)this).NumberOfAllocatedIPAddresses = (long?) content.GetValueForProperty("NumberOfAllocatedIPAddresses",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPoolInternal)this).NumberOfAllocatedIPAddresses, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPoolInternal)this).NumberOfIPAddressesInTransition = (long?) content.GetValueForProperty("NumberOfIPAddressesInTransition",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPoolInternal)this).NumberOfIPAddressesInTransition, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// This resource defines the range of IP addresses from which addresses are allocated for nodes within a subnet.
    [System.ComponentModel.TypeConverter(typeof(IPPoolTypeConverter))]
    public partial interface IIPPool

    {

    }
}