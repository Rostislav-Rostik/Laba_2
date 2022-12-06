using System;
using System.Linq;
using System.Xml;

class Task2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an array: ");
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Console.WriteLine("Enter a count of rotation: ");
        int rotate = int.Parse(Console.ReadLine());
        int[] sumResult = new int[arr.Length];

        for (int i = 0; i < rotate; i++)
        {
            int lastElement = arr[arr.Length - 1];

            for (int j = arr.Length - 1; j > 0; j--)
            {
                arr[j] = arr[j - 1];
            }
            arr[0] = lastElement;

            for (int y = 0; y < arr.Length; y++)
            {
                sumResult[y] += arr[y];
            }
        }

        foreach (var item in sumResult)
        {
            Console.Write(" " + item);
        }
        
    }
}
