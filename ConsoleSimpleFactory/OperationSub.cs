using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleSimpleFactory
{
    public class OperationSub:Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA - NumberB;
            return result;
        }
    }
}
