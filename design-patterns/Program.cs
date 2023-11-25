using design_patterns.CommandPattern;
using design_patterns.FactoryPattern;
using design_patterns.StrategyPattern;
using design_patterns.TemplatePattern;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Exercise: Applying Design patterns in Java / .NET");
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.White;

// Example usage of the Factory Method pattern
Console.WriteLine("Pattern: Factory");
var fictionBook = BookFactory.CreateBook("Fiction");

// Example usage of the Strategy pattern
Console.WriteLine();
Console.WriteLine("Pattern: Strategy");
var customer = new Customer { Name = "Gustaf Stark" };
ICustomerStrategy regularStrategy = new RegularCustomerStrategy();
ICustomerStrategy premiumStrategy = new PremiumCustomerStrategy();
regularStrategy.HandleCustomer(customer);
premiumStrategy.HandleCustomer(customer);

// Example usage of the Command pattern
Console.WriteLine();
Console.WriteLine("Pattern: Command");
var commandInvoker = new CommandInvoker();
var placeOrderCommand = new PlaceOrderCommand();
commandInvoker.Invoke(placeOrderCommand);

// Example usage of the Template Method pattern
Console.WriteLine();
Console.WriteLine("Pattern: Template");
var reportGenerator = new SalesReportGenerator();
reportGenerator.GenerateReport();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine();
Console.WriteLine("End of Exercise");
Console.ForegroundColor = ConsoleColor.White;