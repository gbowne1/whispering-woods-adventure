using WhisperingWoodsAdventure.Models;
using WhisperingWoodsAdventure.Scenes;

namespace WhisperingWoodsAdventure.Core
{
    /// <summary>
    /// Processes commands and routes them to game logic.
    /// </summary>
    public static class CommandProcessor
    {
        /// <summary>
        /// Executes a command based on player input.
        /// </summary>
        /// <param name="command">The player's command.</param>
        /// <param name="state">Current game state manager.</param>
        public static void Process(string command, StateManager state)
        {
            switch (command)
            {
                case "help":
                    ShowHelp();
                    break;

                case "inventory":
                    state.Player.Inventory.ListItems();
                    break;

                case "look":
                    state.CurrentLocation.Describe();
                    break;

                case "observe":
                    ObserveVillage.Observe(); // contextually this could be dynamic
                    break;

                case "explore":
                    Explore.RandomEvent();
                    break;

                case "north":
                case "south":
                case "east":
                case "west":
                    var next = state.CurrentLocation.GetExit(command);
                    if (next != null)
                    {
                        state.CurrentLocation = next;
                        Console.WriteLine($"You move {command}...");
                    }
                    else
                    {
                        Console.WriteLine("You can't go that way.");
                    }
                    break;

                case "quit":
                case "exit":
                    state.IsRunning = false;
                    break;

                default:
                    Console.WriteLine("I don't understand that command.");
                    break;
            }
        }

        private static void ShowHelp()
        {
            Console.WriteLine("Commands:");
            Console.WriteLine("- north, south, east, west: Move around");
            Console.WriteLine("- look: Re-describe current area");
            Console.WriteLine("- inventory: View your items");
            Console.WriteLine("- explore: See what happens nearby");
            Console.WriteLine("- observe: Observe your surroundings");
            Console.WriteLine("- quit: Leave the game");
        }
    }
}
