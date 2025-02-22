using System;

namespace MathOperationApp
{
    // Define a class named MathOperations
    public class MathOperations
    {
        // Define a void method named PerformOperation that takes two integers as parameters
        public void PerformOperation(int firstNumber, int secondNumber)
        {
            // Perform a math operation on the first integer (e.g., multiply by 2)
            int result = firstNumber * 2;

            // Display the second integer to the screen
            Console.WriteLine($"The result of the math operation on the first number is: {result}");
            Console.WriteLine($"The second number displayed is: {secondNumber}");
        }
    }

    // Main program class
    class Program
    {
        // Entry point of the program
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the PerformOperation method, passing in two numbers (positional arguments)
            mathOps.PerformOperation(5, 10);

            // Call the PerformOperation method, specifying the parameters by name (named arguments)
            mathOps.PerformOperation(firstNumber: 8, secondNumber: 15);
        }
    }
}