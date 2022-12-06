using System;
class Task5
{
    static void Main()
    {
        string first = Console.ReadLine();
        string second = Console.ReadLine();

        if (first.Length >= second.Length)
        {
            for (int i = 0; i != second.Length; i++)
            {
                if (first[i] > second[i])
                {
                    Console.WriteLine(second);
                    Console.WriteLine(first);
                    break;
                }
                else
                {
                    break;
                }

            }

        }
        if (first.Length <= second.Length)
        {
            for (int i = 0; i != first.Length; i++)
            {
                if (first[i] < second[i])
                {
                    Console.WriteLine(first);
                    Console.WriteLine(second);
                    break;
                }
                else
                {
                    break;
                }
            }
        }
        if (first.Length == second.Length)
        {
            for (int i = 0; i != first.Length; i++)
            {
                if (first[i] == second[i])
                {
                    Console.WriteLine(first);
                    Console.WriteLine(second);
                    break;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
