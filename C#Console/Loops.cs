

class Loops
{
    public static void ForLoops()
    {
        for(int i = 0; i < 101; i++)
        {
            Console.WriteLine("aura points: " + i);
        }
    }
    public static void EvenLoop()
    {
        for(int i = 1; i <= 20; i++)
        {
            if(i % 2 == 1)
            {
                Console.WriteLine(i);
            }
            
        }
    }
    public static void HealthLoops()
    {
        int Health = 100;
        while(Health >= 0)
        {
            Console.WriteLine("Current Health: " + Health);
            Health -= 10;
        }
    }
    public static void NestedLoops()
    {
        int x = 10;
for (int i = 0; i < 3; i++)
{
    x += i;
}
Console.WriteLine(x);
    }
    public static void dowhile()
    {
        int number;
        do
        {
            Console.WriteLine("Enter a number greater than 0");
            number = Convert.ToInt32(Console.ReadLine());
        }
        while (number <= 0);
        Console.WriteLine("You entered: " + number);
    }
}