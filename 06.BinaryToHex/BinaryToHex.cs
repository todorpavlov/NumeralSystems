//  Problem 6. Binary to hexadecimal

//  Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;

    class BinaryToHex
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary To Hexadecimal\n");

            Console.Write("Enter a binary number: ");
            string myBinary = Console.ReadLine();

            string myHex = Convert.ToString(Convert.ToInt32(myBinary, 2), 16);

            
            Console.WriteLine("Converted '{0}' to {1} \n", myBinary, myHex.ToUpper());
        }
    }
