namespace Strategy;

public interface IStrategy
{
    void Execute();
}
 
public class ConcreteStrategyA : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("Strategy A executed.");
    }
}

public class ConcreteStrategyB : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("Strategy B executed.");
    }
}

public class Context
{
    private IStrategy _strategy;

    public Context(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void SetStrategy(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void ExecuteStrategy()
    {
        _strategy.Execute();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Context context;

        // Using Strategy A
        context = new Context(new ConcreteStrategyA());
        context.ExecuteStrategy();

        // Using Strategy B
        context.SetStrategy(new ConcreteStrategyB());
        context.ExecuteStrategy();
    }
}
