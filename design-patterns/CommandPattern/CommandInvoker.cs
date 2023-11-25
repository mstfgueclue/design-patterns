namespace design_patterns.CommandPattern;

public class CommandInvoker
{
    public void Invoke(ICommand command) {
        Console.WriteLine("Invoking command...");
        command.Execute();
    }
}