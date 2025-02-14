namespace StrategyForNestedIfs
{
    internal class DefaultStrategy : IValueStrategy
    {
        public void Evaluate(int value)
        {
            Console.WriteLine("Value is neither 10 nor 20");
        }
    }
}
