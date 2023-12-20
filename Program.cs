using System;

class davaleba4_2_1
{
    static void Main()
    {
        int[] first = { 10, 20, 30 };

        int[] second = new int[first.Length];

        for (int i = 0; i < first.Length; i++)
        {
            second[i] = first[i];
        }

        Console.WriteLine("Second massive:");
        foreach (int number in second)
        {
            Console.WriteLine(number);
        }
    }
}
