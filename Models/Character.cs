namespace WhisperingWoodsAdventure.Models
{
    /// <summary>
    /// Base class for all characters in the game, including players and NPCs.
    /// </summary>
    public abstract class Character
    {
        /// <summary>
        /// The name of the character.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A description of the character.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The current health of the character.
        /// </summary>
        public int Health { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Character"/> class.
        /// </summary>
        /// <param name="name">Name of the character.</param>
        /// <param name="description">Description of the character.</param>
        /// <param name="health">Health value of the character.</param>
        protected Character(string name, string description, int health)
        {
            Name = name;
            Description = description;
            Health = health;
        }

        /// <summary>
        /// Makes the character speak.
        /// </summary>
        public abstract void Speak();
    }
}
