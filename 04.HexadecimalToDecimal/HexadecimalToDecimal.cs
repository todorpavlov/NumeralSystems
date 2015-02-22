//  Problem 4. Hexadecimal to decimal

//  Write a program to convert hexadecimal numbers to their decimal representation.

using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.WriteLine("Hexadecimal To Decimal\n");

        Console.Write("Enter your hex number: ");

        string decimalNumber = Console.ReadLine();
        int iNumber = int.Parse(decimalNumber, System.Globalization.NumberStyles.HexNumber);
        string sInt = iNumber.ToString();
        string sInt2 = Convert.ToString(Convert.ToInt32(decimalNumber, 16), 2);

        Console.WriteLine("The decimal representation of {0} is {1}\n", decimalNumber, iNumber);
    }
}
