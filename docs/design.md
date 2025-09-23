# Whispering Woods Adventure - Design Document

## Project Overview
### Game Title

Whispering Woods Adventure

## Genre

Text-based adventure game with elements of exploration, puzzle-solving, and light RPG mechanics. Inspired by classic games like Zork and Colossal Cave Adventure (aka Adventure), with some open-world influences from Runescape, such as resource gathering, NPC interactions, and a dynamic world.

## Platform and Technology

Runtime Environment: .NET 7 or .NET 8 (cross-compatible where possible).

Development Tool: This was initially created using `dotnet new console` for a terminal-based application.

Input/Output: Runs in terminal/shell environments with text input for commands and text output for descriptions, status, and feedback.

Dependencies: Core .NET libraries including System, System.Collections.Generic, and System.Linq. No external NuGet packages unless explicitly added (e.g., for JSON serialization if saving/loading is implemented).

## Project Structure:

## Root

Program.cs (entry point for the game loop).

## Namespaces/Folders

GameLogic: Handles core mechanics like command parsing, event handling, and game state updates.

Models: Data classes for entities like Character, Item, Location, NPC, and Player.

Inventory: Manages player and NPC inventories, item interactions.

Scenes: Defines areas, paths, villages, and their connections (e.g., via Location models).

## Key Constraints:

No hard-coded game descriptions: All text (e.g., location descriptions, item lore, NPC dialogues) should be
loaded from configurable sources like JSON files, resource files, or in-memory data structures that can be easily modified.

This is a non-commercial, fun project for personal development and potential collaboration.

## Target Audience

Hobbyist developers, retro game enthusiasts, and players who enjoy narrative-driven text adventures. 
Assumes players are comfortable with typing commands in a terminal.

## High-Level Goals

Create an immersive world centered around a mysterious whispering forest with 8 villages connected by roads.
Incorporate environmental dynamics like weather, day/night cycles, seasons, and time to affect gameplay.
Allow for extensible story, features, and content via a modular design.

## Story and World Building

## Setting

The game is set in a fantastical world called the Whispering Woods, a vast enchanted forest filled with secrets, creatures, and ancient magic. At the heart is a central Forest Clearing, from which 8 roads radiate in different directions (North, South, East, West, Northeast, Northwest, Southeast, Southwest) leading to 8 unique villages. Each village has its own theme, culture, and quests.

Central Hub: Forest Clearing – A neutral starting point with whispers from the trees hinting at lore.

Villages (Fill in blanks for themes, key features, and connections):

Village 1: Elderglow  A village illuminated by ancient, glowing lanterns, suggesting wisdom and warmth.
Village 2: Mistvale  A cozy hamlet surrounded by thorny brambles, hinting at hidden secrets.
Village 3: Bramblewick
Village 4: Starhollow
Viliage 5: Willowshade
Village 6: Duskbloom
Village 7: Oakenspire
Village 8: Farrowfen

Roads/Paths: Each road is a series of connected Locations (e.g., "Winding Path North", "Overgrown Trail"). They may include encounters, puzzles, or environmental hazards.

## Plot Summary

[High-level story outline:]

Main Quest: [Describe core objective]
Side Quests: [List ideas per village, e.g., "Help a blacksmith in Village 1 forge a magical sword."]
Ending Variations: [e.g., "Multiple endings based on player choices, alliances, and time management."]

## Lore and Themes

Whispering Woods: The forest "whispers" clues, warnings, or story elements based on time/weather.
Dynamic Elements: Weather, time, and seasons influence events (e.g., certain paths flood in rain, NPCs sleep at night).
Light crafting, trading with NPCs, skill-based progression (e.g., gathering herbs in seasons).

## Gameplay Mechanics

### Core Loop

Display current location description, status (health, inventory, time/weather).
Accept player input (commands like "go north", "take sword", "talk to NPC").
Parse command, update game state, handle events.
Repeat until win/lose condition.

## Command System

