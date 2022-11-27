using System;

namespace _02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            long totalSum = 0;

            while(num > 0)
            {
                totalSum += num % 10;
                num /= 10;
            }
            Console.WriteLine(totalSum);

        }
    }
}
