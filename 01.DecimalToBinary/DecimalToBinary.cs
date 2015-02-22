//  Problem 1. Decimal to binary

//  Write a program to convert decimal numbers to their binary representation.

using System;

class Program
    {
        static void Main()
        {
            Console.WriteLine("Decimal To Binary\n");

            Console.Write("Enter your number: ");
            int value = int.Parse(Console.ReadLine());

            string binary = Convert.ToString(value, 2);

            Console.WriteLine("The binary representation of {0} is {1}\n", value, binary);
        }
    }
