using System;
using System.Linq;

namespace _12_HAWKEYE_AND_FLOODFILL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            var input = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);         
            (int targetI, int targetJ, int power) = (input[0], input[1], input[2]);

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    int val = power - Math.Max(Math.Abs(i - targetI), Math.Abs(j - targetJ));
                    if(val < 0)
                        Console.Write("0 ");
                    else
                        Console.Write($"{val} ");
                }
                Console.WriteLine();
            }



        }
    }
}