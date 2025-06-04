

using System;
using System.Collections.Generic;

namespace Text_based
{
    public static class GenerateNPC
    {
        private static readonly Random rand = new Random();

        private static readonly List<string> Names = new List<string>
    {
        "Vera", "Unit-7", "Juno", "Fragment", "Delta Echo", "Archivist"
    };

        private static readonly List<string> Messages = new List<string>
    {
        "The Core Controller watches from below.",
        "You think this was an accident? He made it happen.",
        "No one escapes the Core Controller’s reach.",
        "He whispered to the core... then it screamed.",
        "The explosion was just the beginning. He’s still here.",
        "We warned them. They didn’t listen. He did this."
    };

        public static NPC Generate()
        {
            string name = Names[rand.Next(Names.Count)];
            string dialogue = Messages[rand.Next(Messages.Count)];
            return new NPC(name, dialogue);
        }
    }
}
