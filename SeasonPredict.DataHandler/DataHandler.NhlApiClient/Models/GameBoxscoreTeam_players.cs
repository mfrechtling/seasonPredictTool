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
    public partial class GameBoxscoreTeam_players : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The jerseyNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JerseyNumber { get; set; }
#nullable restore
#else
        public string JerseyNumber { get; set; }
#endif
        /// <summary>The person property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::DataHandler.NhlApiClient.Models.GameBoxscoreTeam_players_person? Person { get; set; }
#nullable restore
#else
        public global::DataHandler.NhlApiClient.Models.GameBoxscoreTeam_players_person Person { get; set; }
#endif
        /// <summary>The position property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::DataHandler.NhlApiClient.Models.GameBoxscoreTeam_players_position? Position { get; set; }
#nullable restore
#else
        public global::DataHandler.NhlApiClient.Models.GameBoxscoreTeam_players_position Position { get; set; }
#endif
        /// <summary>The stats property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::DataHandler.NhlApiClient.Models.GameBoxscoreTeam_players_stats? Stats { get; set; }
#nullable restore
#else
        public global::DataHandler.NhlApiClient.Models.GameBoxscoreTeam_players_stats Stats { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::DataHandler.NhlApiClient.Models.GameBoxscoreTeam_players"/> and sets the default values.
        /// </summary>
        public GameBoxscoreTeam_players()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::DataHandler.NhlApiClient.Models.GameBoxscoreTeam_players"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::DataHandler.NhlApiClient.Models.GameBoxscoreTeam_players CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::DataHandler.NhlApiClient.Models.GameBoxscoreTeam_players();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "jerseyNumber", n => { JerseyNumber = n.GetStringValue(); } },
                { "person", n => { Person = n.GetObjectValue<global::DataHandler.NhlApiClient.Models.GameBoxscoreTeam_players_person>(global::DataHandler.NhlApiClient.Models.GameBoxscoreTeam_players_person.CreateFromDiscriminatorValue); } },
                { "position", n => { Position = n.GetObjectValue<global::DataHandler.NhlApiClient.Models.GameBoxscoreTeam_players_position>(global::DataHandler.NhlApiClient.Models.GameBoxscoreTeam_players_position.CreateFromDiscriminatorValue); } },
                { "stats", n => { Stats = n.GetObjectValue<global::DataHandler.NhlApiClient.Models.GameBoxscoreTeam_players_stats>(global::DataHandler.NhlApiClient.Models.GameBoxscoreTeam_players_stats.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("jerseyNumber", JerseyNumber);
            writer.WriteObjectValue<global::DataHandler.NhlApiClient.Models.GameBoxscoreTeam_players_person>("person", Person);
            writer.WriteObjectValue<global::DataHandler.NhlApiClient.Models.GameBoxscoreTeam_players_position>("position", Position);
            writer.WriteObjectValue<global::DataHandler.NhlApiClient.Models.GameBoxscoreTeam_players_stats>("stats", Stats);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
