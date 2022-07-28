namespace HelloWorldPatterns.Facades
{
    internal class ConsoleFacade : IConsoleFacade
    {
        public void WriteLine(string line)
        {
            System.Console.WriteLine(line);
        }
    }
}
