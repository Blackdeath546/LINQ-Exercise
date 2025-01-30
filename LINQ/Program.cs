namespace LINQ
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var gamesList = new List<string>(){"DbD", "Marvel Rivals", "Apex Legends", "Sons of the Forest", "Darkest Dungeon 2", "Valheim", "Pal World", "Balder's Gate 3", "Liar's Bar"};

            var inOrderGameList = gamesList.OrderBy(x => x.Length).ToList();

            foreach (var game in inOrderGameList)
            {
                Console.WriteLine(game);
            }
        }
    }
}
