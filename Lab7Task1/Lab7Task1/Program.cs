using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicCalcImp x = new BasicCalcImp();
            Console.WriteLine(x.sub(3,2));
            Console.WriteLine(x.sum(3, 2));

            ScientificCalImp y = new ScientificCalImp();
            Console.WriteLine(y.Exponential(2, 2));
            Console.WriteLine(y.Square(5));
            Console.WriteLine(y.Sine(5,45));


        }
    }
}
