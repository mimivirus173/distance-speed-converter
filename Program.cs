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
                Console.Write("Input an amount of seconds: ", Console.ForegroundColor = ConsoleColor.White);
                string input = Console.ReadLine();

                // Check for valid input
                if (float.TryParse(input, out seconds)) {
                    if (seconds > 0) {
                        Console.WriteLine("Converting to minutes and hours...");

                        // Converts the seconds
                        TimeSpan t = TimeSpan.FromSeconds( seconds );

                        string answer = string.Format("{0:D2}h:{1:D2}m:{2:D2}s:{3:D3}ms", 
                            t.Hours, 
                            t.Minutes, 
                            t.Seconds, 
                            t.Milliseconds);
                        
                        Console.WriteLine(answer, Console.ForegroundColor = ConsoleColor.Green);
                        Console.WriteLine("------------------", Console.ForegroundColor = ConsoleColor.White);
                        
                    } else {
                        Console.WriteLine("Invalid input!", Console.ForegroundColor = ConsoleColor.Red);
                    }
                } else {
                    Console.WriteLine("Invalid Input!", Console.ForegroundColor = ConsoleColor.Red);
                }
            }
        }
    }
}