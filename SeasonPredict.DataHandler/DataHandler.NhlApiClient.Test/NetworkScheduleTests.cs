using FluentAssertions;
using Microsoft.Kiota.Abstractions;

namespace DataHandler.NhlApiClient.Test;

public class NetworkScheduleTests : NhlApiClientTestBase
{
    [Test]
    public async Task GetNetworkSchedule_ReturnsValidResponse()
    {
        var testDate = new Date(DateTime.Parse("2023-11-10"));
        var response = await apiClient.V1.Network.TvSchedule[testDate].GetAsync();
        response.Should().NotBeNull();
        response.Date.Should().Be(testDate);
        response.Broadcasts.Should().NotBeNull();
        response.Broadcasts.Count.Should().BeGreaterThan(0);
    }
}
