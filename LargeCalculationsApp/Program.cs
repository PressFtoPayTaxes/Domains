using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace LargeCalculationsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 100000;

            BigInteger numbersFactorial = 1;

            for (int i = 1; i < number; i++)
            {
                numbersFactorial *= i;
            }
        }
    }
}
