namespace HelloWorldPatterns.Services
{
    public class ConsoleService : IConsoleService
    {
        private readonly Facades.IConsoleFacade _console;
        private readonly Mediators.InputMediator _input;
        private readonly Iterators.IIterator<string, char> _iter;

        public ConsoleService(
            Facades.IConsoleFacade console,
            Mediators.InputMediator inputMediator,
            Iterators.IIterator<string, char> iterator)
        {
            _console = console;
            _input = inputMediator;
            _iter = iterator;
        }

        public ConsoleService Write(string input)
        {
            var iterator = new Iterators.StringIterator();
            iterator.ProcessInput(input, (c) => _input.AddCharacter(c));
            return this;
        }

        public void ToConsole()
        {
            _console.WriteLine(_input.ToString());

            _input.Clear();
        }
    }
}
