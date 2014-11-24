using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleSimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //OperationAdd add = new OperationAdd();
            //add.NumberA = 4;
            //add.NumberB = 9;
            //Console.WriteLine(add.GetResult());

            Operation oper;
            oper = OperationFactory.createOperation("+");
            //oper.NumberA = 5;
            //oper.NumberB = 4;
            Console.WriteLine(oper.GetResult());
            Console.ReadKey();

        }
    }
}
