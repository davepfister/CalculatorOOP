using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDiscussion
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorOOP newCalculator = new CalculatorOOP();
            newCalculator.value1 = 4.5;
            newCalculator.value2 = 8.6;

            Console.WriteLine(newCalculator.sum());

        }
    }
}
