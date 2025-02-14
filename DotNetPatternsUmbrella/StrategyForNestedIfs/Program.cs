namespace StrategyForNestedIfs
{
    class Program
    {
        static void Main(string[] args)
        {
            EvaluateValueService.EvaluateValues(20);
            Console.WriteLine("-----");
            EvaluateValueService.EvaluateValuesUsingStrategyPattern(10);
            Console.WriteLine("-----");
            EvaluateValueService.EvaluateValuesUsingSwitchPattern(14);
        }
    }
}
