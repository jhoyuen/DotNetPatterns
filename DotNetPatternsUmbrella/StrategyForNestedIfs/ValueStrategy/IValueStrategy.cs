using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyForNestedIfs
{
    internal interface IValueStrategy
    {
        void Evaluate(int value);
    }
}
