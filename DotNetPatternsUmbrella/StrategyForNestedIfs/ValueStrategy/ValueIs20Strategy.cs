
namespace StrategyForNestedIfs
{
    internal class ValueIs20Strategy : IValueStrategy
    {
        public void Evaluate(int value)
        {
            Console.WriteLine("Value is 20");
            if (value > 15)
            {
                Console.WriteLine("Value is greater than 15");
                if (value < 25)
                {
                    Console.WriteLine("Value is less than 25");
                }
            }
        }
    }
}
