namespace Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Extensions;

    /// <summary>Represents a offer details item read from the gallery item package.</summary>
    public partial class OfferDetails
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
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOfferDetails.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOfferDetails.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOfferDetails FromJson(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonObject json ? new OfferDetails(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonObject into a new instance of <see cref="OfferDetails" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal OfferDetails(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_publisherId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString>("publisherId"), out var __jsonPublisherId) ? (string)__jsonPublisherId : (string)PublisherId;}
            {_offerId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString>("offerId"), out var __jsonOfferId) ? (string)__jsonOfferId : (string)OfferId;}
            {_plan = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonArray>("plans"), out var __jsonPlans) ? If( __jsonPlans as Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IPlan[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IPlan) (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.Plan.FromJson(__u) )) ))() : null : Plan;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="OfferDetails" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="OfferDetails" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode" />.
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
            AddIf( null != (((object)this._publisherId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString(this._publisherId.ToString()) : null, "publisherId" ,container.Add );
            AddIf( null != (((object)this._offerId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString(this._offerId.ToString()) : null, "offerId" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                if (null != this._plan)
                {
                    var __w = new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.XNodeArray();
                    foreach( var __x in this._plan )
                    {
                        AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                    }
                    container.Add("plans",__w);
                }
            }
            AfterToJson(ref container);
            return container;
        }
    }
}