

class Character
{
    public string name;
    public int health;
    public int strength;

    public static void players()
    {
        Character player1 = new Character();
        player1.name = "skibidigyattrizz";
        player1.health = 100;
        player1.strength = 100;
        Console.WriteLine("Player 1 name: " + player1.name);


        Character player2 = new Character();
        player2.name = "rizz the sigma";
        player2.health = 150;
        player2.strength = 200;
        Console.WriteLine("player 2 name: " + player2.name);
    }
}