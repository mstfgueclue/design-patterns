namespace design_patterns.CommandPattern;

public class CancelOrderCommand : ICommand
{
    public void Execute()
    {
        // Implementation to cancel an order
        Console.WriteLine("Cancelling an order...");
    }
}