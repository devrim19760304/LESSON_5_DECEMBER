using System;
using System.Security.Principal;
namespace lesson52
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            
            /* double givenMoney=1;
            double output=givenMoney*1000000;
            Console.WriteLine($"given {givenMoney} output {output}");
             */

            double youGive=1;
            double youWin=MillionMore(youGive);
            Console.WriteLine($"you give {youGive} you win {youWin}");

            //checking if HowLong works to see how long a string is
            Console.WriteLine("Please enter a string.");
            string? userInput = Console.ReadLine() ?? "0";
            Console.WriteLine(HowLong(userInput));


        } //end of main method

        public static double MillionMore(double fakeMoney)
        {
            double result=fakeMoney*1000000;
            //return result;
            return fakeMoney*1000000;
        }

        public static int HowLong(string toCheck)
        {
            
            int thisLong = 0;
            char[] arrayToCheck = toCheck.ToCharArray();
            thisLong = arrayToCheck.Length;
            return thisLong;
        }
    }
}

