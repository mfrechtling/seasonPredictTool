using FluentAssertions;

namespace DataHandler.NhlApiClient.Test;

public class PlayerInfoTests : NhlApiClientTestBase
{
    [Test]
    public void GetPlayerInfo_ReturnsValidResponse()
    {
        var playerId = 8478402;
        var response = apiClient.V1.Player[playerId].Landing.GetAsync();
        response.Should().NotBeNull();
        response.Result.Should().NotBeNull();
        response.Result.PlayerId.Should().Be(playerId);
    }
}
