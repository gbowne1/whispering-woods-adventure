using System.Collections.Generic;
using TextAdventureGame.Items;
using TextAdventureGame.Location;
using TextAdventureGame.Character;

namespace TextAdventureGame.Characters
{
    public class PlayerCharacter : Character
    {
        public Inventory PlayerInventory { get; set; }
        public Location CurrentLocation { get; set; }
        public List<Location> VisitedLocations { get; set; }

        public PlayerCharacter(string name)
            : base(name, "Hello, adventurer!")
        {
            PlayerInventory = new Inventory();
            CurrentLocation = null;
            VisitedLocations = new List<Location>();
        }

        public void MoveTo(Location destination)
        {
            if (destination != null)
            {
                Console.WriteLine($"You travel to the {destination.Description}.");
                CurrentLocation = destination;
                VisitedLocations.Add(destination);
            }
            else
            {
                Console.WriteLine("Destination not found.");
            }
        }

        public void PickUp(Item item)
        {
            if (item != null)
            {
                PlayerInventory.AddItem(item.Name, 1);
                Console.WriteLine($"You picked up a {item.Name}.");
            }
            else
            {
                Console.WriteLine("Nothing to pick up.");
            }
        }

        public void DropItem(Item item)
        {
            if (PlayerInventory.RemoveItem(item.Name, 1))
            {
                Console.WriteLine($"You dropped a {item.Name}.");
            }
            else
            {
                Console.WriteLine("You don't have that item to drop.");
            }
        }

        public void InteractWith(NonPlayerCharacter npc)
        {
            if (npc != null)
            {
                npc.Speak();
                // Additional logic for interacting with NPCs can be added here.
            }
            else
            {
                Console.WriteLine("No one to interact with.");
            }
        }
    }
}