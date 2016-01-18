using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder output = new StringBuilder();

            for (var i = 1; i <= 100; i++)
            {
                output.Append(GenerateOutput(i));
            }

            Console.WriteLine(output);
        }

        internal static string GenerateOutput(int i)
        {
            var line = new StringBuilder();

            line.Append($"{i} ");

            if (i % 3 == 0)
            {
                line.Append("Fizz");
            }

            if (i % 5 == 0)
            {
                line.Append("Buzz");
            }

            line.Append("\n");

            return line.ToString();
        }
    }
}

namespace FizzBuzzTests
{
    [TestFixture]
    public class ProgramTests
    {
        [TestCase(1, "1 \n")]
        [TestCase(2, "2 \n")]
        [TestCase(3, "3 Fizz\n")]
        [TestCase(4, "4 \n")]
        [TestCase(5, "5 Buzz\n")]
        [TestCase(6, "6 Fizz\n")]
        [TestCase(7, "7 \n")]
        [TestCase(8, "8 \n")]
        [TestCase(9, "9 Fizz\n")]
        [TestCase(10, "10 Buzz\n")]
        [TestCase(11, "11 \n")]
        [TestCase(12, "12 Fizz\n")]
        [TestCase(13, "13 \n")]
        [TestCase(14, "14 \n")]
        [TestCase(15, "15 FizzBuzz\n")]
        public void GenerateOutputTest(int input, string expectedOutput)
        {
            // Act
            string actualOutput = Program.GenerateOutput(input);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}