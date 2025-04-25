using WhisperingWoodsAdventure.Models;

namespace WhisperingWoodsAdventure.Scenes
{
    /// <summary>
    /// A narrow dirt path leading east.
    /// </summary>
    public class EastPath : Location
    {
        public EastPath() 
            : base("East Path", "A small footpath winding through tall grass and fields.") { }

        public void Interact()
        {
            Console.WriteLine("The grass rustles. Something scurries away.");
        }
    }
}
