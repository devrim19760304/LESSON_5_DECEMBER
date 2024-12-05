using System;

namespace circlecalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create our new instance 
            Circle circleCalc = new Circle();

            Console.WriteLine("----Circle Calculator");

            // i prefer main loop is inside of main method but it is maybe just an habit. i can control my codes better like that
            while (true)
            {
                Console.WriteLine("Enter radius of the circle ");
                string? userInput = Console.ReadLine(); //do not forget it is a string 

                //now our method will check it and convert 
                double radius = circleCalc.CheckConvert(userInput); //validation process 

                if (radius == -1)
                {
                    //user quit 
                    Console.WriteLine("Exiting");
                    break; //nothing to return just break while loop
                }

                // now we will use area and perimeter calculation
                double area = circleCalc.CalcArea(radius);
                double perimeter = circleCalc.CalcPerim(radius);

                // now we can call our display method
                circleCalc.ShowCalculation(radius);

                Console.WriteLine("exit or new calculation ? (y/n)");

                // get input from user for exit or new calculation
                string? exitInput = Console.ReadLine(); // capture user input again
                if (!string.IsNullOrEmpty(exitInput) && exitInput.ToLower().Trim()[0] == 'n')
                {
                    Console.WriteLine("Exiting...");
                    break; // Exit the loop
                }
            }
        }
    }
}
