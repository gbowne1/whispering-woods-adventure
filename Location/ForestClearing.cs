using System.Collections.Generic;

namespace TextAdventureGame.Location
{
    public class ForestClearing : Location
    {
        public ForestClearing() : base(
            "Forest Clearing",
            new List<string>
            {
                "You stand in a small clearing surrounded by tall trees.",
                "The air is crisp and clean, filled with the scent of wildflowers.",
                "A narrow path leads north into the dense forest.",
                "To the east, you see a faint glow in the distance.",
                "What would you like to do?",
                "Go north (yes/no)?"
            },
            "Go north (yes/no)?"
        )
        {
            _transitions = new Dictionary<string, Location>
            {
                {"yes", new NorthPath()},
                {"no", new EastPath()}
            };
        }
    }
}