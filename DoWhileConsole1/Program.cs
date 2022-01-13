using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0;
            do
            {
                Console.Write("");
                n = int.Parse(Console.ReadLine());
                sum += n; 
            } while (n != 0);
            Console.WriteLine($"Summa = {sum}");
        }
    }
}
