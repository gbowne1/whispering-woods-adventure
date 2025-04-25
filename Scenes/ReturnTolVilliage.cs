using WhisperingWoodsAdventure.Models;

namespace WhisperingWoodsAdventure.Scenes
{
    /// <summary>
    /// Helper logic for returning to the main village.
    /// </summary>
    public static class ReturnToVillage
    {
        public static void Execute(Player player, Location current)
        {
            Console.WriteLine("You head back to the village...");
            current = new Village(); // Or point to your initialized one
        }
    }
}
