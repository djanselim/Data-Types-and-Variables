using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int capacityLeft = 255;
            int litersCollected = 0;

            for(int i = 1; i <= n; i++)
            {
                int currentLiters = int.Parse(Console.ReadLine());
                
                if((capacityLeft - currentLiters) < 0)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    capacityLeft -= currentLiters;
                    litersCollected += currentLiters;
                    
                }
            }
            Console.WriteLine(litersCollected);
        }
    }
}
