using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mustafa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator());
            Console.ReadLine();
        }

        static string Calculator()
        {
            Console.WriteLine("Welcome to the Calculator Program...");
            Console.WriteLine("1 -> +\n2 -> -\n3 -> /\n4 -> *");

            Console.Write("Please enter the number of your chosen operator: ");
            int op = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Please enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double result;

            if (op == 1)
            {
                result = num1 + num2;
            }
            else if (op == 2)
            {
                result = num1 - num2;
            }
            else if (op == 3)
            {
                result = num1 / num2;
            }
            else if (op == 4)
            {
                result = num1 * num2;
            }
            else
            {
                string x = "Invalid operator.";
                return x;
            }
            Console.Write("The result of the operation: ");
            return Convert.ToString(result);
            
        }

    }
}
