namespace circlecalc
{

    class Circle
    {

        public double Radius { get; set; }

        //since we will use built in PI we do not declare here

        //constructor. must be same name with class name 
        // i defined an empty constructor 

        public Circle()
        {

        }

        //your number check method if given data is a number or not same as yours 
        //but let us add a x menu maybe user gives up. 

        public double CheckConvert(string? userInput) //i added question mark to remove warning. 
        {
            double convertedNumber;
            // i used while loop  here 
            while (true)
            {
                // we try to convert input to double 
                if (double.TryParse(userInput, out convertedNumber))
                {
                    // if it can convert return this value
                    return convertedNumber;
                }
                else
                {
                    //if user gives char or something else we will ask but not force 
                    Console.WriteLine("it is not a number please give a number or quit (x)");
                    userInput = Console.ReadLine();

                    //if user select x quit
                    if (userInput?.ToLower() == "x" )
                    {
                        Console.WriteLine("quitting");
                        //ndicates the user chose to quit the input process by typing "x," signaling an exit or invalid operation.
                        return -1;
                    }
                }


            }


        }

        public double CalcArea(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2); // or radius*radius
            return area;
        }


        public double CalcPerim(double radius)
        {
            double perimeter = 2 * Math.PI * radius;
            return perimeter;
        }


        //let us add also a built in display method so we do not need to create a new display method inside main program

        public void ShowCalculation(double radius)
        {
            //just to get use let us use vertabim string and console out then. actually totally unnecessary :D 
            // Calculate the area and perimeter
            double area = CalcArea(radius);
            double perimeter = CalcPerim(radius);

            // Using a verbatim string to format the output
            string calculationText = $@"
            ****************************************************
            Calculation Results for a Circle with Radius: {radius}
            ----------------------------------------------------
            Area      : {area:F2}
            Perimeter : {perimeter:F2}
            ****************************************************
            ";

            // Print the result to the console
            Console.WriteLine(calculationText);





        }








    }
}