

class If
{
    public static void IfElse(int number)
    {
        //int number = 5;

        if (number > 0)
        {
            Console.WriteLine("The number is positive.");
        }
        else if (number < 0)
        {
            Console.WriteLine("The number is negative.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }
    
    }

    public static void Health(int number)
    {
        if(number > 75)
        {
            Console.WriteLine("The player is in great condition!");
        }
        else if(number > 50)
        {
            Console.WriteLine("The player is in good condition.");
        }
        else if (number > 1)
        {
            Console.WriteLine("The player is in danger!");
        }
        else if (number > -1)
        {
            Console.WriteLine("Game Over.");
        }
        


    }
}