using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,]ar = new int[2, 3];
            int [,] ar1 = new int[,]
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };
            Console.WriteLine(ar1[1, 2]);

        }
    }
}
