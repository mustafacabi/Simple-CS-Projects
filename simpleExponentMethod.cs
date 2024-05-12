using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace study
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetPow(4,3));
            Console.ReadLine();
        }
        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;
            for (int i = 1; i <= powNum; i++)
            {
                result = result * baseNum;
            }
            return result;
        }
    }
}
