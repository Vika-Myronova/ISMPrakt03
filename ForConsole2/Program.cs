using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double summa = 0;
            bool isOk;
            do
            {
                Console.Write("N = ");
                isOk = int.TryParse(Console.ReadLine(), out n);
                if (isOk == false)
                    Console.WriteLine("Помилка введення!");
                if (n < 0)
                    Console.WriteLine("Помилка введення!");
            } while (isOk == false || n < 0);

            int a;
            for (int i = 1; i <= n; i++)
            {
                a = i;
                summa += 1.0 / a;
            }
            Console.WriteLine($"Summa = {{0:f5}}", summa);
        }
    }
}
