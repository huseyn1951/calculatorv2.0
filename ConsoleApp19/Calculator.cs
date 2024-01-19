using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Calculator:ICalculator
    {
        public double Add(double num1, double num2)
        {
            Console.WriteLine($"Add result is {num1 + num2}");
            return 0;
        }

        public double Subtract(double num1, double num2)
        {
            Console.WriteLine($"substract result is {num1 - num2}");
            return 0;
        }

        public double Multiply(double num1, double num2)
        {
            Console.WriteLine($"Multiply result is {num1 * num2}");
            return 0;
        }

        public double Divide(double num1, double num2)
        {
            Console.WriteLine($"Divide result is {num1 / num2}");
            return 0;
        }
    }
}
