namespace design_patterns.StrategyPattern;

public class PremiumCustomerStrategy : ICustomerStrategy
{
    public void HandleCustomer(Customer customer)
    {
        // Implementation for premium customers
        Console.WriteLine($"Handling premium customer: {customer.Name}");
    }
}