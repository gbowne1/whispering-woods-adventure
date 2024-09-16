using System.Collections.Generic;
using TextAdventureGame.Items;
using TextAdventureGame.Character;
using TextAdventureGame.Location;

namespace TextAdventureGame.Shop
{
    public class Shop : Location
    {
        private List<Item> _availableItems = new List<Item>
        {
            new Item("Rare Herb"),
            new Item("Enchanted Potion"),
            new Item("Magical Scroll"),
            new Item("Precious Gem")
        };
        private int _selectedItemIndex = 0;

        public Shop() : base(
            "Shop",
            new List<string>
            {
                "Welcome to the merchant's shop!",
                $"Available items: {_availableItems[0].Name}, {_availableItems[1].Name}, {_availableItems[2].Name}, {_availableItems[3].Name}"
            },
            "Select an item (1-4)"
        )
        {
            _transitions = new Dictionary<string, Location>
            {
                {"1", new PurchaseItem(_availableItems[0])},
                {"2", new PurchaseItem(_availableItems[1])},
                {"3", new PurchaseItem(_availableItems[2])},
                {"4", new PurchaseItem(_availableItems[3])},
                {"back", new TradeWithMerchant()}
            };

            // Initialize _selectedItemIndex based on the first transition
            _selectedItemIndex = Array.IndexOf(_transitions.Keys.ToArray(), "1");
        }

        public override List<string> GetDescriptions()
        {
            return new List<string>
            {
                $"You've selected {_availableItems[_selectedItemIndex].Name} to purchase.",
                $"Price: {_availableItems[_selectedItemIndex].Name} (Note: Prices are fictional)",
                "Do you want to proceed? (yes/no)"
            };
        }

        public override Dictionary<string, Location> GetTransitions()
        {
            return new Dictionary<string, Location>
            {
                {"yes", new PurchaseItem(_availableItems[_selectedItemIndex])},
                {"no", new TradeWithMerchant()}
            };
        }
    }
}
