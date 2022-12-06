using System;

class Task6
{
    static void Main()
    {
        Console.WriteLine("Insert a size: ");
        int n = int.Parse(Console.ReadLine());

        int[] nums = new int[n];

        int start = 0;
        int len = 1;
        int theLongest = 0;
        Console.WriteLine("Insert an array: ");
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < nums.Length-1; i++)
        {
            if (nums[i] == nums[i + 1])
            {
                len++;
            }
            else
            {
                len=1;
            }
            if (len>start)
            {
                start = len;
                theLongest = nums[i];
            }
        }
        Console.WriteLine("The sequence of equal number is: ");
        for (int i = 1; i <= start; i++)
        {
            Console.WriteLine(theLongest);
        }

    }
}


