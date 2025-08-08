using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer:");

            string input = Console.ReadLine();
            CheckEvenOrOdd(input);
        }
        static void CheckEvenOrOdd(string input)
        {
            // Try to parse the input as an integer
            if (int.TryParse(input, out int number))
            {
                // Check if the number is even or odd
                if (number % 2 == 0)
                {
                    Console.WriteLine("The number is even.");
                }
                else
                {
                    Console.WriteLine("The number is odd.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}
