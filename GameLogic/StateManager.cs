using WhisperingWoodsAdventure.Models;

namespace WhisperingWoodsAdventure.Core
{
    /// <summary>
    /// Maintains the state of the game including player and location.
    /// </summary>
    public class StateManager
    {
        /// <summary>
        /// The player character.
        /// </summary>
        public Player Player { get; set; }

        /// <summary>
        /// The player's current location.
        /// </summary>
        public Location CurrentLocation { get; set; }

        /// <summary>
        /// Whether the game is currently running.
        /// </summary>
        public bool IsRunning { get; set; } = true;

        /// <summary>
        /// Initializes a new game state manager.
        /// </summary>
        /// <param name="player">The player instance.</param>
        /// <param name="startingLocation">The location where the player starts.</param>
        public StateManager(Player player, Location startingLocation)
        {
            Player = player;
            CurrentLocation = startingLocation;
        }
    }
}
