using Moq;

namespace HelloWorldPatterns.Tests.Services
{
    public class ConsoleServiceTests
    {
        [Fact]
        public void ConsoleServiceSendsOutputToFacade()
        {
            var consoleFacadeMock = new Moq.Mock<HelloWorldPatterns.Facades.IConsoleFacade>();
            var iterator = new Iterators.StringIterator();
            var console = new HelloWorldPatterns.Services.ConsoleService(
                consoleFacadeMock.Object,
                new Mediators.InputMediator(),
                iterator);

            console
                .Write("Hello, World!")
                .ToConsole();

            consoleFacadeMock.Verify(s => s.WriteLine("Hello, World!"), Times.Once);
        }
    }
}
