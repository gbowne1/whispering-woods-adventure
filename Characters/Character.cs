using System.Collections.Generic;
using TextAdventureGame.Items;

namespace TextAdventureGame.Character
{
    public abstract class Character
    {
        protected string _name;
        protected string _dialogue;

        protected Character(string name, string dialogue)
        {
            _name = name;
            _dialogue = dialogue;
        }

        public virtual void Speak()
        {
            Console.WriteLine(_dialogue);
        }

        public string Name => _name;
        public string Dialogue => _dialogue;
    }
}
