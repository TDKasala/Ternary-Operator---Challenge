using System;

namespace Ternary_Operator___Challenge
{
    internal class Program
    {
        // Main method to start the program
        static void Main(string[] args)
        {
            // Call the temperature method
            temperature();
            // Wait for user input before exiting
            Console.ReadKey();
        }

        // Method to determine the weather based on temperature input
        public static void temperature()
        {
            // Initialize variables
            string inputValue = string.Empty;
            int inputTemp = 0;
            string weather = string.Empty;

            // Prompt user to enter a temperature
            Console.WriteLine("Please enter a temperature:");
            inputValue = Console.ReadLine();

            // Try to parse user input into an integer
            bool validInteger = int.TryParse(inputValue, out inputTemp);
            if (validInteger)
            {
                // Determine weather using ternary operator based on temperature range
                weather = inputTemp <= 15 ? "it is too cold here" : inputTemp >= 16 && inputTemp <= 28 ? "it is ok" : inputTemp > 28 ? "it is hot here" : "";
                // Print the weather message
                Console.WriteLine(weather);
            }
            else
            {
                // Print error message for invalid temperature input
                Console.WriteLine("Not a valid temperature");
            }
        }
    }
}
