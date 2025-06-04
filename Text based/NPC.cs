

using System;

namespace Text_based
{
    public class NPC
    {
        public string Name { get; }
        public string Dialogue { get; }

        public NPC(string name, string dialogue)
        {
            Name = name;
            Dialogue = dialogue;
        }

        public void Speak()
        {
            ConsoleHelper.typetext($"{Name} says: \"{Dialogue}\"");
            if (new Random().Next(0, 3) == 2)
            {
                ConsoleHelper.typetext($"{Name} gave you something special.....");
                ItemGenerator.GenerateRandomItem();
            }
        }
    }
}
