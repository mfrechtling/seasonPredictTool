namespace TestApp.Test;
using FluentAssertions;

public class TestAppHandlerTests
{

    private const string inputText = "this is some input text";
    private const string outputText = "This is some input text";
    private const char escapeKey = (char)ConsoleKey.Escape;
    private const char enterKey = (char)ConsoleKey.Enter;

    [Test]
    public void Handler_IsDisposedOnEscape()
    {
        using (TextReader reader = new StringReader(inputText + escapeKey))
        using (TextWriter writer = new StringWriter())
        using (var handler = new TestAppHandler())
        {
            handler.Handler(reader, writer);
            if (writer == null)
            {
                Assert.Fail();
            } else {
                writer.ToString().Should().BeNullOrEmpty();
            }
        }
    }
}
