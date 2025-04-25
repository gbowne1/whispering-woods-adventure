using System;

namespace WhisperingWoodsAdventure.Core
{
    /// <summary>
    /// Handles input from the player and sanitizes it for processing.
    /// </summary>
    public static class InputHandler
    {
        /// <summary>
        /// Reads and cleans up input from the console.
        /// </summary>
        /// <returns>A lowercase, trimmed string.</returns>
        public static string GetCommand()
        {
            Console.Write("\n> ");
            return Console.ReadLine()?.Trim().ToLower() ?? string.Empty;
        }
    }
}
