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
    public partial class GameOfficial : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The official property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::DataHandler.NhlApiClient.Models.GameOfficial_official? Official { get; set; }
#nullable restore
#else
        public global::DataHandler.NhlApiClient.Models.GameOfficial_official Official { get; set; }
#endif
        /// <summary>The officialType property</summary>
        public global::DataHandler.NhlApiClient.Models.GameOfficial_officialType? OfficialType { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::DataHandler.NhlApiClient.Models.GameOfficial"/> and sets the default values.
        /// </summary>
        public GameOfficial()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::DataHandler.NhlApiClient.Models.GameOfficial"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::DataHandler.NhlApiClient.Models.GameOfficial CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::DataHandler.NhlApiClient.Models.GameOfficial();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "official", n => { Official = n.GetObjectValue<global::DataHandler.NhlApiClient.Models.GameOfficial_official>(global::DataHandler.NhlApiClient.Models.GameOfficial_official.CreateFromDiscriminatorValue); } },
                { "officialType", n => { OfficialType = n.GetEnumValue<global::DataHandler.NhlApiClient.Models.GameOfficial_officialType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::DataHandler.NhlApiClient.Models.GameOfficial_official>("official", Official);
            writer.WriteEnumValue<global::DataHandler.NhlApiClient.Models.GameOfficial_officialType>("officialType", OfficialType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
