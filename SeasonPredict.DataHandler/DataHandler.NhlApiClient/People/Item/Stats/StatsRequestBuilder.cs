// <auto-generated/>
#pragma warning disable CS0618
using DataHandler.NhlApiClient.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace DataHandler.NhlApiClient.People.Item.Stats
{
    /// <summary>
    /// Builds and executes requests for operations under \people\{id}\stats
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class StatsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::DataHandler.NhlApiClient.People.Item.Stats.StatsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public StatsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/people/{id}/stats?stats={stats}{&season*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::DataHandler.NhlApiClient.People.Item.Stats.StatsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public StatsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/people/{id}/stats?stats={stats}{&season*}", rawUrl)
        {
        }
        /// <summary>
        /// Get specific statistics for an NHL player.
        /// </summary>
        /// <returns>A <see cref="global::DataHandler.NhlApiClient.Models.PlayerStats"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::DataHandler.NhlApiClient.Models.Error">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::DataHandler.NhlApiClient.Models.PlayerStats?> GetAsync(Action<RequestConfiguration<global::DataHandler.NhlApiClient.People.Item.Stats.StatsRequestBuilder.StatsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::DataHandler.NhlApiClient.Models.PlayerStats> GetAsync(Action<RequestConfiguration<global::DataHandler.NhlApiClient.People.Item.Stats.StatsRequestBuilder.StatsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "404", global::DataHandler.NhlApiClient.Models.Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::DataHandler.NhlApiClient.Models.PlayerStats>(requestInfo, global::DataHandler.NhlApiClient.Models.PlayerStats.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get specific statistics for an NHL player.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::DataHandler.NhlApiClient.People.Item.Stats.StatsRequestBuilder.StatsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::DataHandler.NhlApiClient.People.Item.Stats.StatsRequestBuilder.StatsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::DataHandler.NhlApiClient.People.Item.Stats.StatsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::DataHandler.NhlApiClient.People.Item.Stats.StatsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::DataHandler.NhlApiClient.People.Item.Stats.StatsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get specific statistics for an NHL player.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class StatsRequestBuilderGetQueryParameters 
        {
            /// <summary>Return a team&apos;s specific season.</summary>
            [QueryParameter("season")]
            public double? Season { get; set; }
            /// <summary>Stats explanations:  * `homeAndAway` - Provides a split between home and away games.  * `byMonth` - Monthly split of stats.  * `byDayOfWeek` - Split done by day of the week.  * `goalsByGameSituation` - Shows number on when goals for a player happened like how many in the shootout, how many in each period, etc.  * `onPaceRegularSeason` - This only works with the current in-progress season and shows projected totals based on current onPaceRegularSeason.  * `regularSeasonStatRankings` - Returns where someone stands vs the rest of the league for a specific regularSeasonStatRankings  * `statsSingleSeason` - Obtains single season statistics for a player.  * `vsConference` - Conference stats split.  * `vsDivision` - Division stats split.  * `vsTeam` - Conference stats split.  * `winLoss` - Very similar to the previous modifier except it provides the W/L/OT split instead of Home and Away.</summary>
            [Obsolete("This property is deprecated, use StatsAsGetStatsQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("stats")]
            public string? Stats { get; set; }
#nullable restore
#else
            [QueryParameter("stats")]
            public string Stats { get; set; }
#endif
            /// <summary>Stats explanations:  * `homeAndAway` - Provides a split between home and away games.  * `byMonth` - Monthly split of stats.  * `byDayOfWeek` - Split done by day of the week.  * `goalsByGameSituation` - Shows number on when goals for a player happened like how many in the shootout, how many in each period, etc.  * `onPaceRegularSeason` - This only works with the current in-progress season and shows projected totals based on current onPaceRegularSeason.  * `regularSeasonStatRankings` - Returns where someone stands vs the rest of the league for a specific regularSeasonStatRankings  * `statsSingleSeason` - Obtains single season statistics for a player.  * `vsConference` - Conference stats split.  * `vsDivision` - Division stats split.  * `vsTeam` - Conference stats split.  * `winLoss` - Very similar to the previous modifier except it provides the W/L/OT split instead of Home and Away.</summary>
            [QueryParameter("stats")]
            public global::DataHandler.NhlApiClient.People.Item.Stats.GetStatsQueryParameterType? StatsAsGetStatsQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class StatsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::DataHandler.NhlApiClient.People.Item.Stats.StatsRequestBuilder.StatsRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
