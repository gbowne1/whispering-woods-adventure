using System;
using System.Collections.Generic;

namespace TextAdventureGame.Location
{
    public class InputHandler
    {
        private List<string> _validOptions;

        public InputHandler()
        {
            _validOptions = new List<string>();
        }

        public string GetValidInput(string prompt, List<string> validOptions)
        {
            if (prompt == null)
            {
                throw new ArgumentNullException(nameof(prompt), "Prompt cannot be null");
            }

            Console.WriteLine(prompt ?? string.Empty); // Use null-coalescing operator
            string input;
            do
            {
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

            return input;
        }

        public void SetValidOptions(List<string> options)
        {
            _validOptions = options ?? new List<string>();
        }
    }
}
