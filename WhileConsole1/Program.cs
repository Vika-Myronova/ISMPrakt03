using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool isok;
            do
            {
                Console.Write("N = ");
                isok = int.TryParse(Console.ReadLine(), out n);
                if (isok == false)
                    Console.WriteLine("Помилка введення!");
                if (n < 0)
                    Console.WriteLine("Помилка введення!");
            } while (isok == false || n < 0);

            int k = 1, res = 0;
            while (n != 0)
            {
                res += (int) Math.Pow(k, n);
                k++;
                n--;
            }
            Console.WriteLine($"Result = {res}");
        }
    }
}
