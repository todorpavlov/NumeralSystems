//  Problem 3. Decimal to hexadecimal

//  Write a program to convert decimal numbers to their hexadecimal representation.

using System;

    class DecimalToHexadecimal
    {
        static void Main()
        {
            Console.WriteLine("Hexadecimal To Decimal\n");

            Console.Write("Enter your hex number: ");
           
            int decimalNumber = int.Parse(Console.ReadLine());
            string hexValue = decimalNumber.ToString("X");

            Console.WriteLine("The decimal representation of {0} is {1}\n", decimalNumber, hexValue);
        }
    }
