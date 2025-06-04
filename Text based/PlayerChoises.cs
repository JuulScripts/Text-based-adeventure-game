

using System;

namespace Text_based
{
    public static class PlayerChoises
    {
        private static void MakeBaseChoise(Room room)
        {
            if (!Player.finishedgame) { 
           Console.Clear();
            Console.WriteLine("\n─────────────────────────────────────────────");
            ConsoleHelper.typetext(" What's it gonna be?");
            Console.WriteLine("─────────────────────────────────────────────");
            ConsoleHelper.typetext(" 1. Enter new room");
            ConsoleHelper.typetext(" 2. Look for object");
            ConsoleHelper.typetext(" 3. Talk to the NPC");
            ConsoleHelper.typetext(" 4. See how many items you have found");
                Console.WriteLine("─────────────────────────────────────────────");
            Console.Write(" >> ");

            string line = Console.ReadLine();

                if (int.TryParse(line, out int num))
                {
                    switch (num)
                    {
                        case 1:
                            room = new Room();
                            room.ShowRoomText();
                            Console.Clear();
                            MakeBaseChoise(room);

                            break;

                        case 2:
                            room.LookForItem();
                            ConsoleHelper.wait(1.5);
                            MakeBaseChoise(room);

                            break;

                        case 3:
                            room.npc.Speak();
                            ConsoleHelper.wait(4);
                            MakeBaseChoise(room);

                            break;

                        case 4:
                            ConsoleHelper.typetext($"You have found: {Player.ending} out of 3 items");
                            ConsoleHelper.wait(2);
                            MakeBaseChoise(room);

                            break;
                        default:
                            ConsoleHelper.typetext("Invalid choice.");

                            break;
                    }
                }
            }
            else
            {
                ConsoleHelper.typetext("Please enter a number while in a room.");
            }
        }

        public static void EnterFirstRoom() {
         Room room = new Room();

      
            MakeBaseChoise(room);
            room.ShowRoomText();
        }

    }
}
