// See https://aka.ms/new-console-template for more information


namespace ConsoleIOValidation
{
    class Program
    {
        private readonly static List<string> games = new List<string>();

        private static void Main(string[] args)
        {
            AddGames();

            PrintGameSelection();

            int gameIndex = GetSelectedGame();

            string gameName = games[gameIndex];

            PrintGameChoice(gameName);

            Console.ReadKey();
        }

        private static void AddGames()
        {
            games.Add("The Wither 3 - Wild Hunt");
            games.Add("Baba is you");
            games.Add("Factorio");
            games.Add("Cities Skylines");
            games.Add("Kerbal space program");
        }

        private static void PrintGameSelection()
        {
            for(int i = 0; i < games.Count; i++)
            {
                Console.WriteLine("[" + i + "]: " + games[i]);
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

        private static void PrintGameChoice(string gameName)
        {
            Console.WriteLine();
            Console.WriteLine("So you have chosen \"" + gameName + "\". GLHF :)");
        }
    }
}