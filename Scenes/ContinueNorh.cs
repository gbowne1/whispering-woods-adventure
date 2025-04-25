using System;

namespace WhisperingWoodsAdventure.Scenes
{
    /// <summary>
    /// Handles logic for continuing north in the adventure.
    /// </summary>
    public static class ContinueNorth
    {
        public static void Execute()
        {
            var events = new[]
            {
                "You push through a thick wall of fog and find yourself on a narrow deer trail.",
                "The trees thin slightly, revealing an ancient stone marker etched with runes.",
                "You hear the crunch of leaves behind you... but when you turn, nothing is there.",
                "A sudden gust of wind sends leaves swirling, revealing a hidden path to the northwest.",
                "A squirrel chatters angrily at you before darting up a tree with something shiny."
            };

            var random = new Random();
            var eventIndex = random.Next(events.Length);
            Console.WriteLine(events[eventIndex]);
        }
    }
}
