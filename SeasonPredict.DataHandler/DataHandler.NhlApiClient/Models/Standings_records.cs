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
    public partial class Standings_records : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The conference property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::DataHandler.NhlApiClient.Models.Standings_records_conference? Conference { get; set; }
#nullable restore
#else
        public global::DataHandler.NhlApiClient.Models.Standings_records_conference Conference { get; set; }
#endif
        /// <summary>The division property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::DataHandler.NhlApiClient.Models.Standings_records_division? Division { get; set; }
#nullable restore
#else
        public global::DataHandler.NhlApiClient.Models.Standings_records_division Division { get; set; }
#endif
        /// <summary>The league property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::DataHandler.NhlApiClient.Models.Standings_records_league? League { get; set; }
#nullable restore
#else
        public global::DataHandler.NhlApiClient.Models.Standings_records_league League { get; set; }
#endif
        /// <summary>The standingsType property</summary>
        public global::DataHandler.NhlApiClient.Models.Standings_records_standingsType? StandingsType { get; set; }
        /// <summary>The teamRecords property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::DataHandler.NhlApiClient.Models.Standings_records_teamRecords>? TeamRecords { get; set; }
#nullable restore
#else
        public List<global::DataHandler.NhlApiClient.Models.Standings_records_teamRecords> TeamRecords { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::DataHandler.NhlApiClient.Models.Standings_records"/> and sets the default values.
        /// </summary>
        public Standings_records()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::DataHandler.NhlApiClient.Models.Standings_records"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::DataHandler.NhlApiClient.Models.Standings_records CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::DataHandler.NhlApiClient.Models.Standings_records();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "conference", n => { Conference = n.GetObjectValue<global::DataHandler.NhlApiClient.Models.Standings_records_conference>(global::DataHandler.NhlApiClient.Models.Standings_records_conference.CreateFromDiscriminatorValue); } },
                { "division", n => { Division = n.GetObjectValue<global::DataHandler.NhlApiClient.Models.Standings_records_division>(global::DataHandler.NhlApiClient.Models.Standings_records_division.CreateFromDiscriminatorValue); } },
                { "league", n => { League = n.GetObjectValue<global::DataHandler.NhlApiClient.Models.Standings_records_league>(global::DataHandler.NhlApiClient.Models.Standings_records_league.CreateFromDiscriminatorValue); } },
                { "standingsType", n => { StandingsType = n.GetEnumValue<global::DataHandler.NhlApiClient.Models.Standings_records_standingsType>(); } },
                { "teamRecords", n => { TeamRecords = n.GetCollectionOfObjectValues<global::DataHandler.NhlApiClient.Models.Standings_records_teamRecords>(global::DataHandler.NhlApiClient.Models.Standings_records_teamRecords.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::DataHandler.NhlApiClient.Models.Standings_records_conference>("conference", Conference);
            writer.WriteObjectValue<global::DataHandler.NhlApiClient.Models.Standings_records_division>("division", Division);
            writer.WriteObjectValue<global::DataHandler.NhlApiClient.Models.Standings_records_league>("league", League);
            writer.WriteEnumValue<global::DataHandler.NhlApiClient.Models.Standings_records_standingsType>("standingsType", StandingsType);
            writer.WriteCollectionOfObjectValues<global::DataHandler.NhlApiClient.Models.Standings_records_teamRecords>("teamRecords", TeamRecords);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
