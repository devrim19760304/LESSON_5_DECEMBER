
using System;
namespace lesson51
{
    internal class Program
    {
       static void Main(string[] args) 
       {

        double x=4;
        double y=3;
        Console.WriteLine(Math.Round(x/y,2));

        double a= 5;
        double b= 3;
        double result = a/b;
        Console.WriteLine($"Result: {result:F2}");

        //we hardcoded PI number
        double pi=3.1415;
        Console.WriteLine(pi);
        Console.WriteLine(Math.PI);



       }
    }
}