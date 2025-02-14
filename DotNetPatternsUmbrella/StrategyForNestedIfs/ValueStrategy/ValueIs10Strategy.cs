namespace StrategyForNestedIfs
{
    internal class ValueIs10Strategy : IValueStrategy
    {
        public void Evaluate(int value)
        {
            Console.WriteLine("Value is 10");
            if (value > 5)
            {
                Console.WriteLine("Value is greater than 5");
                if (value < 15)
                {
                    Console.WriteLine("Value is less than 15");
                }
            }
        }
    }
}
