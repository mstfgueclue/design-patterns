namespace design_patterns.StrategyPattern;

public class RegularCustomerStrategy : ICustomerStrategy
{
    public void HandleCustomer(Customer customer)
    {
        // Implementation for regular customers
        Console.WriteLine($"Handling regular customer: {customer.Name}");
    }
}