using System.Collections.Generic;

namespace TextAdventureGame.Location
{
    public class EastPath : Location
    {
        public EastPath() : base(
            "East Path",
            new List<string>
            {
                "Intrigued by the light, you head east towards the flickering source.",
                "As you move closer, the forest begins to thin out, and the air becomes warmer.",
                "After walking for about half an hour, you emerge from the treeline to find a small, quaint village.",
                "The flickering light you saw earlier comes from a large bonfire in the village square.",
                "Villagers are gathered around, some dancing, others talking animatedly."
            },
            "Do you approach the village or observe from afar? (approach/observe)"
        )
        {
            _transitions = new Dictionary<string, Location>
            {
                {"approach", new Village()},
                {"observe", new ObserveVillage()}
            };
        }
    }
}