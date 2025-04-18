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
    public partial class GameLinescore : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The currentPeriod property</summary>
        public double? CurrentPeriod { get; set; }
        /// <summary>The currentPeriodOrdinal property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CurrentPeriodOrdinal { get; set; }
#nullable restore
#else
        public string CurrentPeriodOrdinal { get; set; }
#endif
        /// <summary>The currentPeriodTimeRemaining property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CurrentPeriodTimeRemaining { get; set; }
#nullable restore
#else
        public string CurrentPeriodTimeRemaining { get; set; }
#endif
        /// <summary>The hasShootout property</summary>
        public bool? HasShootout { get; set; }
        /// <summary>The intermissionInfo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::DataHandler.NhlApiClient.Models.GameLinescore_intermissionInfo? IntermissionInfo { get; set; }
#nullable restore
#else
        public global::DataHandler.NhlApiClient.Models.GameLinescore_intermissionInfo IntermissionInfo { get; set; }
#endif
        /// <summary>The periods property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::DataHandler.NhlApiClient.Models.GamePeriod>? Periods { get; set; }
#nullable restore
#else
        public List<global::DataHandler.NhlApiClient.Models.GamePeriod> Periods { get; set; }
#endif
        /// <summary>The powerPlayInfo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::DataHandler.NhlApiClient.Models.GameLinescore_powerPlayInfo? PowerPlayInfo { get; set; }
#nullable restore
#else
        public global::DataHandler.NhlApiClient.Models.GameLinescore_powerPlayInfo PowerPlayInfo { get; set; }
#endif
        /// <summary>The powerPlayStrength property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PowerPlayStrength { get; set; }
#nullable restore
#else
        public string PowerPlayStrength { get; set; }
#endif
        /// <summary>The shootoutInfo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::DataHandler.NhlApiClient.Models.GameLinescore_shootoutInfo? ShootoutInfo { get; set; }
#nullable restore
#else
        public global::DataHandler.NhlApiClient.Models.GameLinescore_shootoutInfo ShootoutInfo { get; set; }
#endif
        /// <summary>The teams property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::DataHandler.NhlApiClient.Models.GameLinescore_teams? Teams { get; set; }
#nullable restore
#else
        public global::DataHandler.NhlApiClient.Models.GameLinescore_teams Teams { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::DataHandler.NhlApiClient.Models.GameLinescore"/> and sets the default values.
        /// </summary>
        public GameLinescore()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::DataHandler.NhlApiClient.Models.GameLinescore"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::DataHandler.NhlApiClient.Models.GameLinescore CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::DataHandler.NhlApiClient.Models.GameLinescore();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "currentPeriod", n => { CurrentPeriod = n.GetDoubleValue(); } },
                { "currentPeriodOrdinal", n => { CurrentPeriodOrdinal = n.GetStringValue(); } },
                { "currentPeriodTimeRemaining", n => { CurrentPeriodTimeRemaining = n.GetStringValue(); } },
                { "hasShootout", n => { HasShootout = n.GetBoolValue(); } },
                { "intermissionInfo", n => { IntermissionInfo = n.GetObjectValue<global::DataHandler.NhlApiClient.Models.GameLinescore_intermissionInfo>(global::DataHandler.NhlApiClient.Models.GameLinescore_intermissionInfo.CreateFromDiscriminatorValue); } },
                { "periods", n => { Periods = n.GetCollectionOfObjectValues<global::DataHandler.NhlApiClient.Models.GamePeriod>(global::DataHandler.NhlApiClient.Models.GamePeriod.CreateFromDiscriminatorValue)?.AsList(); } },
                { "powerPlayInfo", n => { PowerPlayInfo = n.GetObjectValue<global::DataHandler.NhlApiClient.Models.GameLinescore_powerPlayInfo>(global::DataHandler.NhlApiClient.Models.GameLinescore_powerPlayInfo.CreateFromDiscriminatorValue); } },
                { "powerPlayStrength", n => { PowerPlayStrength = n.GetStringValue(); } },
                { "shootoutInfo", n => { ShootoutInfo = n.GetObjectValue<global::DataHandler.NhlApiClient.Models.GameLinescore_shootoutInfo>(global::DataHandler.NhlApiClient.Models.GameLinescore_shootoutInfo.CreateFromDiscriminatorValue); } },
                { "teams", n => { Teams = n.GetObjectValue<global::DataHandler.NhlApiClient.Models.GameLinescore_teams>(global::DataHandler.NhlApiClient.Models.GameLinescore_teams.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("currentPeriod", CurrentPeriod);
            writer.WriteStringValue("currentPeriodOrdinal", CurrentPeriodOrdinal);
            writer.WriteStringValue("currentPeriodTimeRemaining", CurrentPeriodTimeRemaining);
            writer.WriteBoolValue("hasShootout", HasShootout);
            writer.WriteObjectValue<global::DataHandler.NhlApiClient.Models.GameLinescore_intermissionInfo>("intermissionInfo", IntermissionInfo);
            writer.WriteCollectionOfObjectValues<global::DataHandler.NhlApiClient.Models.GamePeriod>("periods", Periods);
            writer.WriteObjectValue<global::DataHandler.NhlApiClient.Models.GameLinescore_powerPlayInfo>("powerPlayInfo", PowerPlayInfo);
            writer.WriteStringValue("powerPlayStrength", PowerPlayStrength);
            writer.WriteObjectValue<global::DataHandler.NhlApiClient.Models.GameLinescore_shootoutInfo>("shootoutInfo", ShootoutInfo);
            writer.WriteObjectValue<global::DataHandler.NhlApiClient.Models.GameLinescore_teams>("teams", Teams);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
