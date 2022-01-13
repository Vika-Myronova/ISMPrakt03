using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            int n;
            bool isOk;
            Console.Write("A = ");
            a = double.Parse(Console.ReadLine());
            do
            {
                Console.Write("N = ");
                isOk = int.TryParse(Console.ReadLine(), out n);
                if (isOk == false)
                    Console.WriteLine("Помилка введення!");
                if (n < 0)
                    Console.WriteLine("Помилка введення!");
            } while (isOk == false || n < 0);

            double pow = 1;
            for (int i = 1; i <= n; i++) 
                pow *= a;
            Console.WriteLine($"{a} в степенi {n} = {pow}");


        }
    }
}
