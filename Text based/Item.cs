using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Text_based
{
    internal class Item
    {

        string Name { get; set; }
        int Value { get; set; }
        bool IsDangerous {  get; set; }


        public Item(string name, int value, bool isDangerous)
        {
            Name = name;
            Value = value;
            IsDangerous = isDangerous;
        }

        public static void AddItemToInventory(Item item)
        {
            Player.Inventory.Add(item);
        }

    }
}
