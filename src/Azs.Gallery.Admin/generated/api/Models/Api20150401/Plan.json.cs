namespace Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Extensions;

    /// <summary>Represents a plan item read from the gallery item package.</summary>
    public partial class Plan
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IPlan.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IPlan.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IPlan FromJson(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonObject json ? new Plan(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonObject into a new instance of <see cref="Plan" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal Plan(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_id = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString>("planId"), out var __jsonPlanId) ? (string)__jsonPlanId : (string)Id;}
            {_displayName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString>("displayName"), out var __jsonDisplayName) ? (string)__jsonDisplayName : (string)DisplayName;}
            {_summary = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString>("summary"), out var __jsonSummary) ? (string)__jsonSummary : (string)Summary;}
            {_description = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString>("description"), out var __jsonDescription) ? (string)__jsonDescription : (string)Description;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="Plan" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="Plan" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._id)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString(this._id.ToString()) : null, "planId" ,container.Add );
            AddIf( null != (((object)this._displayName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString(this._displayName.ToString()) : null, "displayName" ,container.Add );
            AddIf( null != (((object)this._summary)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString(this._summary.ToString()) : null, "summary" ,container.Add );
            AddIf( null != (((object)this._description)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString(this._description.ToString()) : null, "description" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}