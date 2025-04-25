namespace WhisperingWoodsAdventure.Models
{
    /// <summary>
    /// Represents a non-playable character in the game.
    /// </summary>
    public class NPC : Character
    {
        /// <summary>
        /// The default dialogue line of the NPC.
        /// </summary>
        public string Dialogue { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="NPC"/> class.
        /// </summary>
        /// <param name="name">NPC name.</param>
        /// <param name="description">NPC description.</param>
        /// <param name="health">Health of the NPC.</param>
        /// <param name="dialogue">Default dialogue line.</param>
        public NPC(string name, string description, int health, string dialogue)
            : base(name, description, health)
        {
            Dialogue = dialogue;
        }

        /// <inheritdoc/>
        public override void Speak()
        {
            Console.WriteLine($"{Name} says: {Dialogue}");
        }
    }
}
