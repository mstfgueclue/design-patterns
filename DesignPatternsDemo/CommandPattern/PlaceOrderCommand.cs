namespace design_patterns.CommandPattern;

public class PlaceOrderCommand : ICommand
{
    public void Execute()
    {
        // Implementation to place an order
        Console.WriteLine("Placing an order...");
    }
}