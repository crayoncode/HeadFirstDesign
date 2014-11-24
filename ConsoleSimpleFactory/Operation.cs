using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleSimpleFactory
{
    public class Operation
    {
        private double _numberA = 1;
        private double _numberB = 2;

        public double NumberA
        {
            get { return _numberA; }
            set { _numberA = value; }
        }

        public double NumberB
        {
            get { return _numberB; }
            set { _numberB = value; }
        }

        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }

    }
}
