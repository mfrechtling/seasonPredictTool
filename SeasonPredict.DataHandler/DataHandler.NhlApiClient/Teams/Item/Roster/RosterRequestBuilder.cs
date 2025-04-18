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
namespace DataHandler.NhlApiClient.Teams.Item.Roster
{
    /// <summary>
    /// Builds and executes requests for operations under \teams\{id}\roster
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class RosterRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::DataHandler.NhlApiClient.Teams.Item.Roster.RosterRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RosterRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/teams/{id}/roster{?season*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::DataHandler.NhlApiClient.Teams.Item.Roster.RosterRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RosterRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/teams/{id}/roster{?season*}", rawUrl)
        {
        }
        /// <summary>
        /// Get an NHL team&apos;s roster.
        /// </summary>
        /// <returns>A <see cref="global::DataHandler.NhlApiClient.Models.Rosters"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::DataHandler.NhlApiClient.Models.Error">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::DataHandler.NhlApiClient.Models.Rosters?> GetAsync(Action<RequestConfiguration<global::DataHandler.NhlApiClient.Teams.Item.Roster.RosterRequestBuilder.RosterRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::DataHandler.NhlApiClient.Models.Rosters> GetAsync(Action<RequestConfiguration<global::DataHandler.NhlApiClient.Teams.Item.Roster.RosterRequestBuilder.RosterRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "404", global::DataHandler.NhlApiClient.Models.Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::DataHandler.NhlApiClient.Models.Rosters>(requestInfo, global::DataHandler.NhlApiClient.Models.Rosters.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get an NHL team&apos;s roster.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::DataHandler.NhlApiClient.Teams.Item.Roster.RosterRequestBuilder.RosterRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::DataHandler.NhlApiClient.Teams.Item.Roster.RosterRequestBuilder.RosterRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::DataHandler.NhlApiClient.Teams.Item.Roster.RosterRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::DataHandler.NhlApiClient.Teams.Item.Roster.RosterRequestBuilder WithUrl(string rawUrl)
        {
            return new global::DataHandler.NhlApiClient.Teams.Item.Roster.RosterRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get an NHL team&apos;s roster.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class RosterRequestBuilderGetQueryParameters 
        {
            /// <summary>Return a team&apos;s specific season.</summary>
            [QueryParameter("season")]
            public double? Season { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class RosterRequestBuilderGetRequestConfiguration : RequestConfiguration<global::DataHandler.NhlApiClient.Teams.Item.Roster.RosterRequestBuilder.RosterRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
