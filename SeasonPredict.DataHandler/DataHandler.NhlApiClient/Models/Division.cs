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
    public partial class Division : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The abbreviation property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Abbreviation { get; set; }
#nullable restore
#else
        public string Abbreviation { get; set; }
#endif
        /// <summary>The active property</summary>
        public bool? Active { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The conference property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::DataHandler.NhlApiClient.Models.Division_conference? Conference { get; set; }
#nullable restore
#else
        public global::DataHandler.NhlApiClient.Models.Division_conference Conference { get; set; }
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
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::DataHandler.NhlApiClient.Models.Division"/> and sets the default values.
        /// </summary>
        public Division()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::DataHandler.NhlApiClient.Models.Division"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::DataHandler.NhlApiClient.Models.Division CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::DataHandler.NhlApiClient.Models.Division();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "abbreviation", n => { Abbreviation = n.GetStringValue(); } },
                { "active", n => { Active = n.GetBoolValue(); } },
                { "conference", n => { Conference = n.GetObjectValue<global::DataHandler.NhlApiClient.Models.Division_conference>(global::DataHandler.NhlApiClient.Models.Division_conference.CreateFromDiscriminatorValue); } },
                { "id", n => { Id = n.GetDoubleValue(); } },
                { "link", n => { Link = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("abbreviation", Abbreviation);
            writer.WriteBoolValue("active", Active);
            writer.WriteObjectValue<global::DataHandler.NhlApiClient.Models.Division_conference>("conference", Conference);
            writer.WriteDoubleValue("id", Id);
            writer.WriteStringValue("link", Link);
            writer.WriteStringValue("name", Name);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
