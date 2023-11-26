using design_patterns.CommandPattern;
using Moq;

namespace DesignPatternDemo.Tests;

public class CommandInvokerTests
{
    [Fact]
    public void Invoke_ShouldExecuteCommand() {
        // Arrange
        var commandMock = new Mock<ICommand>();
        commandMock.Setup(c => c.Execute()).Verifiable();
        var invoker = new CommandInvoker();

        // Act
        invoker.Invoke(commandMock.Object);

        // Assert
        commandMock.Verify(c => c.Execute(), Times.Once());
    }
}