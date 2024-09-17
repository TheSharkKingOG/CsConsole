

class Character
{
    public string name;
    public int health;
    public int strength;

    public static void Player()
    {
        Character player = new Character();
        player.name = "Chris";
        player.health = 100;
        player.strength = 100;

        Console.WriteLine(player.name);

        Character player1 = new Character();
        player.name = "Tom";
        player.health = 100;
        player.strength = 100;
        Console.WriteLine(player1.name);
    }
    
}