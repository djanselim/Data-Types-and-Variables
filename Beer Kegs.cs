using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double biggestVolume = 0;
            string biggestKeg = "";

            for(int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                float r = float.Parse(Console.ReadLine());
                int h = int.Parse(Console.ReadLine());
                double currentKegVolume = Math.PI * Math.Pow(r, 2) * h;

                if(currentKegVolume > biggestVolume)
                {
                    biggestVolume = currentKegVolume;
                    biggestKeg = model;
                }

            }
            Console.WriteLine(biggestKeg);
            
        }
    }
}
