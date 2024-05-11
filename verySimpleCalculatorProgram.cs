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

        static int Calculator()
        {
            Console.WriteLine("Welcome to the Calculator Program...");
            Console.WriteLine("1 -> +\n2 -> -\n3 -> /\n4 -> *");
            Console.Write("Please enter the number of your chosen operator: ");
            int op = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine()); ;
            Console.Write("Please enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            if (op == 1)
            {
                return num1 + num2;
            }else if (op == 2)
            {
                return num1 - num2;
            }else if (op == 3)
            {
                return num1 / num2;
            }else
            {
                return num1 * num2;
            }
        }
        
    }
}
