using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            bool isOk, isok;
            int summ = 0;
            do
            {
                Console.Write("A = ");
                isOk = int.TryParse(Console.ReadLine(), out a);
                Console.Write("B = ");
                isok = int.TryParse(Console.ReadLine(), out b);
                if (isOk == false || isok == false)
                    Console.WriteLine("Помилка введення!");
                if (a > b)
                    Console.WriteLine("Помилка введення!");

            } while (isOk == false || isOk == false || a > b);

            for (int i = a; i <= b; i++)
            {
                int n = i;
                n = (int) Math.Pow(n, 2);
                summ += n;
            }
            Console.WriteLine($"Result = {summ}");
        }
    }
}
