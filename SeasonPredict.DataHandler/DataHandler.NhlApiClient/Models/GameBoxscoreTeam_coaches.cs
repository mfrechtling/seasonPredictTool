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
    public partial class GameBoxscoreTeam_coaches : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The person property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::DataHandler.NhlApiClient.Models.GameBoxscoreTeam_coaches_person? Person { get; set; }
#nullable restore
#else
        public global::DataHandler.NhlApiClient.Models.GameBoxscoreTeam_coaches_person Person { get; set; }
#endif
        /// <summary>The position property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::DataHandler.NhlApiClient.Models.GameBoxscoreTeam_coaches_position? Position { get; set; }
#nullable restore
#else
        public global::DataHandler.NhlApiClient.Models.GameBoxscoreTeam_coaches_position Position { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::DataHandler.NhlApiClient.Models.GameBoxscoreTeam_coaches"/> and sets the default values.
        /// </summary>
        public GameBoxscoreTeam_coaches()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::DataHandler.NhlApiClient.Models.GameBoxscoreTeam_coaches"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::DataHandler.NhlApiClient.Models.GameBoxscoreTeam_coaches CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::DataHandler.NhlApiClient.Models.GameBoxscoreTeam_coaches();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "person", n => { Person = n.GetObjectValue<global::DataHandler.NhlApiClient.Models.GameBoxscoreTeam_coaches_person>(global::DataHandler.NhlApiClient.Models.GameBoxscoreTeam_coaches_person.CreateFromDiscriminatorValue); } },
                { "position", n => { Position = n.GetObjectValue<global::DataHandler.NhlApiClient.Models.GameBoxscoreTeam_coaches_position>(global::DataHandler.NhlApiClient.Models.GameBoxscoreTeam_coaches_position.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::DataHandler.NhlApiClient.Models.GameBoxscoreTeam_coaches_person>("person", Person);
            writer.WriteObjectValue<global::DataHandler.NhlApiClient.Models.GameBoxscoreTeam_coaches_position>("position", Position);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
