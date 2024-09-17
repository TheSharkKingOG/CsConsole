

class Input
{
    public static void SayWhat()
    {
        Console.WriteLine("What is your name ? ");
       string result = Console.ReadLine();
        Console.WriteLine("Hello, " + result + "!Nice to meet you! ");
    }
}