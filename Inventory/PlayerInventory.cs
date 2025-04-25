using System.Collections.Generic;
using System.Linq;

namespace WhisperingWoodsAdventure.Models
{
    /// <summary>
    /// Manages the player's inventory of items.
    /// </summary>
    public class PlayerInventory
    {
        private readonly List<Item> _items = new();

        /// <summary>
        /// Adds an item to the inventory.
        /// </summary>
        /// <param name="item">The item to add.</param>
        public void AddItem(Item item) => _items.Add(item);

        /// <summary>
        /// Removes an item from the inventory.
        /// </summary>
        /// <param name="item">The item to remove.</param>
        public void RemoveItem(Item item) => _items.Remove(item);

        /// <summary>
        /// Checks if the inventory contains an item by name.
        /// </summary>
        /// <param name="itemName">The name of the item.</param>
        /// <returns>True if the item exists; otherwise, false.</returns>
        public bool HasItem(string itemName) =>
            _items.Any(i => i.Name.Equals(itemName, StringComparison.OrdinalIgnoreCase));

        /// <summary>
        /// Lists all items in the inventory.
        /// </summary>
        public void ListItems()
        {
            if (!_items.Any())
            {
                Console.WriteLine("Your inventory is empty.");
                return;
            }

            Console.WriteLine("Inventory:");
            foreach (var item in _items)
                Console.WriteLine($"- {item.Name}: {item.Description}");
        }
    }
}
