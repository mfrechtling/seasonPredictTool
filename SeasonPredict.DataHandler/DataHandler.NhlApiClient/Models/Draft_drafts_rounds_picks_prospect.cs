// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace DataHandler.NhlApiClient.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Draft_drafts_rounds_picks_prospect : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The fullName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FullName { get; set; }
#nullable restore
#else
        public string FullName { get; set; }
#endif
        /// <summary>The id property</summary>
        public double? Id { get; set; }
        /// <summary>The link property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Link { get; set; }
#nullable restore
#else
        public string Link { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::DataHandler.NhlApiClient.Models.Draft_drafts_rounds_picks_prospect"/> and sets the default values.
        /// </summary>
        public Draft_drafts_rounds_picks_prospect()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::DataHandler.NhlApiClient.Models.Draft_drafts_rounds_picks_prospect"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::DataHandler.NhlApiClient.Models.Draft_drafts_rounds_picks_prospect CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::DataHandler.NhlApiClient.Models.Draft_drafts_rounds_picks_prospect();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "fullName", n => { FullName = n.GetStringValue(); } },
                { "id", n => { Id = n.GetDoubleValue(); } },
                { "link", n => { Link = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("fullName", FullName);
            writer.WriteDoubleValue("id", Id);
            writer.WriteStringValue("link", Link);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
