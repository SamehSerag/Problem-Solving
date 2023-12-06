using System;
namespace _05_Rain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
                var splitedInput = Console.ReadLine().Split(' ');
                int rangeStart = int.Parse(splitedInput[0]);
                int rangeEnd = int.Parse(splitedInput[1]);
                int soundsByClouds = int.Parse(splitedInput[2]);
                
                int minClouds = (int)Math.Ceiling(Convert.ToDouble(rangeStart) / soundsByClouds);
                int maxClouds = (int)Math.Floor(Convert.ToDouble(rangeEnd) / soundsByClouds);

                if(minClouds > maxClouds)
                {
                    minClouds = -1;
                    maxClouds = -1;
                }

                Console.WriteLine($"{minClouds} {maxClouds}");
            }
        }
    }
}