﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Assignment_Problems
{
    internal class Vowel_Or_Consonant
    {
        public static void VowelOrConsonant()
        {
            Console.WriteLine();
            Console.WriteLine("Vowel Consonant ");
            Console.WriteLine("Enter any alphabet ");

            string input = Console.ReadLine();
            switch (input)
            {
                case "a":
                    Console.WriteLine("Entered alphabet is a vowel : " + input);
                    break;

                case "i":
                    Console.WriteLine("Entered alphabet is a vowel : " + input);
                    break;

                case "o":
                    Console.WriteLine("Entered alphabet is a vowel : " + input);
                    break;

                case "u":
                    Console.WriteLine("Entered alphabet is a vowel : " + input);
                    break;

                case "e":
                    Console.WriteLine("Entered alphabet is a vowel : " + input);
                    break;

                default:
                    Console.WriteLine("Entered alphabet is a consonant : " + input);
                    break;
            }

        }
    }
}
