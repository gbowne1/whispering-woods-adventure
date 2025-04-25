namespace WhisperingWoodsAdventure.Models
{
    /// <summary>
    /// Represents the main player character.
    /// </summary>
    public class Player : Character
    {
        /// <summary>
        /// Gets the player's inventory.
        /// </summary>
        public PlayerInventory Inventory { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Player"/> class.
        /// </summary>
        /// <param name="name">Name of the player.</param>
        /// <param name="description">Player description.</param>
        /// <param name="health">Starting health of the player.</param>
        public Player(string name, string description, int health)
            : base(name, description, health)
        {
            Inventory = new PlayerInventory();
        }

        /// <inheritdoc/>
        public override void Speak()
        {
            Console.WriteLine($"{Name} says: I'm ready for adventure!");
        }
    }
}
