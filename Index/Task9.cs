using System;

class Task9
{
    static void Main()
    {
        string alph = Console.ReadLine();

        for (int i = 0; i != alph.Length; i++)
        {
            Console.WriteLine((int)alph[i] - 97); 
        }
    }
}
