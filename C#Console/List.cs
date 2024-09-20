using System.Collections.Generic;

class Lists
{

    public static void List1(String[] args)
    {
        List<string> fruits = new List<string>();
        fruits.Add("Apple");
        fruits.Add("Banana");
        fruits.Add("Orange");
        fruits.Add("Grapes");
        fruits.Add("Mango");

        fruits.Remove("Banana");
        fruits.Insert(0, "Pineapple");

        Console.WriteLine(fruits.Count);

        foreach (String fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}