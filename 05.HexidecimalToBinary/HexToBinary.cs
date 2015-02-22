//  Problem 5. Hexadecimal to binary

//  Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;

class HexToBinary
    {
        static void Main()
        {
            Console.Write("Please enter hexadecimal number: ");
            string hexNum = Console.ReadLine();

            string binNum = Convert.ToString(Convert.ToInt32(hexNum, 16), 2);

            Console.WriteLine("The hexademical number {0} in binary is {1}", hexNum, binNum);
        }
    }