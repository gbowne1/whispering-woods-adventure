using System.Collections.Generic;
using TextAdventureGame.Items;
using TextAdventureGame.Character;

namespace TextAdventureGame.Characters
{
    public class NonPlayerCharacter : Character
    {
        public string Quest { get; set; }
        public bool HasQuest { get; set; }
        public List<string> DialogueLines { get; set; }

        public NonPlayerCharacter(string name, string dialogue, string quest = null)
            : base(name, dialogue)
        {
            Name = name;
            DialogueLines = new List<string> { dialogue };
            Quest = quest;
            HasQuest = !string.IsNullOrEmpty(Quest);
        }

        public void GiveQuest(string questDescription)
        {
            Quest = questDescription;
            HasQuest = true;
        }

        public override void Speak()
        {
            var randomIndex = new Random().Next(DialogueLines.Count);
            Console.WriteLine(DialogueLines[randomIndex]);
        }
    }
}
