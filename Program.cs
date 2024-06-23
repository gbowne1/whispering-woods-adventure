// See https://aka.ms/new-console-template for more information
using System;

class TextAdventureGame
{
	static void Main(string[] args)
	{
		Console.WriteLine("You find yourself standing in a dimly lit forest clearing.");
		Console.WriteLine("An ancient, moss-covered oak stands tall in the center, its branches reaching towards the dusky sky.");
		Console.WriteLine("To the north, you see a narrow path leading deeper into the woods.");
		Console.WriteLine("To the east, a faint light flickers in the distance. What do you do?");

		string choice = GetValidInput("North or East?", new string[] { "north", "east" });

		switch (choice)
		{
			case "north":
				NorthPath(choice);
				break;
			case "east":
				EastPath();
				break;
		}
	}

	static string GetValidInput(string prompt, string[] validOptions)
	{
		string? input;
		do
		{
			Console.WriteLine(prompt);
			input = Console.ReadLine();

			if (string.IsNullOrEmpty(input))
			{
				Console.WriteLine("No input received. Please try again.");
				continue;
			}

			input = input.ToLower();

			if (!validOptions.Contains(input))
			{
				Console.WriteLine("Invalid choice. Please choose from the following options:");
				foreach (string option in validOptions)
				{
					Console.WriteLine(option);
				}
			}
		} while (!validOptions.Contains(input));

		return input!; // At this point, input is guaranteed to be non-null and valid
	}


	static void NorthPath(string choice)
	{
		Console.WriteLine("You venture north, following the path deeper into the forest. Sunlight filters through the dense canopy, dappling the ground with light and shadow.");
		Console.WriteLine("As you walk, you hear the chirping of birds and the rustling of leaves in the breeze. Squirrels scamper up the trees, their bushy tails a flash of brown.");
		Console.WriteLine("After a while, the path opens up into a small clearing. Wildflowers bloom in vibrant colors, and a gentle breeze carries their sweet scent.");
		Console.WriteLine("Further along the path, you see a lone figure sitting on a fallen log. As you approach, you realize it's an old woman, her face etched with wrinkles and her eyes filled with wisdom.");

		string greet = GetValidInput("Greet the old woman (yes/no)?", new string[] { "yes", "no" });

		switch (greet)
		{
			case "yes":
				Console.WriteLine("The old woman smiles warmly as you approach. 'Welcome, traveler,' she says. 'The forest holds many secrets. Where are you headed?'");

				// Presenting options to the player
				Console.WriteLine("She asks, 'Where are you headed?'");
				Console.WriteLine("1. To explore the forest further.");
				Console.WriteLine("2. To seek shelter from the night.");
				Console.WriteLine("3. To ask about the forest's secrets.");
				Console.Write("Choose an option: ");
				int option = Convert.ToInt32(Console.ReadLine());


				// Handling the player's choice
				switch (option)
				{
					case 1:
						Console.WriteLine("You decide to continue exploring the forest. The path ahead looks inviting and full of mysteries.");
						// Continue the game based on this choice
						break;
					case 2:
						Console.WriteLine("You decide to seek shelter from the night. The old woman offers you a place under her makeshift tent.");
						// Implement shelter logic here
						break;
					case 3:
						Console.WriteLine("Curiosity piqued, you ask the old woman about the forest's secrets. She begins to share tales of ancient magic and hidden treasures.");
						// Implement secret sharing logic here
						break;
					default:
						Console.WriteLine("That's not a valid option. Try again.");
						// Re-prompt the player to choose an option
						break;
				}

				break;
			case "no":
				Console.WriteLine("The old woman nods understandingly. 'Suit yourself, traveler. The forest whispers its secrets to those who listen.'");
				break;
		}

		Console.WriteLine("Continuing your journey north, the path narrows again. The trees grow taller and denser, casting long shadows.");
		Console.WriteLine("Finally, you reach a fork in the road. One path seems well-worn and easy to follow, while the other is overgrown and shrouded in shadows. Which path do you choose (left/right)?");

		choice = GetValidInput("Left or Right?", new string[] { "left", "right" });

		switch (choice)
		{
			case "left":
            Console.WriteLine("You take the well-worn path to the left.");
            // Add more story for the left path
            break;
        case "right":
            Console.WriteLine("You bravely choose the overgrown path to the right.");
            // Add more story for the right path
            break;
        default:
            Console.WriteLine("Invalid choice. The path fades away and you find yourself back at the start.");
            break;
		}
	}

	static void EastPath()
	{
		Console.WriteLine("Intrigued by the light, you head east towards the flickering source.");
		Console.WriteLine("As you move closer, the forest begins to thin out, and the air becomes warmer.");
		Console.WriteLine("After walking for about half an hour, you emerge from the treeline to find a small, quaint village.");
		Console.WriteLine("The flickering light you saw earlier comes from a large bonfire in the village square.");
		Console.WriteLine("Villagers are gathered around, some dancing, others talking animatedly.");

		string choice = GetValidInput("Do you approach the village or observe from afar? (approach/observe)", new string[] { "approach", "observe" });

		switch (choice)
		{
			case "approach":
				ApproachVillage();
				break;
			case "observe":
				ObserveVillage();
				break;
		}
	}

