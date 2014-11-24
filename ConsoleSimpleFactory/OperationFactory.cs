using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleSimpleFactory
{
    public class OperationFactory
    {
        public static Operation createOperation(string oprea)
        {
            Operation oper = null;
            switch (oprea)
            {
                case "+":
                    oper = new OperationAdd();
                    break;

                case "-":
                    oper = new OperationSub();
                    break;
            }

            return oper;
        }
    }
}
