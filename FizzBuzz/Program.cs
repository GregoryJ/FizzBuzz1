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

            if (i % 3 == 0 && i % 5 == 0)
            {
                line.Append("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                line.Append("Fizz");
            }
            else if (i % 5 == 0)
            {
                line.Append("Buzz");
            }

            else
            {
                line.Append($"{i}");
            }

            line.Append("");

            return line.ToString();
        }
    }
}

namespace FizzBuzzTests
{
    [TestFixture]
    public class ProgramTests
    {
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "Fizz")]
        [TestCase(4, "4")]
        [TestCase(5, "Buzz")]
        [TestCase(6, "Fizz")]
        [TestCase(7, "7")]
        [TestCase(8, "8")]
        [TestCase(9, "Fizz")]
        [TestCase(10, "Buzz")]
        [TestCase(11, "11")]
        [TestCase(12, "Fizz")]
        [TestCase(13, "13")]
        [TestCase(14, "14")]
        [TestCase(15, "FizzBuzz")]
        public void GenerateOutputTest(int input, string expectedOutput)
        {
            // Act
            string actualOutput = Program.GenerateOutput(input).Trim();

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}