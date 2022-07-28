using System;

namespace HelloWorldPatterns.Services
{
    public interface IConsoleService
    {
        public ConsoleService Write(string input);
        public void ToConsole();
    }
}
