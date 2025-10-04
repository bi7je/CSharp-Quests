namespace Quest_01;

public static class UserInterface
{
    public static void DisplayMessage(string message)
    {
        Console.WriteLine(message);
    }

    public static void DisplayBoxedMessage(string message)
    {
        DisplayMessage(DisplayLine("-"));
        DisplayMessage(message);
        DisplayMessage(DisplayLine("-"));
    }

    public static string DisplayLine(string type = "=")
    {
        string line = String.Empty;
        for (int i = 0; i < 15; i++)
        {
            line += type;
        }

        return line;
    }

    public static void DrawMenu()
    {
        DisplayBoxedMessage("You awaken in a torch-lit hall deep beneath the mountain of C#.\n" +
                       "Three enormous Dungeon Doors rise before you, each carved from a different material.\n" +
                       "Their surfaces shimmer with faint runes that seem to pulse when you focus on them.");
        DisplayMessage("");
    }
}