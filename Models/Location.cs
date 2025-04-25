using System.Collections.Generic;

namespace WhisperingWoodsAdventure.Models
{
    /// <summary>
    /// Represents a location in the game world with connected exits.
    /// </summary>
    public class Location
    {
        /// <summary>
        /// Name of the location.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description of the location.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Directions and the locations they lead to.
        /// </summary>
        public Dictionary<string, Location> Exits { get; } = new();

        /// <summary>
        /// Initializes a new instance of the <see cref="Location"/> class.
        /// </summary>
        /// <param name="name">Location name.</param>
        /// <param name="description">Location description.</param>
        public Location(string name, string description)
        {
            Name = name;
            Description = description;
        }

        /// <summary>
        /// Describes the location and its exits.
        /// </summary>
        public void Describe()
        {
            Console.WriteLine($"{Name}\n{Description}");

            if (Exits.Count > 0)
            {
                Console.WriteLine("\nYou can go:");
                foreach (var exit in Exits.Keys)
                    Console.WriteLine($"- {exit}");
            }
        }

        /// <summary>
        /// Adds an exit to another location.
        /// </summary>
        /// <param name="direction">Direction name.</param>
        /// <param name="location">Target location.</param>
        public void AddExit(string direction, Location location)
        {
            Exits[direction.ToLower()] = location;
        }

        /// <summary>
        /// Gets a location by direction.
        /// </summary>
        /// <param name="direction">Direction to look.</param>
        /// <returns>The location if found; otherwise, null.</returns>
        public Location? GetExit(string direction)
        {
            Exits.TryGetValue(direction.ToLower(), out var location);
            return location;
        }
    }
}
