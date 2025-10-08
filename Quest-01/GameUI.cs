namespace Quest_01;

using System.Threading;

public class GameUI
{
    public void DrawInto(int delay = 25)
    {
        string intro = "You find yourself in a dark room. Before you are three doors.\n" +
                          "One will lead to freedom, the others will lead to certain death.\n" +
                          "You look closely at the door.\n" +
                          "One door is made of wood, one is made of iron and the last one is made of obsidion.\n";
        
        DrawWithDelay(intro, 'c');
    }

    private void DrawWithDelay(string text, char type = 'c')
    {
        int delay = 25;
        foreach (char character in text)
        {
            if (Console.KeyAvailable) delay = 0;
            Console.Write(character);
            Thread.Sleep(delay);
        }

        if (Console.KeyAvailable)
            Console.ReadKey(true);
    }

    public void DrawMenu()
    {
        DrawLine();
        string menu = "Which door will you choose?:\n" +
                          "1 - The wooden door\n" +
                          "2 - The iron door\n" +
                          "3 - The obsidian door";
        DrawWithDelay(menu);
    }

    public string GetInput(string message)
    {
        string? input = String.Empty;
        bool valid = false;
        while (!valid)
        {
            Console.Write(message);
            input = Console.ReadLine()?.Trim() ?? String.Empty;
            if (input != String.Empty)
            {
                valid = true;
            }
            else
            {
                Console.WriteLine("You did not enter anything. Try again.");
            }
        }
        
        return input;
    }

    public void DrawLine()
    {
        Console.WriteLine("-----------------------------------------------------------------------------------");
    }
}