using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Text_based
{
    internal class Player
    {
        public static List<Item> Inventory = new List<Item>();
        public string Name { get; }
        private int ending { get; set; }
        public Player(string name)
        {
            Name = name;
        }


        public void End()
        {
            switch (ending)
            {
                case 1:
                    Console.WriteLine("You chose the heroic ending!");
                    break;

                case 2:
                    Console.WriteLine("You chose the neutral ending.");
                    break;

                case 3:
                    Console.WriteLine("You chose the villainous ending...");
                    break;

                default:
                    Console.WriteLine("Unknown ending.");
                    break;
            }
        }
        } 
    }
