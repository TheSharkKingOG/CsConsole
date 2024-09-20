

class Lists
{
    public static void List1(String[] args)
    {
        List<String> fruit = new List<string> { "Apple", "Banana", "Orange",};

        Console.WriteLine(fruit.Count);

        foreach(string fruits in fruit)
        {
            Console.WriteLine(fruits);
        }
    }
}