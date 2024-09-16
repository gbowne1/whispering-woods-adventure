using System.Collections.Generic;

namespace TextAdventureGame.Location
{
    public class NorthPath : Location
    {
        public NorthPath() : base(
            "North Path",
            new List<string>
            {
                "You venture north, following the path deeper into the forest.",
                "As you walk, you hear the chirping of birds and the rustling of leaves in the breeze.",
                "Squirrels scamper up the trees, their bushy tails a flash of brown.",
                "After a while, the path opens up into a small clearing.",
                "Wildflowers bloom in vibrant colors, and a gentle breeze carries their sweet scent.",
                "Further along the path, you see a lone figure sitting on a fallen log."
            },
            "Greet the old woman (yes/no)?"
        )
        {
            _transitions = new Dictionary<string, Location>
            {
                {"yes", new OldWoman()},
                {"no", new ContinueNorth()}
            };
        }
    }
}