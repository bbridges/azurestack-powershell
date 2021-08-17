// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.4.5, generator: @autorest/powershell@3.0.438)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(FabricAdminIdentityTypeConverter))]
    public partial class FabricAdminIdentity
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.FabricAdminIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentity" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentity DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new FabricAdminIdentity(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.FabricAdminIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentity" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentity DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new FabricAdminIdentity(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.FabricAdminIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal FabricAdminIdentity(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).SubscriptionId = (string) content.GetValueForProperty("SubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).SubscriptionId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).ResourceGroupName = (string) content.GetValueForProperty("ResourceGroupName",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).ResourceGroupName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).EdgeGateway = (string) content.GetValueForProperty("EdgeGateway",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).EdgeGateway, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).EdgeGatewayPool = (string) content.GetValueForProperty("EdgeGatewayPool",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).EdgeGatewayPool, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).FabricLocation = (string) content.GetValueForProperty("FabricLocation",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).FabricLocation, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).InfraRole = (string) content.GetValueForProperty("InfraRole",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).InfraRole, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).InfraRoleInstance = (string) content.GetValueForProperty("InfraRoleInstance",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).InfraRoleInstance, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).IPPool = (string) content.GetValueForProperty("IPPool",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).IPPool, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).LogicalNetwork = (string) content.GetValueForProperty("LogicalNetwork",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).LogicalNetwork, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).LogicalSubnet = (string) content.GetValueForProperty("LogicalSubnet",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).LogicalSubnet, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).MacAddressPool = (string) content.GetValueForProperty("MacAddressPool",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).MacAddressPool, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).Operation = (string) content.GetValueForProperty("Operation",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).Operation, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).ScaleUnit = (string) content.GetValueForProperty("ScaleUnit",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).ScaleUnit, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).ScaleUnitNode = (string) content.GetValueForProperty("ScaleUnitNode",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).ScaleUnitNode, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).SlbMuxInstance = (string) content.GetValueForProperty("SlbMuxInstance",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).SlbMuxInstance, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).FileShare = (string) content.GetValueForProperty("FileShare",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).FileShare, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).StorageSubSystem = (string) content.GetValueForProperty("StorageSubSystem",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).StorageSubSystem, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).Drive = (string) content.GetValueForProperty("Drive",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).Drive, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).Volume = (string) content.GetValueForProperty("Volume",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).Volume, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).Id, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.FabricAdminIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal FabricAdminIdentity(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).SubscriptionId = (string) content.GetValueForProperty("SubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).SubscriptionId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).ResourceGroupName = (string) content.GetValueForProperty("ResourceGroupName",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).ResourceGroupName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).EdgeGateway = (string) content.GetValueForProperty("EdgeGateway",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).EdgeGateway, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).EdgeGatewayPool = (string) content.GetValueForProperty("EdgeGatewayPool",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).EdgeGatewayPool, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).FabricLocation = (string) content.GetValueForProperty("FabricLocation",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).FabricLocation, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).InfraRole = (string) content.GetValueForProperty("InfraRole",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).InfraRole, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).InfraRoleInstance = (string) content.GetValueForProperty("InfraRoleInstance",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).InfraRoleInstance, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).IPPool = (string) content.GetValueForProperty("IPPool",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).IPPool, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).LogicalNetwork = (string) content.GetValueForProperty("LogicalNetwork",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).LogicalNetwork, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).LogicalSubnet = (string) content.GetValueForProperty("LogicalSubnet",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).LogicalSubnet, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).MacAddressPool = (string) content.GetValueForProperty("MacAddressPool",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).MacAddressPool, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).Operation = (string) content.GetValueForProperty("Operation",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).Operation, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).ScaleUnit = (string) content.GetValueForProperty("ScaleUnit",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).ScaleUnit, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).ScaleUnitNode = (string) content.GetValueForProperty("ScaleUnitNode",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).ScaleUnitNode, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).SlbMuxInstance = (string) content.GetValueForProperty("SlbMuxInstance",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).SlbMuxInstance, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).FileShare = (string) content.GetValueForProperty("FileShare",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).FileShare, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).StorageSubSystem = (string) content.GetValueForProperty("StorageSubSystem",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).StorageSubSystem, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).Drive = (string) content.GetValueForProperty("Drive",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).Drive, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).Volume = (string) content.GetValueForProperty("Volume",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).Volume, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentityInternal)this).Id, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="FabricAdminIdentity" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentity FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(FabricAdminIdentityTypeConverter))]
    public partial interface IFabricAdminIdentity

    {

    }
}