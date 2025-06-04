using Text_based;

class Program
{
    static void Main()
    {
        Player.EndTrigger(); // no await because it needs to run during the rest
        ConsoleHelper.startscreen();
        PlayerChoises.EnterFirstRoom();
    }
}
