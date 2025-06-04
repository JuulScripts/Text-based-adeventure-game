using System;
using System.Threading;
using Text_based;

public static class ConsoleHelper
{
    private static int typingDelay = 25; 
    private static int asciiDelay = 1;
    public static void wait(double seconds)
    {
        Thread.Sleep((int)(seconds * 1000));
    }

    public static void typetext(string text)
    {
        foreach (char c in text)
        {
            if (!Player.finishedgame)
            {
                Console.Write(c);
                Thread.Sleep(typingDelay);
            } else { Console.WriteLine();

                return;
            }

        }
        Console.WriteLine();
    }
    public static void typeoverwritetext(string text)
    {

        Console.WriteLine();
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(typingDelay);
        }
     
    }
    public static string readtext(string text)
    {
        typetext(text);
        return Console.ReadLine() ?? "";
    }

    public static void PrintAsciiArt(string art, bool colored = false)
    {


        if (colored)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Random rnd = new Random();
            foreach (char c in art)
            {
                if (rnd.NextDouble() < 0.1)
                    Console.ForegroundColor = ConsoleColor.Yellow;
                else
                    Console.ForegroundColor = ConsoleColor.Red;

                Console.Write(c);
                System.Threading.Thread.Sleep(asciiDelay);
            }

            Console.ResetColor();
            Console.WriteLine();
        }
        else
        {
            foreach (char c in art)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(asciiDelay);
            }
            Console.WriteLine();
        }
    }
public static void startscreen()
    {
        Console.Clear();

        PrintAsciiArt(@"
 ____ ___                __  .__                                         
|    |   \____________ _/  |_|  |__   ______   ____  ___________   ____  
|    |   /\_  __ \__  \\   __\  |  \ /  ___/ _/ ___\/  _ \_  __ \_/ __ \ 
|    |  /  |  | \// __ \|  | |   Y  \\___ \  \  \__(  <_> )  | \/\  ___/ 
|______/   |__|  (____  /__| |___|  /____  >  \___  >____/|__|    \___  >
                      \/          \/     \/       \/                  \/               
    ", true);

        wait(1.2);
        Console.WriteLine(); 

        typetext("You wake to the sound of metal creaking... and nothing else.");
        wait(0.8);
        typetext("Flickering lights reveal a broken terminal. Your hands are shaking.");
        wait(1.0);
        typetext("You don't remember how you got here.");
        wait(0.6);
        typetext("Or who you are.");
        wait(1.2);
        typetext("");
        typetext("A synthetic voice buzzes to life in the walls:");
        wait(1.0);
        typetext("\"Evacuation Protocol: Urath-Core breach. You have five minutes.");
        typetext("Locate Core Key. Memory Chip. Stabilizer Cell.\"");
        wait(1.2);
        typetext("\"Failure to comply will result in permanent containment.\"");
     
        Console.WriteLine();
        typetext("You get dragged to a random room......... you hear a voice you recognize it is that the core holder?");
        wait(1);
        Console.Clear();
    }


}
