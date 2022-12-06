using System;

class Task10
{
    static void Main()
    {
        Console.WriteLine("Insert a size: ");

        int length = int.Parse(Console.ReadLine());
        int [] arr = new int[length];

        Console.WriteLine("Insert a diff: ");
        int k = int.Parse(Console.ReadLine());

        int pair = 0;

        Console.WriteLine("Insert an array: ");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i; j < arr.Length; j++)
            {
                if ((arr[i]-arr[j]==k) || (arr[j]-arr[i]==k))
                {
                    pair++;
                }
            }
        }
        Console.WriteLine("Your answer is: " + pair);
    }
}
