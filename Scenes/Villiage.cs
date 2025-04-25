using WhisperingWoodsAdventure.Models;

namespace WhisperingWoodsAdventure.Scenes
{
    /// <summary>
    /// The main village location.
    /// </summary>
    public class Village : Location
    {
        public Village() 
            : base("Village", "A quiet village with cobblestone streets and warm fires burning in the hearths.") { }

        /// <summary>
        /// Describes unique interactions in the village.
        /// </summary>
        public void Interact()
        {
            Console.WriteLine("You see villagers going about their daily lives. One waves at you.");
        }
    }
}
