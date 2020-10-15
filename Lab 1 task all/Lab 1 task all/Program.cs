using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_task_all
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Pranta");

            Console.WriteLine("Enter a number :");
            String x;
            x = Console.ReadLine();
            Console.WriteLine(x);

            String y;
            y = Console.ReadLine();
            Console.WriteLine(y);

            int xa = 6;
            int ya = 4;
            int z = (xa + ya) / 2;
            Console.WriteLine(z);

            float x2 = -5 + 8 * 6;
            float y2 = (55 + 9) % 9;
            float c = 20 + (-3 * 5 / 8);
            float m = (5 + 15 / 3 * 2) - (8 % 3);
            Console.WriteLine("The 1st Results are :" + x2);
            Console.WriteLine("The 2nd Results are :" + y2);
            Console.WriteLine("The 3rd Results are :" + c);
            Console.WriteLine("The 4th Results are :" + m);
        }
    }
}
