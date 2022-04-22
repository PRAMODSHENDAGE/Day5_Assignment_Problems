using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Assignment_Problems
{
    internal class EvenOdd
    {
        public static void EvenOrOdd()
        {
            int i;
            Console.WriteLine();
            Console.WriteLine("\nEven Or Odd");
            Console.Write("\nEnter a Number : ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write("Entered Number is an Even Number");
                Console.Read();
            }
            else
            {
                Console.Write("Entered Number is an Odd Number");
                Console.Read();
            }
        }
    }
}
