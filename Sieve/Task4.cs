using System;

class Task4
{
    static void Main()
    {
        Console.WriteLine("Insert length: ");
        int n = int.Parse(Console.ReadLine());

        bool[] prime = new bool[n + 1];

        for (int i = 0; i <= n; i++)
        {
            prime[i] = true;
        }

        for (int i = 2; i * i <= n; i++)
        {
            if (prime[i] == true)
            {
                for (int j = i * i; j <= n; j += i)
                {
                    prime[j] = false;
                }
            }
        }
        Console.WriteLine("Our number is: ");
        for (int i = 2; i <= n; i++)
        {
            if (prime[i] == true)
            { 
                Console.WriteLine(i);
            }
        }

    }
}