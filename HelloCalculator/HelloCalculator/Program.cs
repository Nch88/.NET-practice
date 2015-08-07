using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = AddNumbers(3, 7);
            Console.WriteLine(result);
            result = AddNumbers(-3, 7);
            Console.ReadKey();
        }

        private static int AddNumbers(int number1, int number2)
        {
            int result = 0;

            result = number1 + number2;

            return result;
        }
    }
}
