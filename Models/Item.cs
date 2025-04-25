namespace WhisperingWoodsAdventure.Models
{
    /// <summary>
    /// Represents an item that can be picked up, used, or traded.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// The name of the item.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A description of what the item is or does.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The value of the item (used for trading or scoring).
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Item"/> class.
        /// </summary>
        /// <param name="name">Item name.</param>
        /// <param name="description">Item description.</param>
        /// <param name="value">Item value.</param>
        public Item(string name, string description, int value)
        {
            Name = name;
            Description = description;
            Value = value;
        }
    }
}
