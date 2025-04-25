using System;
using WhisperingWoodsAdventure.Models;

namespace WhisperingWoodsAdventure.GameLogic
{
    /// <summary>
    /// Core game class that controls the adventure flow.
    /// </summary>
    public class Game
    {
        private Player? _player;
        private Location? _currentLocation;
        private bool _isRunning = true;

        /// <summary>
        /// Starts the game by setting up the player and game world.
        /// </summary>
        public void Start()
        {
            Console.Clear();
            Console.WriteLine("🌲 Welcome to Whispering Woods Adventure! 🌲");
            Console.Write("What is your name, adventurer? ");
            string playerName = Console.ReadLine() ?? "Wanderer";

            _player = new Player(playerName, "A brave soul venturing into the unknown.", 100);
            SetupWorld();

            GameLoop();
        }

        /// <summary>
        /// Initializes all locations and links them.
        /// </summary>
        private void SetupWorld()
        {
            var village = new Location("Village", "A quiet village with cobblestone paths and warm hearths.");
            var forest = new Location("Forest Clearing", "A peaceful forest clearing with birds singing.");
            var northPath = new Location("North Path", "A winding trail disappearing into the misty hills.");

            village.AddExit("north", forest);
            forest.AddExit("south", village);
            forest.AddExit("north", northPath);
            northPath.AddExit("south", forest);

            _currentLocation = village;
        }

        /// <summary>
        /// Runs the main game loop, taking input and updating game state.
        /// </summary>
        private void GameLoop()
        {
            while (_isRunning)
            {
                Console.WriteLine("\n------------------------------\n");
                _currentLocation!.Describe();

                Console.Write("\nWhat do you do? (type 'help') > ");
                string input = Console.ReadLine()?.Trim().ToLower() ?? "";

                HandleInput(input);
            }

            Console.WriteLine("\nThanks for playing, adventurer!");
        }

        /// <summary>
        /// Processes player input and calls appropriate methods.
        /// </summary>
        /// <param name="input">The raw input string from the player.</param>
        private void HandleInput(string input)
        {
            switch (input)
            {
                case "help":
                    ShowHelp();
                    break;

                case "inventory":
                    _player!.Inventory.ListItems();
                    break;

                case "quit":
                case "exit":
                    _isRunning = false;
                    break;

                default:
                    TryMove(input);
                    break;
            }
        }

        /// <summary>
        /// Displays the available player commands.
        /// </summary>
        private void ShowHelp()
        {
            Console.WriteLine("Available commands:");
            Console.WriteLine("- north, south, east, west: Move in a direction");
            Console.WriteLine("- inventory: Show your inventory");
            Console.WriteLine("- help: Show this help text");
            Console.WriteLine("- quit: Exit the game");
        }

        /// <summary>
        /// Attempts to move the player in the given direction.
        /// </summary>
        /// <param name="direction">The direction the player wants to move.</param>
        private void TryMove(string direction)
        {
            var next = _currentLocation!.GetExit(direction);
            if (next != null)
            {
                _currentLocation = next;
                Console.WriteLine($"You move {direction}...");
            }
            else
            {
                Console.WriteLine("You can't go that way.");
            }
        }
    }
}
