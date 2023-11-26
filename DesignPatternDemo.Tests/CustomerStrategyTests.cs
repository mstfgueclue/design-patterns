using design_patterns.StrategyPattern;
using Moq;

namespace DesignPatternDemo.Tests;

public class CustomerStrategyTests
{
    [Fact]
    public void HandleCustomer_ShouldInvokeCorrectStrategy() {
        // Arrange
        var customer = new Customer { Name = "John Doe" };
        var strategyMock = new Mock<ICustomerStrategy>();
        strategyMock.Setup(s => s.HandleCustomer(customer)).Verifiable();

        // Act
        strategyMock.Object.HandleCustomer(customer);

        // Assert
        strategyMock.Verify(s => s.HandleCustomer(customer), Times.Once());
    }
}