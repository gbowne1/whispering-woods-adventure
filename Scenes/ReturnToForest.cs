using WhisperingWoodsAdventure.Models;

namespace WhisperingWoodsAdventure.Scenes
{
    /// <summary>
    /// Logic to return to forest area.
    /// </summary>
    public static class ReturnToForest
    {
        public static void Execute(Player player, Location current)
        {
            Console.WriteLine("You return to the safety of the forest clearing.");
            current = new ForestClearing();
        }
    }
}
