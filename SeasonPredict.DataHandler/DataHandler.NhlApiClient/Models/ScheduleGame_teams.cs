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
    public partial class ScheduleGame_teams : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The away property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::DataHandler.NhlApiClient.Models.ScheduleGame_teams_away? Away { get; set; }
#nullable restore
#else
        public global::DataHandler.NhlApiClient.Models.ScheduleGame_teams_away Away { get; set; }
#endif
        /// <summary>The home property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::DataHandler.NhlApiClient.Models.ScheduleGame_teams_home? Home { get; set; }
#nullable restore
#else
        public global::DataHandler.NhlApiClient.Models.ScheduleGame_teams_home Home { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::DataHandler.NhlApiClient.Models.ScheduleGame_teams"/> and sets the default values.
        /// </summary>
        public ScheduleGame_teams()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::DataHandler.NhlApiClient.Models.ScheduleGame_teams"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::DataHandler.NhlApiClient.Models.ScheduleGame_teams CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::DataHandler.NhlApiClient.Models.ScheduleGame_teams();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "away", n => { Away = n.GetObjectValue<global::DataHandler.NhlApiClient.Models.ScheduleGame_teams_away>(global::DataHandler.NhlApiClient.Models.ScheduleGame_teams_away.CreateFromDiscriminatorValue); } },
                { "home", n => { Home = n.GetObjectValue<global::DataHandler.NhlApiClient.Models.ScheduleGame_teams_home>(global::DataHandler.NhlApiClient.Models.ScheduleGame_teams_home.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::DataHandler.NhlApiClient.Models.ScheduleGame_teams_away>("away", Away);
            writer.WriteObjectValue<global::DataHandler.NhlApiClient.Models.ScheduleGame_teams_home>("home", Home);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
