using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BinaryToHex
{
    class Program
    {
        static void Main(string[] args)
        {
            string mybinary = "1010";
            string myhex = Convert.ToString(Convert.ToInt32(mybinary, 2), 16);

   //         int[] bases = { 2, 8, 10, 16 };
   //          string[] values = { "-1", "1", "08", "0F", "11" , "12", "30",                
   //                       "101", "255", "FF", "10000000", "80" };
      int number;

      int numBase = 10;
      string value = "1010";
        // foreach (int numBase in bases)
        // {
        //     Console.WriteLine("Base {0}:", numBase);
        //     foreach (string value in values)
        //     {

              number = Convert.ToByte(value, numBase);
              Console.WriteLine("Converted '{0}' to {1}.", value, number);
      //    }

         // Console.WriteLine(myhex.ToUpper());
         // Console.WriteLine(number);
     // }
        }
    }
}
