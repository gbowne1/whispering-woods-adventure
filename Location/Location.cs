using System.Collections.Generic;

namespace TextAdventureGame.Location
{
    public abstract class Location
    {
        protected string _name;
        protected Dictionary<string, Location> _transitions;
        protected List<string> _dialogueLines;
        protected string _prompt;

        protected Location(string name, List<string> dialogueLines, string prompt)
        {
            _name = name;
            _dialogueLines = dialogueLines;
            _prompt = prompt;
            _transitions = new Dictionary<string, Location>();
        }

        public virtual void Display()
        {
            foreach (var line in _dialogueLines)
            {
                Console.WriteLine(line);
            }
        }

        public virtual string GetPrompt()
        {
            return _prompt;
        }

        public virtual LocationResult HandleInput(string input)
        {
            input = input.ToLower();
            if (_transitions.ContainsKey(input))
            {
                return LocationResult.Transition(_transitions[input]);
            }
            else if (input == "quit")
            {
                return LocationResult.End;
            }
            else
            {
                return LocationResult.Continue;
            }
        }

        public virtual Location Transition(string direction)
        {
            return _transitions[direction];
        }
    }

    public enum LocationResult
    {
        Continue,
        Transition,
        End
    }
}