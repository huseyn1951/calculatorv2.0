using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("birinci ededi daxil edin:");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("ikinci reqemi daxil edin:");
            double num2=double.Parse(Console.ReadLine());

            Console.WriteLine("Əməliyyatı seçin: ");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Substract");
            Console.WriteLine("3. multiply");
            Console.WriteLine("4. divide");
            int choice = int.Parse(Console.ReadLine());
            double result = 0;
            switch (choice)
            {
                case 1:
                    result = calculator.Add(num1, num2);
                    break;
                case 2 :
                    result = calculator.Subtract(num1, num2);
                    break;
                case 3 :
                    result = calculator.Multiply(num1, num2);
                    break;
                case 4:
                    result = calculator.Divide(num1,num2);
                    break;
                default:
                    Console.WriteLine("incorret choice");
                    break;
            }
        }
    }
}
