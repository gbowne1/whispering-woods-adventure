using WhisperingWoodsAdventure.Models;

namespace WhisperingWoodsAdventure.Scenes
{
    /// <summary>
    /// A path leading further north into the woods.
    /// </summary>
    public class NorthPath : Location
    {
        public NorthPath() 
            : base("North Path", "The path narrows here. Trees close in on both sides.") { }

        public void Interact()
        {
            Console.WriteLine("You hear a howl far in the distance...");
        }
    }
}
