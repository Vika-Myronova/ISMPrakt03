using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileConsole2
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
            } while (isok == false || n < 1);

            int k = 1, m = 0;
            double p = 0;
            while (p <= n)
            {
                p = Math.Pow(3, k);
                m = k;
                k++;
            }
            Console.WriteLine($"The least K = {m}");
        }
    }
}
