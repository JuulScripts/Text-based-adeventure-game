using System;
using System.Collections.Generic;

namespace Text_based
{
    public class Room
    {
        public NPC npc;
        public bool hasItem;
        private string roomText;

        private static readonly List<string> RoomDescriptions = new List<string>
        {
            "The walls hum softly. Something’s still alive here.",
            "Flickering lights cast long, twitchy shadows.",
            "A puddle of coolant leads toward the back wall…",
            "It smells like burnt circuits and panic.",
            "You feel watched. But there’s no one here.",
            "The silence is so loud it makes your head hurt."
        };

        public Room()
        {
            npc = GenerateNPC.Generate();
            hasItem = new Random().Next(1, 2) == 1;
            roomText = RoomDescriptions[new Random().Next(RoomDescriptions.Count)];
        }

        public void ShowRoomText()
        {
            ConsoleHelper.typetext("You entered a room...");
            ConsoleHelper.typetext(roomText);
        }

        public void LookForItem()
        {
            ConsoleHelper.typetext("You look around...");
            if (hasItem)
            {
                ConsoleHelper.typetext("You found something.");
                ItemGenerator.GenerateRandomItem();
            }
            else
            {
                ConsoleHelper.typetext("Nothing but dust and broken panels.");
            }
        }

    }
}