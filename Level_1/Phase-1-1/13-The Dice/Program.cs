using System;
using System.Linq;

namespace _13_The_Dice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var dice = Array.ConvertAll(Console.ReadLine().ToCharArray(), Convert.ToInt32);
            //var dice = Array.ConvertAll(Console.ReadLine().Split(""), Convert.ToInt32);

            var dice = Console.ReadLine().Select(x => x - '0').ToArray();

            Console.WriteLine(CountGirls(dice));
            
        }

        public static int CountGirls(int[] dice)
        {
            int girles = 0;

            if (dice.Any(x => x > 6) || dice[dice.Length - 1] == 6)
            {
                return -1;
            }
            for (int i = 0; i < dice?.Length; i++)
            {
                if (dice[i] != 6)
                    girles++;
            }
            return girles;
        }
    }
}