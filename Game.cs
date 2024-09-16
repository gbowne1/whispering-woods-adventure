using System;
using System.Collections.Generic;
using TextAdventureGame.Location;
using TextAdventureGame.Utils;
using TextAdventureGame.Character;

namespace TextAdventureGame
{
    public class Game
    {
        private Location _currentLocation;
        private Player _player;

        private readonly InputHandler _inputHandler;

        public Game()
        {
            _inputHandler = new InputHandler();
            _currentLocation = new ForestClearing();
            _player = new Player();
        }

        public void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(_currentLocation.GetDescription());
                var input = Console.ReadLine().ToLower();

                // Remove this line
                // _currentLocation.Display();

                string validInput = _inputHandler.GetValidInput(_currentLocation.GetPrompt());
                switch (_currentLocation.HandleInput(validInput))
                {
                    case LocationResult.Continue:
                        break;
                    case LocationResult.Transition:
                        _currentLocation = _currentLocation.Transition(validInput);
                        break;
                    case LocationResult.End:
                        return;
                }
            }
        }
    }
}
