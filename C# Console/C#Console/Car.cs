

class Cars
{
    public string model;
    public int speed;


    public static void Drive(string model, int speed)
    {
        Console.WriteLine("The" + model + " is driving at " + speed + "mph");
    }
}