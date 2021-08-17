namespace Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Extensions;

    /// <summary>Contains information related to the health of a region.</summary>
    public partial class RegionHealthModel
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IRegionHealthModel.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IRegionHealthModel.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IRegionHealthModel FromJson(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonObject json ? new RegionHealthModel(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonObject into a new instance of <see cref="RegionHealthModel" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal RegionHealthModel(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_alertSummary = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonObject>("alertSummary"), out var __jsonAlertSummary) ? Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.AlertSummary.FromJson(__jsonAlertSummary) : AlertSummary;}
            {_usageMetric = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonArray>("usageMetrics"), out var __jsonUsageMetrics) ? If( __jsonUsageMetrics as Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IUsageMetrics[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IUsageMetrics) (Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.UsageMetrics.FromJson(__u) )) ))() : null : UsageMetric;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="RegionHealthModel" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="RegionHealthModel" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._alertSummary ? (Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonNode) this._alertSummary.ToJson(null,serializationMode) : null, "alertSummary" ,container.Add );
            if (null != this._usageMetric)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.XNodeArray();
                foreach( var __x in this._usageMetric )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("usageMetrics",__w);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}