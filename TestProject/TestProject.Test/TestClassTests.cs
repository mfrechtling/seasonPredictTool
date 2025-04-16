using FluentAssertions;

namespace TestProject.Test;

public class TestClassTests
{
    [TestCaseSource(nameof(UpperCaseStrings))]
    public void TestStartsWithUpper(string word)
    {
        bool result = word.StartsWithUpper();
        result.Should().BeTrue("Expected for '{0}': true; Actual: {1}", word, result);
    }

    [TestCaseSource(nameof(LowerCaseStrings))]
    public void TestDoesNotStartWithUpper(string word)
    {
        bool result = word.StartsWithUpper();
        result.Should().BeFalse("Expected for '{0}': false; Actual: {1}", word, result);
    }

    [TestCaseSource(nameof(NullOrEmptyStrings))]
    public void DirectCallWithNullOrEmpty(string? word)
    {
        bool result = TestClass.StartsWithUpper(word);
        result.Should().BeFalse("Expected for '{0}': false; Actual: {1}", word == null ? "<null>" : word, result);
    }

    private static IEnumerable<string?> NullOrEmptyStrings()
    {
        string?[] words = { string.Empty, null };
        return words;
    }

    private static IEnumerable<string> LowerCaseStrings()
    {
        string[] words = { "alphabet", "zebra", "abc", "αυτοκινητοβιομηχανία", "государство", "1234", ".", ";", " " };
        return words;
    }

    private static IEnumerable<string> UpperCaseStrings()
    {
        string[] words = { "Alphabet", "Zebra", "ABC", "Αθήνα", "Москва" };
        return words;
    }
}
