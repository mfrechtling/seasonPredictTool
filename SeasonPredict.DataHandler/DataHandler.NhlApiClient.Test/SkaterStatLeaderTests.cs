using System.Threading.Tasks;
using FluentAssertions;

namespace DataHandler.NhlApiClient.Test;

public class SkaterStatLeaderTests : NhlApiClientTestBase
{

    [TestCase(20242025, 2)]
    [TestCase(20012002, 3)]
    public async Task GetStatsLeaders_ReturnsValidResponse(int year, int gameType)
    {
        var result = await apiClient.V1.SkaterStatsLeaders[year][gameType].GetAsync();
        result.Should().NotBeNull();
    }

    [TestCaseSource(nameof(TestCategories))]
    public async Task GetStatsLeaders_CanFilterResponseByCategory(string category)
    {
        var result = await apiClient.V1.SkaterStatsLeaders[20202021][2].GetAsync(x => x.QueryParameters.Categories = category);
        result.Should().NotBeNull();
        foreach (var kvp in result.AdditionalData)
        {
            kvp.Key.Should().Be(category);
        }
    }

    [Test]
    public async Task GetCurrentStatsLeaders_ReturnsValidResponse()
    {
        var result = await apiClient.V1.SkaterStatsLeaders.Current.GetAsync();
        result.Should().NotBeNull();
    }

    [TestCaseSource(nameof(TestCategories))]
    public async Task GetCurrentStatsLeaders_CanFilterResponseByCategory(string category)
    {
        var result = await apiClient.V1.SkaterStatsLeaders.Current.GetAsync(x => x.QueryParameters.Categories = category);
        result.Should().NotBeNull();
        foreach (var kvp in result.AdditionalData)
        {
            kvp.Key.Should().Be(category);
        }
    }

    [Test]
    public async Task GetCurrentStatsLeaders_CanSetMaxResponses()
    {
        var result = await apiClient.V1.SkaterStatsLeaders.Current.GetAsync(x => x.QueryParameters.Limit = 3);
        result.Should().NotBeNull();
    }

    static IEnumerable<string> TestCategories()
    {
        yield return "goals";
        yield return "assists";
        yield return "goalsSh";
        yield return "plusMinus";
        yield return "goalsPp";
        yield return "faceoffLeaders";
        yield return "penaltyMins";
        yield return "points";
        yield return "toi";
    }
}
