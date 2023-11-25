namespace design_patterns.FactoryPattern;

public class NonFictionBook : Book
{
    // Specific properties for fiction books
    private string Topic { get; set; }

    public NonFictionBook(string title, string author, string topic) : base(title, author)
    {
        Topic = topic;
        Console.WriteLine($"Creating a non-fiction book: {Title} by {Author} with topic {Topic}");
    }
}