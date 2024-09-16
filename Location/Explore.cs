using System.Collections.Generic;

namespace TextAdventureGame.Location
{
    public class Explore : Location
    {
        private string _currentLocation;

        public Explore(string locationName) : base(
            $"Explore {locationName}",
            new List<string>
            {
                $"You begin to explore the {locationName}.",
                "As you look around, you notice:",
                "What do you see?",
                "Examine surroundings (yes/no)?"
            },
            "Examine surroundings (yes/no)?"
        )
        {
            _transitions = new Dictionary<string, Location>
            {
                {"yes", new DetailedDescription()},
                {"no", new ContinueExploring()}
            };
        }
    }
}
