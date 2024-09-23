

using System.IO.Pipes;
using System.Runtime.CompilerServices;

class Dictionary1
{
    public static void Dicti1(string[] args)
    {
        Dictionary<string, string> phonebook = new Dictionary<string, string>();
        phonebook.Add("Angel", "492 949 9495");
        phonebook.Add("Hector", "959 238 5434");

        Console.WriteLine(phonebook["Angel"]);
    }

    public static void Dict2(string[] args)
    {
        Dictionary<string, int> inventory = new Dictionary<string, int>();
        inventory.Add("apples", 50);

        foreach(KeyValuePair<string, int> item in inventory)
        {
            Console.WriteLine(item.Key + ". " + item.Value);
        }
    }
}