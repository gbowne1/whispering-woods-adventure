using System.Collections.Generic;

namespace TextAdventureGame.Location
{
    public class OldWoman : Location
    {
        public OldWoman() : base(
            "Old Woman",
            new List<string>
            {
                "A wizened old woman sits on a fallen log, her eyes twinkling with age.",
                "She beckons you closer with a gnarled hand.",
                "Her voice creaks with age as she speaks in a low, mysterious tone.",
                "She offers you a choice:",
                "Do you trade with her (yes/no)?"
            },
            "Trade with the old woman (yes/no)?"
        )
        {
            _transitions = new Dictionary<string, Location>
            {
                {"yes", new RestInVillage()},
                {"no", new ContinueNorth()}
            };
        }
    }
}