	static void ApproachVillage()
	{
		Console.WriteLine("You decide to approach the village. As you near, a few villagers notice you and wave warmly.");
		Console.WriteLine("An elderly man with a kind smile steps forward to greet you.");
		Console.WriteLine("'Welcome, traveler!' he says. 'You've arrived just in time for our harvest festival. What brings you to our humble village?'");

		string reason = GetValidInput("Why are you here? (explore/rest/trade)", new string[] { "explore", "rest", "trade" });

		switch (reason)
		{
			case "explore":
				Console.WriteLine("'Ah, an adventurer!' the old man chuckles. 'Well, you've come to the right place. Our village has many tales to tell.'");
				Console.WriteLine("One of the villagers approaches you with a worried expression.");
				Console.WriteLine("He tells you, 'Our elder's favorite walking stick was stolen last night. He's very upset about it. Could you help us find it?'");

				string questResponse = GetValidInput("Will you help find the elder's walking stick? (yes/no)", new string[] { "yes", "no" });

				if (questResponse == "yes")
				{
					Console.WriteLine("Great You set off to find the elder's walking stick. Good luck!");
					// Implement the quest logic here
				}
				else
				{
					Console.WriteLine("You decline the offer. Perhaps another time.");
				}

				break;
			case "rest":
				Console.WriteLine("'Of course, of course,' the man nods understandingly. 'We have a cozy inn where you can rest your weary feet.'");
				// Add more story about resting in the village
				break;
			case "trade":
				Console.WriteLine("The man's eyes light up. 'Excellent! Our market is just opening. What sort of goods do you carry?'");

				// Initiate Trading Sequence
				TradeWithMerchant();

				break;
		}
	}

	static void TradeWithMerchant()
	{
		// Display player's inventory (assuming you have one)
		Console.WriteLine("Here's what you have in your inventory:");
		// Implement logic to display inventory items

		// Display available items from the merchant
		Console.WriteLine("The merchant offers the following goods:");
		// Implement logic to display merchant's inventory items with prices

		// Initiate trading loop
		bool continueTrading = true;
		while (continueTrading)
		{
			Console.WriteLine("What would you like to do? (buy/sell/exit)");
			string choice = Console.ReadLine().ToLower();

			switch (choice)
			{
				case "buy":
					BuyFromMerchant();
					break;
				case "sell":
					SellToMerchant();
					break;
				case "exit":
					continueTrading = false;
					Console.WriteLine("Thank you for trading! Come visit again soon.");
					break;
				default:
					Console.WriteLine("Invalid choice. Please choose from buy, sell, or exit.");
					break;
			}
		}
	}

	static void BuyFromMerchant()
	{
		// Display available items from the merchant again
		Console.WriteLine("The merchant offers the following goods:");
		// Implement logic to display merchant's inventory items with prices

		Console.WriteLine("What item would you like to buy? (Enter item name or 'cancel')");
		string itemToBuy = Console.ReadLine();

		// Implement logic to check if item exists in merchant's inventory and perform transaction (deducting gold, adding item to player's inventory)
		if (itemToBuy == "cancel")
		{
			Console.WriteLine("Transaction cancelled.");
		}
		else
		{
			// Handle successful purchase or inform player of unavailable item
		}
	}

	static void SellToMerchant()
	{
		// Display player's inventory
		Console.WriteLine("Here's what you have in your inventory:");
		// Implement logic to display inventory items

		Console.WriteLine("What item would you like to sell? (Enter item name or 'cancel')");
		string itemToSell = Console.ReadLine();

		// Implement logic to check if item exists in player's inventory and perform transaction (adding gold, removing item from player's inventory)
		if (itemToSell == "cancel")
		{
			Console.WriteLine("Transaction cancelled.");
		}
		else
		{
			// Handle successful sale or inform player of unavailable item
		}
	}

	static void ObserveVillage()
	{
		Console.WriteLine("You decide to observe the village from the edge of the forest.");
		Console.WriteLine("From your vantage point, you can see the villagers celebrating around the bonfire.");
		Console.WriteLine("There seems to be some kind of ceremony taking place.");

		string choice = GetValidInput("Do you want to continue watching or sneak closer for a better view? (watch/sneak)", new string[] { "watch", "sneak" });

		switch (choice)
		{
			case "watch":
				Console.WriteLine("You continue to watch from afar. The ceremony appears to be a blessing for a bountiful harvest.");
				// Add more details about what the player observes
				break;
			case "sneak":
				Console.WriteLine("You carefully sneak closer to get a better view.");
				Console.WriteLine("As you edge nearer, you accidentally step on a dry twig. It snaps loudly in the quiet night.");
				Console.WriteLine("A few villagers turn to look in your direction...");
				// Add more story about being discovered or narrowly avoiding detection
				break;
		}
	}

}