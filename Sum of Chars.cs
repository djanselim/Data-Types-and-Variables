using System;

namespace _04._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int total = 0;

            for(int i = 1; i <= n; i++)
            {
                char currentChar = char.Parse(Console.ReadLine());
                total += (int)currentChar;
            }
            Console.WriteLine($"The sum equals: {total}");
        }
    }
}
