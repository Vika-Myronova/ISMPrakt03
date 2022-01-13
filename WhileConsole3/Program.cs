using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileConsole3
{
    class Program
    {
        static void Main(string[] args)
        {
            double l = 10;
            int p;
            Console.Write("P = ");  
            p = int.Parse(Console.ReadLine());

            double sum = 10;
            int day = 1;
            while(sum < 200)
            {
                double d = l * p / 100;
                l = l + d;
                sum += l;
                day++;
            }
            Console.WriteLine($"After {day} day, {sum}км");

        }
    }
}
