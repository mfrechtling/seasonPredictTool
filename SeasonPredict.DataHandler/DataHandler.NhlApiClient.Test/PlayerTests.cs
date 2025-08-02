using FluentAssertions;

namespace DataHandler.NhlApiClient.Test;

public class PlayerTests : NhlApiClientTestBase
{
    [Test]
    public async Task GetGameLog_ReturnsValidResponse()
    {
        var playerId = 8478402;
        var seasonId = 20232024;
        var gameType = 2;
        var response = await apiClient.V1.Player[playerId].GameLog[seasonId][gameType].GetAsync();
        response.Should().NotBeNull();
        response.SeasonId.Should().Be(20232024);
        response.GameTypeId.Should().Be(2);
        response.GameLog.Should().NotBeNull();
        response.GameLog.Count.Should().BeGreaterThan(0);
        response.PlayerStatsSeasons.Should().NotBeNull();
        response.PlayerStatsSeasons.Count.Should().BeGreaterThan(0);
    }

    [Test]
    public async Task GetCurrentGameLog_ReturnsValidResponse()
    {
        var playerId = 8478402;
        var response = await apiClient.V1.Player[playerId].GameLog.Now.GetAsync();
        response.Should().NotBeNull();
        response.SeasonId.Should().BeGreaterThan(0);
        response.PlayerStatsSeasons.Should().NotBeNull();
        response.PlayerStatsSeasons.Count.Should().BeGreaterThan(0);
        response.GameLog.Should().NotBeNull();
        response.GameLog.Count.Should().BeGreaterThan(0);
    }
}
