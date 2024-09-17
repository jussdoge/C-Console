

class If
{
    public static void Numbers(int number)
    {
        //Console.WriteLine("What is your number");
        if(number > 0)
        {
            Console.WriteLine("Your number is positive");
        }
        else if (number <0)
        {
            Console.WriteLine("Your number is negative");
        }
        else
        {
            Console.WriteLine("Your number is zero");
        }
    }
    public static void health(int playerHealth)
    {
        //Console.WriteLine("What is your current health? ");

        if(playerHealth > 75)
        {
            Console.WriteLine("You are in perfect condition!");
        }
        else if (50 < playerHealth && playerHealth <= 75)
        {
            Console.WriteLine("You are in good condition!");
        }
        else if(1 < playerHealth && playerHealth <= 50)
        {
            Console.WriteLine("You are in critical danger!");
        }
        else
        {
            Console.WriteLine("Game Over");
        }
    }
}