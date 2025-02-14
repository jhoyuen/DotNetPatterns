namespace StrategyForNestedIfs
{
    internal static class EvaluateValueService
    {
        private static Dictionary<int, IValueStrategy> valueDictionary = new Dictionary<int, IValueStrategy>
            {
                { 10, new ValueIs10Strategy() },
                { 20, new ValueIs20Strategy() }
            };

        internal static void EvaluateValuesUsingStrategyPattern(int value)
        {
            var valueStrategy = valueDictionary.TryGetValue(value, out var strategy) ? strategy : new DefaultStrategy();
            var context = new Context(valueStrategy);
            context.ExecuteStrategy(value);
        }

        internal static void EvaluateValues(int value)
        {
            if (value == 10)
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
            else if (value == 20)
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
            else
            {
                Console.WriteLine("Value is neither 10 nor 20");
            }
        }
        internal static void EvaluateValuesUsingSwitchPattern(int value)
        {
            var result = value switch
            {
                int n when n == 10 && n > 5 && n < 15 => "Value is 10\nValue is greater than 5\nValue is less than 15",
                int n when n == 20 && n > 15 && n < 25 => "Value is 20\nValue is greater than 15\nValue is less than 25",
                _ => "Value is neither 10 nor 20"
            };
            Console.WriteLine(result);
        }
    }
}
