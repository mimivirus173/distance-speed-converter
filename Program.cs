using System;

namespace speeddistToTime
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Terminal editing
            Console.Title = "Speed and Distance to Time converter";

            // Loops the program
            while (true)
            {
                Convert();
            }
        }

        public static void Convert()
        {
            // Variables
            float speed;
            float dist;
            
            // Program
            while (true)
            {
                // Prompts the user for velocity
                Console.Write("Input a velocity in m/s: ", Console.ForegroundColor = ConsoleColor.White);
                string inputSpeed = Console.ReadLine();

                // Check for valid input
                if (float.TryParse(inputSpeed, out speed)) {
                    if (speed > 0) {
                        // Prompts the user for distance
                        Console.Write("Input a distance in km: ");
                        string inputDist = Console.ReadLine();

                        // Check for valid input
                        if (float.TryParse(inputDist, out dist)) {
                            if (dist > 0) {
                                Console.WriteLine("Calculating time...");
                                
                                // Calculate time
                                float result = dist / (speed/1000);
                                TimeSpan t = TimeSpan.FromSeconds( result );
                                string answer = string.Format("{0:D2}h:{1:D2}m:{2:D2}s:{3:D3}ms", 
                                t.Hours, 
                                t.Minutes, 
                                t.Seconds, 
                                t.Milliseconds);

                                // Print result
                                Console.Write("Time to cross the given distance: ");
                                Console.Write(" " + answer, Console.ForegroundColor = ConsoleColor.Green);
                                Console.WriteLine("\n------------------", Console.ForegroundColor = ConsoleColor.White);
                            } else {
                                Console.WriteLine("Invalid input!", Console.ForegroundColor = ConsoleColor.Red);
                            }
                        } else {
                            Console.WriteLine("Invalid input!", Console.ForegroundColor = ConsoleColor.Red);
                        }
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