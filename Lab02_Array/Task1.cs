using System;

internal class Task1
{
    static void Main()
    {
        Console.WriteLine("Enter the first words: ");
        string a = Console.ReadLine();
        Console.WriteLine("Enter the first words: ");
        string b = Console.ReadLine();
        int a1 = a.Length;
        int b1 = b.Length;

        int count = 0;
        int count1 = 0;
        if (a1 >= b1)
        {
            for (int i = 0; i != b1; i++)
            {
                if (a[i] == b[i])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            int a2 = a1;
            int b2 = b1;

            for (int i = 0; i != b1; i++)
            {
                if (a[a2 - 1] == b[b2 - 1])
                {
                    count1++;
                    a2--;
                    b2--;
                }
                else
                {
                    break;
                }
            }

            if (count >= count1)
            {
                for (int i = 0; i != count; i++)
                {
                    Console.Write(a[i]);
                }
            }
            else
            {
                for (int i = b1 - count1; i != b1; i++)
                {
                    Console.Write(b[i]);
                }
            }
        }
        else
        {
            for (int i = 0; i != a1; i++)
            {
                if (a[i] == b[i])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            int a2 = a1;
            int b2 = b1;

            for (int i = 0; i != a1; i++)
            {
                if (a[a2 - 1] == b[b2 - 1])
                {
                    count1++;
                    a2--;
                    b2--;
                }
                else
                {
                    break;
                }
            }

            if (count >= count1)
            {
                for (int i = 0; i != count; i++)
                {
                    Console.Write(a[i]);
                }
            }
            else
            {
                for (int i = a1 - count1; i != a1; i++)
                {
                    Console.Write(a[i]);
                }
            }
        }

    }
}
