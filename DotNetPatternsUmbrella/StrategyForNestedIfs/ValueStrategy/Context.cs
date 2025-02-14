using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyForNestedIfs
{
    internal class Context
    {
        private IValueStrategy _strategy;
        public Context(IValueStrategy strategy)
        {
            _strategy = strategy;
        }
        public void SetStrategy(IValueStrategy strategy)
        {
            _strategy = strategy;
        }
        public void ExecuteStrategy(int value)
        {
            _strategy.Evaluate(value);
        }
    }
}
