using System;

namespace _06._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                char thirdLetter = (char)('c' + i);
                for(int j = 1; j <= n; j++)
                {
                    char secondLetter = (char)('b' + j);
                    for(int k = 1; i <= n; k++)
                    {
                        char firstLetter = (char)('a' + k);
                        Console.WriteLine($"{firstLetter}{secondLetter}{thirdLetter}");
                    }
                }
            }
        }
    }
}
