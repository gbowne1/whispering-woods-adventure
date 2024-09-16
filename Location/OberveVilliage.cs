using System.Collections.Generic;

namespace TextAdventureGame.Location
{
    public class ObserveVillage : Location
    {
        public ObserveVillage() : base(
            "Observe Village",
            new List<string>
            {
                "As you join the preparations, you notice the villagers are busy.",
                "They're setting up stalls and decorations for the grand festival.",
                "People are cooking delicious-smelling food and preparing drinks.",
                "You see a group of musicians rehearsing in the town square.",
                "What would you like to do?",
                "Help with preparations (yes/no)?"
            },
            "Help with preparations (yes/no)?"
        )
        {
            _transitions = new Dictionary<string, Location>
            {
                {"yes", new TradeWithMerchant()},
                {"no", new ContinueNorth()}
            };
        }
    }
}