using System;

class Task8
{
    static void Main()
    {
        Console.WriteLine("Insert a size: ");
        int n = int.Parse(Console.ReadLine());

        ushort[] nums = new ushort[n];

        int count = 0;
        int tempcount = 0;
        int temptime = 0;
        int time = 0;
        Console.WriteLine("Insert an array: ");
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = ushort.Parse(Console.ReadLine());
        }

        for (int i = 0; i < nums.Length-1; i++)
        {
            tempcount = 0;
            temptime = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i]==nums[j])
                { 
                    temptime++;
                    tempcount = nums[i];
                }
            }
            if (temptime > time)
            {
                count = tempcount;
                time = temptime;
            }
        }
        Console.WriteLine("The number " + count + " is the most frequent " + time);

    }
}
