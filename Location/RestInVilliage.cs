using System.Collections.Generic;

namespace TextAdventureGame.Location
{
    public class RestInVillage : Location
    {
        public RestInVillage() : base(
            "Rest in Village",
            new List<string>
            {
                "You decide to rest in the village for a while.",
                "The villagers welcome you warmly and offer you food and shelter.",
                "As you rest, you notice the village is bustling with activity.",
                "People are preparing for a grand festival tomorrow night.",
                "What would you like to do?",
                "Join the preparations (yes/no)?"
            },
            "Join the preparations (yes/no)?"
        )
        {
            _transitions = new Dictionary<string, Location>
            {
                {"yes", new ObserveVillage()},
                {"no", new ReturnToForest()}
            };
        }
    }
}