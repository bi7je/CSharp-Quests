namespace Quest_01
{
    class Program
    {
        static void Main(string[] args)
        {
            GameUI gameUI = new GameUI();
            gameUI.DrawInto();
            gameUI.DrawMenu();
            string input = gameUI.GetInput("Which door do you choose?\n1, 2 or 3: ");

            if (int.TryParse(input, out int choice) && choice > 0 && choice < 4)
            {
                Console.WriteLine(choice);
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}