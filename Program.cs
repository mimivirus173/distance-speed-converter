using System;

namespace secondsConverter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Terminal editing
            Console.Title = "Seconds Converter";

            // Main
            while (true)
            {
                ConvertSeconds();
            }
        }

        public static void ConvertSeconds()
        {
            // Variables
            float seconds;
            
            // Program
            while (true)
            {
                // Prompts the user
                Console.Write("Input an amount of seconds: ");
                
                string input = Console.ReadLine();

                // Check for valid input
                if (float.TryParse(input, out seconds)) {
                    if (seconds > 0) {
                        Console.WriteLine("------------------");
                        Console.WriteLine("Converting to minutes and hours...");

                        // Converts the seconds
                        float hours = (seconds / 120);
                        
                    } else {
                        Console.WriteLine("Invalid input!");
                    }
                } else {
                    Console.WriteLine("Invalid Input!");
                }
            }
        }
    }
}