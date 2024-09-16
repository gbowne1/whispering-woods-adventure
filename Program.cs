using System;
using TextAdventureGame;

namespace TextAdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Game instance
            Game game = new Game();

            // Start the game loop
            game.Run();
        }
    }
}