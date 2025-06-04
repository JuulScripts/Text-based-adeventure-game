using System;
using System.Collections.Generic;

namespace Text_based
{
    public static class ItemGenerator
    {
        private static readonly List<string> ItemNames = new List<string>
    {
        "Core Key", "Memory Chip", "Stabilizer Cell"
    };

        private static readonly List<string> HelperFirstNames = new List<string>
    {
        "Wrench", "Data Slug", "Power Shard", "Duct Node", "Coolant Crystal", "Signal Plate"
    };

        private static readonly List<string> HelperLastNames = new List<string>
    {
        "MK-I", "of Sector 9", "Alpha-X", "v2.1", "Prototype", "Salvaged"
    };

        private static readonly Random rand = new Random();

        public static void GenerateRandomItem()
        {
            int mainRoll = rand.Next(1, 5); 
            if (mainRoll == 1)
            {
                string name = ItemNames[rand.Next(ItemNames.Count)];
                Item.AddItemToInventory(new Item(name, 0, false, true));
            }
            else
            {
            
                string name = HelperFirstNames[rand.Next(HelperFirstNames.Count)] + " " + HelperLastNames[rand.Next(HelperLastNames.Count)];
                Item.AddItemToInventory(new Item(name, 0, rand.Next(1, 5) == 1, false));

            }
        }

    }
}
