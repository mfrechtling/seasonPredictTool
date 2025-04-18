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
namespace DataHandler.NhlApiClient.Schedule
{
    /// <summary>
    /// Builds and executes requests for operations under \schedule
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ScheduleRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::DataHandler.NhlApiClient.Schedule.ScheduleRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ScheduleRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/schedule{?endDate*,expand*,startDate*,teamId*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::DataHandler.NhlApiClient.Schedule.ScheduleRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ScheduleRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/schedule{?endDate*,expand*,startDate*,teamId*}", rawUrl)
        {
        }
        /// <summary>
        /// Get the NHL game schedule.
        /// </summary>
        /// <returns>A <see cref="global::DataHandler.NhlApiClient.Models.Schedule"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::DataHandler.NhlApiClient.Models.Error">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::DataHandler.NhlApiClient.Models.Schedule?> GetAsync(Action<RequestConfiguration<global::DataHandler.NhlApiClient.Schedule.ScheduleRequestBuilder.ScheduleRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::DataHandler.NhlApiClient.Models.Schedule> GetAsync(Action<RequestConfiguration<global::DataHandler.NhlApiClient.Schedule.ScheduleRequestBuilder.ScheduleRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "404", global::DataHandler.NhlApiClient.Models.Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::DataHandler.NhlApiClient.Models.Schedule>(requestInfo, global::DataHandler.NhlApiClient.Models.Schedule.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get the NHL game schedule.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::DataHandler.NhlApiClient.Schedule.ScheduleRequestBuilder.ScheduleRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::DataHandler.NhlApiClient.Schedule.ScheduleRequestBuilder.ScheduleRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::DataHandler.NhlApiClient.Schedule.ScheduleRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::DataHandler.NhlApiClient.Schedule.ScheduleRequestBuilder WithUrl(string rawUrl)
        {
            return new global::DataHandler.NhlApiClient.Schedule.ScheduleRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get the NHL game schedule.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ScheduleRequestBuilderGetQueryParameters 
        {
            /// <summary>End date for the search.</summary>
            [QueryParameter("endDate")]
            public Date? EndDate { get; set; }
            /// <summary>Expand explanations:  * `schedule.brodcasts` - Shows the broadcasts of the game.  * `schedule.linescore` - Linescore for completed games.  * `schedule.ticket` - Provides the different places to buy tickets for the upcoming games.  * `team.schedule.previous` - Same as above but for the last game played.</summary>
            [Obsolete("This property is deprecated, use ExpandAsGetExpandQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("expand")]
            public string? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("expand")]
            public string Expand { get; set; }
#endif
            /// <summary>Expand explanations:  * `schedule.brodcasts` - Shows the broadcasts of the game.  * `schedule.linescore` - Linescore for completed games.  * `schedule.ticket` - Provides the different places to buy tickets for the upcoming games.  * `team.schedule.previous` - Same as above but for the last game played.</summary>
            [QueryParameter("expand")]
            public global::DataHandler.NhlApiClient.Schedule.GetExpandQueryParameterType? ExpandAsGetExpandQueryParameterType { get; set; }
            /// <summary>Start date for the search.</summary>
            [QueryParameter("startDate")]
            public Date? StartDate { get; set; }
            /// <summary>Limit results to a specific team. Team ids can be found through the teams endpoint</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("teamId")]
            public string? TeamId { get; set; }
#nullable restore
#else
            [QueryParameter("teamId")]
            public string TeamId { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ScheduleRequestBuilderGetRequestConfiguration : RequestConfiguration<global::DataHandler.NhlApiClient.Schedule.ScheduleRequestBuilder.ScheduleRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
