namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string>videoGameName=new List<string>() { "Final fantasy","Resident Evil","Call Of Duty","Tekken","Zelda","Street Fighter","Super Mario","Sonic"};
            videoGameName.Add("Gears Of War");
            videoGameName.Add("Mass Effect");
            var orderdGame = videoGameName.OrderBy(name => name.Length);
            foreach (var game in orderdGame)
            {
                Console.WriteLine(game);
            }
        }
    }
}
