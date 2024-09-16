using System.Collections.Generic;

namespace TextAdventureGame.Location
{
    public class ConfirmPurchase : Location
    {
        private List<string> _availableItems = new List<string>
        {
            "Rare Herb",
            "Enchanted Potion",
            "Magical Scroll",
            "Precious Gem"
        };
        private int _selectedItemIndex = 0;

        public ConfirmPurchase() : base(
            "Confirm Purchase",
            new List<string>
            {
                $"You've selected {_availableItems[_selectedItemIndex]} to purchase.",
                "Are you sure you want to buy this item?",
                "Confirm purchase (yes/no)?"
            },
            "Confirm purchase (yes/no)?"
        )
        {
            _transitions = new Dictionary<string, Location>
            {
                {"yes", new ConfirmPurchase()},
                {"no", new TradeWithMerchant()}
            };
        }
    }
}
