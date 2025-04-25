namespace WhisperingWoodsAdventure.Scenes
{
    /// <summary>
    /// General exploration handler.
    /// </summary>
    public static class Explore
    {
        public static void RandomEvent()
        {
            var events = new[]
            {
                "You find an old coin buried in the dirt.",
                "You hear distant flute music.",
                "A crow watches you from a nearby tree."
            };

            var random = new Random();
            Console.WriteLine(events[random.Next(events.Length)]);
        }
    }
}
