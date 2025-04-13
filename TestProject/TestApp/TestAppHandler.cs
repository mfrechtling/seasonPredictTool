using TestProject;

namespace TestApp;

public class TestAppHandler
{
    public void Handler(TextReader reader, TextWriter writer)
    {
        while(true)
        {
            writer.WriteLine("Type a sentence you would like to test, and press Enter:");
            var inputString = reader.ReadLine();
            if (inputString == null) 
                continue;
            writer.WriteLine(inputString.StartsWithUpper());
        }
    }
}
