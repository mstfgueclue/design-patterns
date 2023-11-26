namespace design_patterns.FactoryPattern;

public static class BookFactory
{
    public static Book CreateBook(string type) {
        switch (type) {
            case "Fiction":
                return new FictionBook("The Great Gatsby", "F. Scott Fitzgerald", "Drama");
            case "NonFiction":
                return new NonFictionBook("The Art of War", "Sun Tzu", "Military");
            default:
                throw new ArgumentException("Invalid book type");
        }
    }
}