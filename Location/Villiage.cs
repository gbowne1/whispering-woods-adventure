using System.Collections.Generic;

namespace TextAdventureGame.Location
{
    public class Village : Location
    {
        public Village() : base(
            "Village",
            new List<string>
            {
                "'Welcome, traveler!' he says. 'You've arrived just in time for our harvest festival. What brings you to our humble village?'",
                "'Ah, an adventurer!' the old man chuckles. 'Well, you've come to the right place. Our village has many tales to tell.'",
                "One of the villagers approaches you with a worried expression.",
                "'Our elder's favorite walking stick was stolen last night. He's very upset about it. Could you help us find it?'"
            },
            "Why are you here? (explore/rest/trade)"
        )
        {
            _transitions = new Dictionary<string, Location>
            {
                {"explore", new Explore()},
                {"rest", new RestInVillage()},
                {"trade", new TradeWithMerchant()}
            };
        }
    }
}