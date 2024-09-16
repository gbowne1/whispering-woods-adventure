using System.Collections.Generic;

namespace TextAdventureGame.Location
{
    public class ReturnToForest : Location
    {
        public ReturnToForest() : base(
            "Return to Forest",
            new List<string>
            {
                "You decide to return to the forest, leaving the village behind.",
                "As you walk back, you notice the trees seem taller and darker.",
                "The air grows thick with the scent of damp earth and decaying leaves.",
                "Suddenly, you hear footsteps approaching from the distance.",
                "How do you react?",
                "Investigate the noise (yes/no)?"
            },
            "Investigate the noise (yes/no)?"
        )
        {
            _transitions = new Dictionary<string, Location>
            {
                {"yes", new OldWoman()},
                {"no", new EastPath()}
            };
        }
    }
}
