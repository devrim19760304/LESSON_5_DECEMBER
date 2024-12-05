# Circle Calculator

A  console application written in C# to calculate the **area** and **perimeter** of a circle based on user input.

## Features

- **Input Validation**: Ensures the user enters a valid number. The application gracefully handles invalid inputs and allows users to quit by typing `x`.
- **Circle Calculations**:
  - Calculates the **area** and **perimeter** of a circle using the radius provided by the user.
- **Formatted Output**: Presents results in a clean and readable format.

## How to Run

1. Clone the repository or download the source code.
2. Open the project in your favorite C# IDE (e.g., Visual Studio).
3. Build and run the application.
4. Follow the on-screen instructions to calculate the area and perimeter of a circle.

## Usage

1. **Start the application**:
   - The program prompts you to enter the radius of a circle.
2. **Provide input**:
   - Enter a valid numeric value for the radius.
   - If the input is invalid, you'll be asked to try again or quit by typing `x`.
3. **View results**:
   - The program will display the calculated area and perimeter in a formatted output.
4. **Exit or continue**:
   - After each calculation, you'll have the option to perform another calculation or exit the program.

## Code Structure

### `Program.cs`

This file contains the main logic of the application:
- Starts the program and controls the flow using a loop.
- Interacts with the `Circle` class for calculations and displays results.

### `Circle.cs`

This file defines the `Circle` class:
- **Properties**:
  - `Radius`: Represents the radius of the circle.
- **Methods**:
  - `CheckConvert(string? userInput)`: Validates and converts user input to a numeric value.
  - `CalcArea(double radius)`: Calculates the area of the circle.
  - `CalcPerim(double radius)`: Calculates the perimeter of the circle.
  - `ShowCalculation(double radius)`: Displays the calculated area and perimeter in a formatted way.

## Example Output

```
----Circle Calculator
Enter radius of the circle:
5
****************************************************
Calculation Results for a Circle with Radius: 5
----------------------------------------------------
Area      : 78.54
Perimeter : 31.42
****************************************************
exit or new calculation? (y/n)
```

## Requirements

- .NET 6.0 or higher
- A C# IDE (e.g., Visual Studio or VS Code)

## Contributing

Feel free to fork this repository and submit pull requests with improvements or new features!

## License

This project is licensed under the MIT License. See the `LICENSE` file for details.