Parser: In GameLogic, use string splitting/LINQ to parse inputs (e.g., verbs like "go", "take", "use", "examine", "talk").
Supported Commands (Extensible list):

Movement: go [direction], north, south, east, west, northwest, northeast, southwest and southeast etc.
Interaction: take [item], drop [item], use [item] on [object], examine [object].
NPC: talk to [npc], give [item] to [npc], ask [npc] about [topic].
Inventory: inventory, equip [item].
World: time, weather, wait [time].
Meta: save, load, help, quit.

Error Handling: Friendly messages for invalid inputs.

## Player and Entities

Player Model: Inherits from Character. Attributes: Name, Health, Skills (e.g., Strength, Intelligence), Inventory.
NPC Model: Name, Dialogue tree (loaded from config), Quests, Inventory for trading.
Item Model: Name, Description, Type (e.g., weapon, consumable), Effects (e.g., heal on use).
Location Model: Name, Description (dynamic based on time/weather), Exits (dictionary of directions to Locations), Items/NPCs present, Events (e.g., random encounters).
Character Model: Base for Player/NPC: Position (current Location), Stats.

## Inventory System

Managed in Inventory namespace.
Player has a backpack with weight/size limits.
Items can be stacked (e.g., herbs).
Trading with NPCs.

## Environmental Systems

Time System: Earth-normal clock (24-hour day). Use DateTime simulation in GameLogic. Advances on actions or "wait" command.
Day/Night Cycle: Affects visibility (e.g., need torch at night), NPC availability, encounters (e.g., nocturnal creatures).
Seasons: Cycle every [X in-game days]. Affects availability (e.g., harvest in autumn, snow in winter blocking paths).
Weather Patterns: Random or patterned (e.g., rainy seasons). Types: Sunny, Rainy, Stormy, Foggy. Impacts: Slippery roads (movement risk), crop growth, events.

## Progression and Challenges

Puzzles: Text-based riddles, item combinations (e.g., use key on door).

Combat: Optional simple turn-based (e.g., vs. creatures on roads). Use stats for outcomes.

Skills/Leveling: Light RPG: Gain XP from quests, improve skills.

Win/Lose: Collect all shards to win; death from hazards/health loss to lose.

## Technical Architecture

### Code Structure

Program.cs: Main entry point. Initializes game, runs loop: Display -> Input -> Process.

## GameLogic

GameEngine.cs: Manages state, time/weather simulation, event triggers.
CommandParser.cs: Parses inputs, maps to actions.

Models: Data classes as described.
Inventory: InventoryManager.cs for handling additions/removals.
Scenes: SceneLoader.cs to load locations from config (e.g., JSON files for descriptions/exits).
Configuration: Use JSON/XML files for all descriptions, dialogues, etc., to avoid hard-coding. Load at startup.

## Data Loading

Locations, Items, NPCs: Defined in data files (e.g., locations.json with graph for connections).
Dynamic Descriptions: Use templates with placeholders (e.g., "{location} is {weather-adjective} today.").

## Extensibility

Modular: Add new Locations by extending models and data files.
Events: Use delegates/events for weather changes, time ticks.

## Development Roadmap

### Milestones

Prototype: Basic movement between Clearing and 1 village.
Core Mechanics: Add commands, inventory, NPCs.
Dynamics: Implement time/weather/seasons.
Content Fill: Populate all 8 villages, quests.
Polish: Saving/loading, error-proofing, help system.

## Tools and Best Practices

Version Control: Git.
Testing: Unit tests for parser, models.
Collaboration: This doc as starting point; fill blanks collaboratively.

## Appendices

### Open Blanks to Fill

Village details (names, themes, quests).
Specific item/NPC examples.
Detailed plot branches.
Custom commands or mechanics.

## Inspirations and References

Zork, Adventure, Runescape, etc.
Zork: Command parsing, puzzles.
Adventure: Exploration, treasures.
Runescape: Dynamic world, skills.
