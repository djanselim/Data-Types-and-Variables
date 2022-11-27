using System;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int days = 0;
            int collected = 0;
            while(yield >= 100)
            {
                int resources = yield;
                collected += resources - 26;
                yield -= 10;
                days++;
            }
            if(collected >= 26)
            {
                collected -= 26;
            }
            Console.WriteLine(days);
            Console.WriteLine(collected);
        }
    }
}
