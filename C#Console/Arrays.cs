

class Arrays
{

    public static void Array1(String[] args)
    {
        int[] numbers = new int[5];
        numbers[0] = 1;
        numbers[1] = 2;

        Console.WriteLine(numbers[1]);

        string[] names = { "skibidi", "gyatt", "rizz"};
        Console.WriteLine(names[1]); 

        int[] grades = new int[5];

        grades[0] = 85;
        grades[1] = 90;
        grades[2] = 78;
        grades[3] = 92;
        grades[4] = 88;

        Console.WriteLine("Grades ");
        for(int i = 0; i < grades.Length; i++)
        {
            Console.WriteLine(grades[i]);
        }
    }
}