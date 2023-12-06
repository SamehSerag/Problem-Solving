using System;

namespace _03_Fitting_Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int testCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCases; i++)
            {
                var splitedInput = Console.ReadLine().Split(' ');
                int length = int.Parse(splitedInput[0]);
                int width = int.Parse(splitedInput[1]);

                Console.WriteLine((length/width) == 0 ? width/length : (length / width));
            }
           


        }
    }
}