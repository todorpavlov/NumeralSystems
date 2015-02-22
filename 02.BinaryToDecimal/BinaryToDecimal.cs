//  Problem 2. Binary to decimal

//  Write a program to convert binary numbers to their decimal representation.

using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.WriteLine("Binary To Decimal\n");

        Console.Write("Please, enter a binary number: ");
        string binary = Console.ReadLine();
        long inDecimal = Convert.ToInt32(binary, 2);
        
        Console.WriteLine("The decimal representation of {0} is {1}\n", binary, inDecimal);
    }
}