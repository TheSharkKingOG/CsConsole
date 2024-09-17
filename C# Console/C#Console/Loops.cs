

class Loops
{
    public static void Forloop()
    {
        for(int i = 1; i <= 10; i++ )
        {
            Console.WriteLine("Iteration:" + i );
        }
    }
    public static void Myloop()
    {
        for(int i = 1; i <= 20; i++ )
        {
             if(i % 2 == 1)
            {
                Console.WriteLine(i);
            }
        }
    }
    public static void Whileloop()
    {
       int gold = 0;
       while(gold <= 100)
       {
            Console.WriteLine("I got more Gold!: " + gold);
            gold += 10;
       
       } 
    }
    public static void NestedLoops()
    {
        for(int i = 1; i <= 10; i++ )
        {
            Console.WriteLine("Iteration:" + i );
            for(int j = 0; j <= 10; j++ )
            {
                Console.WriteLine("Iteration j: " + j);
                 for(int k = 0; k <= 10; k++ )
            {
                Console.WriteLine("               Iteration k: " + k);
            }
            }
        }
    }




}












