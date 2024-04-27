using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to display its multiplication table:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Multiplication table of {number}:");

            for (int i = 1; i <= 10; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} x {i} = {result}");
            }
        }
    }
}
