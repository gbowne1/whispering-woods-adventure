using WhisperingWoodsAdventure.Models;

namespace WhisperingWoodsAdventure.Scenes
{
    /// <summary>
    /// An unfamiliar village to the east.
    /// </summary>
    public class EastVillage : Location
    {
        public EastVillage() 
            : base("East Village", "This village seems more guarded. People watch you carefully.") { }

        public void Interact()
        {
            Console.WriteLine("A stern merchant nods at you. Trade, perhaps?");
        }
    }
}
