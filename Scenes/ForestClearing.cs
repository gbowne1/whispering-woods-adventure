using WhisperingWoodsAdventure.Models;

namespace WhisperingWoodsAdventure.Scenes
{
    /// <summary>
    /// A peaceful clearing in the forest.
    /// </summary>
    public class ForestClearing : Location
    {
        public ForestClearing() 
            : base("Forest Clearing", "You are in a sun-dappled forest clearing. Birds sing above.") { }

        public void Interact()
        {
            Console.WriteLine("You spot a wild herb growing near a rock.");
        }
    }
}
