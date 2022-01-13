using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole5
{
    class Program
    {
        static int factorial(int n)
        {
            int factorial = 1;
            if (n == 1)
                return 1;
            else if (n < 0)
                return -1;
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    factorial *= i;
                }
                return factorial;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            int res = 0;

            for (int i = 1; i <= n; i++)
                res += factorial(i);
            Console.WriteLine($"Result = {res}");
        }
    }
}
