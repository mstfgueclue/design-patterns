namespace design_patterns.FactoryPattern;

public class FictionBook : Book
{
    // Specific properties for fiction books
    private string Genre { get; set; }
    
    public FictionBook(string title, string author, string genre) : base(title, author)
    {
        Genre = genre;
        Console.WriteLine($"Creating a fiction book: {Title} by {Author} with genre {Genre}");
    }
}