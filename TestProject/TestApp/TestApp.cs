namespace TestApp;

class TestApp
{
    static void Main(string[] args)
    {
        var handler = new TestAppHandler();
        handler.Handler(Console.In, Console.Out);
    }
}