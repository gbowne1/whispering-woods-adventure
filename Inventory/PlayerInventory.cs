using System;
using System.Linq;

namespace TextAdventureGame
{
    public static class InputHandler
    {
        public static string GetValidInput(string prompt, string[] validOptions)
        {
            string? input;
            do
            {
                Console.WriteLine(prompt);
                input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("No input received. Please try again.");
                    continue;
                }

                input = input.ToLower();

                if (!validOptions.Contains(input))
                {
                    Console.WriteLine("Invalid choice. Please choose from the following options:");
                    foreach (string option in validOptions)
                    {
                        Console.WriteLine(option);
                    }
                }
            } while (!validOptions.Contains(input));

            return input!; // At this point, input is guaranteed to be non-null and valid
        }

        public static int GetValidIntInput(string prompt, int min, int max)
        {
            int result;
            bool isValid;

            do
            {
                Console.WriteLine(prompt);
                isValid = int.TryParse(Console.ReadLine(), out result);

                if (!isValid || result < min || result > max)
                {
                    Console.WriteLine($"Please enter a valid number between {min} and {max}.");
                    isValid = false;
                }
            } while (!isValid);

            return result;
        }
    }
}
