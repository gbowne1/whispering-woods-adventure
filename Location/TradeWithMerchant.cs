using System.Collections.Generic;
using TextAdventureGame.Items;
using TextAdventureGame.Character;

namespace TextAdventureGame.Location
{
    public class TradeWithMerchant : Location
    {
        private Shop _shop;

        public TradeWithMerchant() : base(
            "Trade with Merchant",
            new List<string>
            {
                "As you join the preparations, you approach a merchant stall.",
                "The merchant greets you warmly and offers his wares:",
                $"Available items: {_shop._availableItems[0].Name}, {_shop._availableItems[1].Name}, {_shop._availableItems[2].Name}, {_shop._availableItems[3].Name}"
            },
            "Buy an item (yes/no)?"
        )
        {
            _shop = new Shop();
            _transitions = new Dictionary<string, Location>
            {
                {"yes", _shop},
                {"no", new ContinueNorth()}
            };
        }
    }
}
