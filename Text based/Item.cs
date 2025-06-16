using Microsoft.Win32;
using System;

namespace Text_based
{
    public class Item
    {

        public  string Name { get; set; }
    
        public bool IsDangerous {  get; set; }
        public bool ending { get; set; } 

            public Item(string name, int value, bool isDangerous, bool isEnding)
            {
                Name = name;
         
                IsDangerous = isDangerous;
                ending = isEnding;
            }

        public static void AddItemToInventory(Item item)
        {
            Player.Inventory.Add(item);
            ConsoleHelper.typetext($"YOU FOUND: {item.Name}");
            if (item.ending)
            {
                if (Player.ending < 2)
                {
                    Player.ending++;
                } else
                {
                    Player.ending++;
                    Player.finishedgame = true;
                    Player.End();
                }
                   
               
            } else if (item.IsDangerous) {
                ConsoleHelper.typetext(
                $"YOU PICKED UP SOMETHING DANGEROUS!! The lights flicker once… then fade. Urath’s Core hums no more. You were too late.Whatever secrets remained, they’re buried now — with you. {item.Name}");
                ConsoleHelper.PrintAsciiArt(@"       
        .-''''-.
      .'        '.
     /            \
    |              |
    |,  .-.  .-.  ,|
    | )(_o/  \o_)( |
    |/     /\     \|
    (_     ^^     _)
     \__|IIIIII|__/
      | \IIIIII/ |
      \          /
       `--------`
              ");

                Environment.Exit(0);
            }
        }
    }
}
