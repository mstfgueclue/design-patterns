using design_patterns.FactoryPattern;

namespace DesignPatternDemo.Tests;

public class BookFactoryTests
{
    [Fact]
    public void CreateBook_ShouldCreateFictionBook_WhenFictionTypeIsGiven() {
        // Arrange
        const string type = "Fiction";

        // Act
        var book = BookFactory.CreateBook(type);

        // Assert
        Assert.IsType<FictionBook>(book);
    }

    [Fact]
    public void CreateBook_ShouldCreateNonFictionBook_WhenNonFictionTypeIsGiven() {
        // Arrange
        const string type = "NonFiction";

        // Act
        var book = BookFactory.CreateBook(type);

        // Assert
        Assert.IsType<NonFictionBook>(book);
    }
}