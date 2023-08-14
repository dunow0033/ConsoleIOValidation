// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

namespace ConsoleIOValidation
{
    class Program
    {
        private readonly static List<string> games = new List<string>();

        private static void Main(string[] args)
        {

        }

        private static void AddGames()
        {
            Program.games.Add("The Wither 3 - Wild Hunt");
            Program.games.Add("Baba is you");
            Program.games.Add("Factorio");
            Program.games.Add("Cities Skylines");
            Program.games.Add("Kerbal space program");
        }

        private static void PrintGameSelection()
        {
            for(int i = 0; i < Program.games.Count; i++)
            {
                Console.WriteLine("[" + i + "]: " + Program.games[i]);
            }
        }

        private static int GetSelectedGame()
        {
            int chosenIndex;
            string choice;

            do
            {
                Console.Write("Please select a game by it's index number (between 0 and " + (Program.games.Count - 1) + "): ");
                choice = Console.ReadLine();
            } while (!(Int32.TryParse(choice, out chosenIndex) && chosenIndex >= 0 && chosenIndex < Program.games.Count));

            return chosenIndex;
        }

        private static void PrintGame(string gameName)
        {
            Console.WriteLine();
            Console.WriteLine("So you have chosen \"" + gameName + "\". GLHF :)");
        }
    }
}