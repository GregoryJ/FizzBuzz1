using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = String.Empty;

            for (int i = 1; i <= 100; i++)
            {
                output += $"{i} ";

                if (i % 3 == 0)
                {
                    output += "Fizz";
                }

                if (i % 5 == 0)
                {
                    output += "Buzz";
                }

                output += "\n";
            }

            Console.WriteLine(output);
        }
    }
}
