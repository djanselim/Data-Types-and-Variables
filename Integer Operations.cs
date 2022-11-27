using System;

namespace _01._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int fourthNum = int.Parse(Console.ReadLine());

            long addedResult = (long)firstNum + secondNum;
            long devidedResult = addedResult / thirdNum;
            long finalResult = devidedResult * fourthNum;
            Console.WriteLine(finalResult);

            
        }
    }
}
