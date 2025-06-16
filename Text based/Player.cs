using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Text_based
{
    public class Player
    {
        public static List<Item> Inventory = new List<Item>();

        public static int ending { get; set; }

        public static bool finishedgame = false;
        public static async Task EndTrigger()
        {
          
            await Task.Delay(300000);
            finishedgame = true;
            ConsoleHelper.wait(0.2);
            Console.Clear();
              End();
        

        }
        
        public static void End()
        {
            Console.WriteLine("\n─────────────────────────────");

            switch (ending)
            {
                case 0:
                    ConsoleHelper.typeoverwritetext(">> YOU WERE NEVER MEANT TO SEE THIS.");
                    ConsoleHelper.typeoverwritetext(">> The Core Controller watches...");
                    ConsoleHelper.typeoverwritetext(">> Memory leak. Protocol overwritten.");
                    ConsoleHelper.typeoverwritetext(">> SYSTEM TERMINATED.");
                    Environment.Exit(0);

                    break;

                case 1:
                    ConsoleHelper.typeoverwritetext("You stopped the meltdown.");
                    ConsoleHelper.typeoverwritetext("You carried the last light from Urath's Core.");
                    ConsoleHelper.typeoverwritetext("You're a hero — but no one left to know it.");
                    Environment.Exit(0);
                    break;

                case 2:
                    ConsoleHelper.typeoverwritetext("Almost out...");
                    ConsoleHelper.typetext("You felt the cold air. You saw the door.");
                    ConsoleHelper.typeoverwritetext("But it never opened.");
                    ConsoleHelper.typeoverwritetext("You're still here.");
                    Environment.Exit(0);
                    break;

                case 3:
                    ConsoleHelper.typeoverwritetext("You did it.");
                    ConsoleHelper.typeoverwritetext("The Core is yours.");
                    ConsoleHelper.typeoverwritetext("Burn it all down. Let it scream.");
                    ConsoleHelper.typeoverwritetext("You win.");
                    Environment.Exit(0);
                    break;

                default:
                    ConsoleHelper.typeoverwritetext("Corrupted ending. You slipped between states.");
                    Environment.Exit(0);
                    break;
            }
        
        }
       
    }

    
}