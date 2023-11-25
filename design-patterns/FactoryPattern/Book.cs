namespace design_patterns.FactoryPattern;

public abstract class Book
{
    protected string Title { get; set; }
    protected string Author { get; set; }
    
    protected Book(string title, string author)
    {
        Title = title;
        Author = author;
    }
}