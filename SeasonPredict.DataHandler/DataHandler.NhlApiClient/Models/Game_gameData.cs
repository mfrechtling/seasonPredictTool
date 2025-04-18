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
    public partial class Game_gameData : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The datetime property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::DataHandler.NhlApiClient.Models.Game_gameData_datetime? Datetime { get; set; }
#nullable restore
#else
        public global::DataHandler.NhlApiClient.Models.Game_gameData_datetime Datetime { get; set; }
#endif
        /// <summary>The game property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::DataHandler.NhlApiClient.Models.Game_gameData_game? Game { get; set; }
#nullable restore
#else
        public global::DataHandler.NhlApiClient.Models.Game_gameData_game Game { get; set; }
#endif
        /// <summary>The players property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::DataHandler.NhlApiClient.Models.Player? Players { get; set; }
#nullable restore
#else
        public global::DataHandler.NhlApiClient.Models.Player Players { get; set; }
#endif
        /// <summary>The status property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::DataHandler.NhlApiClient.Models.Game_gameData_status? Status { get; set; }
#nullable restore
#else
        public global::DataHandler.NhlApiClient.Models.Game_gameData_status Status { get; set; }
#endif
        /// <summary>The teams property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::DataHandler.NhlApiClient.Models.Game_gameData_teams? Teams { get; set; }
#nullable restore
#else
        public global::DataHandler.NhlApiClient.Models.Game_gameData_teams Teams { get; set; }
#endif
        /// <summary>The venue property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::DataHandler.NhlApiClient.Models.Game_gameData_venue? Venue { get; set; }
#nullable restore
#else
        public global::DataHandler.NhlApiClient.Models.Game_gameData_venue Venue { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::DataHandler.NhlApiClient.Models.Game_gameData"/> and sets the default values.
        /// </summary>
        public Game_gameData()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::DataHandler.NhlApiClient.Models.Game_gameData"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::DataHandler.NhlApiClient.Models.Game_gameData CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::DataHandler.NhlApiClient.Models.Game_gameData();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "datetime", n => { Datetime = n.GetObjectValue<global::DataHandler.NhlApiClient.Models.Game_gameData_datetime>(global::DataHandler.NhlApiClient.Models.Game_gameData_datetime.CreateFromDiscriminatorValue); } },
                { "game", n => { Game = n.GetObjectValue<global::DataHandler.NhlApiClient.Models.Game_gameData_game>(global::DataHandler.NhlApiClient.Models.Game_gameData_game.CreateFromDiscriminatorValue); } },
                { "players", n => { Players = n.GetObjectValue<global::DataHandler.NhlApiClient.Models.Player>(global::DataHandler.NhlApiClient.Models.Player.CreateFromDiscriminatorValue); } },
                { "status", n => { Status = n.GetObjectValue<global::DataHandler.NhlApiClient.Models.Game_gameData_status>(global::DataHandler.NhlApiClient.Models.Game_gameData_status.CreateFromDiscriminatorValue); } },
                { "teams", n => { Teams = n.GetObjectValue<global::DataHandler.NhlApiClient.Models.Game_gameData_teams>(global::DataHandler.NhlApiClient.Models.Game_gameData_teams.CreateFromDiscriminatorValue); } },
                { "venue", n => { Venue = n.GetObjectValue<global::DataHandler.NhlApiClient.Models.Game_gameData_venue>(global::DataHandler.NhlApiClient.Models.Game_gameData_venue.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::DataHandler.NhlApiClient.Models.Game_gameData_datetime>("datetime", Datetime);
            writer.WriteObjectValue<global::DataHandler.NhlApiClient.Models.Game_gameData_game>("game", Game);
            writer.WriteObjectValue<global::DataHandler.NhlApiClient.Models.Player>("players", Players);
            writer.WriteObjectValue<global::DataHandler.NhlApiClient.Models.Game_gameData_status>("status", Status);
            writer.WriteObjectValue<global::DataHandler.NhlApiClient.Models.Game_gameData_teams>("teams", Teams);
            writer.WriteObjectValue<global::DataHandler.NhlApiClient.Models.Game_gameData_venue>("venue", Venue);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
