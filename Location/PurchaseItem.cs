using System.Collections.Generic;
using TextAdventureGame.Items;

namespace TextAdventureGame.Location
{
    public class PurchaseItem : Location
    {
        private Item _itemToPurchase;

        public PurchaseItem(Item item) : base(
            $"{_itemToPurchase.Name}",
            new List<string>
            {
                $"Congratulations! You've purchased {_itemToPurchase.Name}.",
                "What would you like to do next?",
                "Return to village (yes/no)?"
            },
            "Return to village (yes/no)?"
        )
        {
            _itemToPurchase = item;
        }

        public override LocationResult HandleInput(string input)
        {
            input = input.ToLower();
            if (input == "yes")
            {
                return LocationResult.Transition(new ObserveVillage());
            }
            else if (input == "no")
            {
                return LocationResult.Transition(new ReturnToForest());
            }
            else
            {
                return LocationResult.Continue;
            }
        }
    }
}
