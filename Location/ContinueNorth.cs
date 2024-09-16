using System.Collections.Generic;

namespace TextAdventureGame.Location
{
    public class ContinueNorth : Location
    {
        public ContinueNorth() : base(
            "Continuing North",
            new List<string>
            {
                "You continue on the north path, leaving the old woman behind.",
                "The forest grows denser, with taller trees blocking out much of the sunlight.",
                "You hear the distant sound of running water.",
                "Suddenly, you come upon a fast-moving stream.",
                "How do you proceed?",
                "Follow the stream (yes/no)?"
            },
            "Follow the stream (yes/no)?"
        )
        {
            _transitions = new Dictionary<string, Location>
            {
                {"yes", new RestInVillage()},
                {"no", new EastPath()}
            };
        }
    }
}