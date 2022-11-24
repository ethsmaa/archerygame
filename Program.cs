

using System;

class Player
{
    public int x;
    public int y;
    public int health;
    public String? arrowSet;
    public String? name;


    public override string ToString()
    {
        return String.Format("{4}:  ({0}, {1}) {3} Health: {2}", x, y, health, arrowSet, name);
    }

}

class Program
{

    static int[] healths = { 60, 80, 100 };
    static String[] arrowSets = { "Set 1", "Set 2", "Set 3" };

    static void Main(string[] args)
    {
        gameInit();
        Console.ReadKey();
    }

    static Player generateRandomPlayer(String name)
    {
        Player player = new Player();
        Random random = new Random();

        player.name = name;
        player.x = random.Next(-10, 11);
        player.y = random.Next(-10, 11);


        int randomIndex = random.Next(0, healths.Length);
        player.health = healths[randomIndex];
        healths = healths.Where(item => item != player.health).ToArray();

        randomIndex = random.Next(0, arrowSets.Length);
        player.arrowSet = arrowSets[randomIndex];
        arrowSets = arrowSets.Where(item => !item.Equals(player.arrowSet)).ToArray();


        return player;
    }

    static void gameInit()
    {
        // Get location from user
        Player realPlayer = new Player();
        realPlayer.name = "A";
        Console.WriteLine("Enter the location of A: ");
        Console.Write("X: ");
        realPlayer.x = int.Parse(Console.ReadLine());

        Console.Write("Y: ");
        realPlayer.y = int.Parse(Console.ReadLine());

        Random random = new Random();

        // set random health
        int randomIndex = random.Next(0, healths.Length);
        realPlayer.health = healths[randomIndex];
        // remove selected health value
        healths = healths.Where(item => item != realPlayer.health).ToArray();


        // set random arrow set
        randomIndex = random.Next(0, arrowSets.Length);
        realPlayer.arrowSet = arrowSets[randomIndex];
        arrowSets = arrowSets.Where(item => !item.Equals(realPlayer.arrowSet)).ToArray();



        // bots
        Player playerB = generateRandomPlayer("B");
        Player playerC = generateRandomPlayer("C");

        Console.WriteLine();
        Console.WriteLine(realPlayer);
        Console.WriteLine(playerB);
        Console.WriteLine(playerC);


    }

}







