using System;
using System.Linq;

namespace _11_Binary_associativity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());
            string[] a = new string[]
            {
                "0 1 1 0", "0 1 1 1", "0 0 0 1", "1 1 1 1", "0 0 1 1", "0 0 0 0", "0 1 0 1", "1 0 0 1"
            };

            for (int i = 0; i < testCases; i++)
            {
                string input =Console.ReadLine();

                if (a.Any(x => x == input))
                    Console.WriteLine("Yes");
                else Console.WriteLine("No");

            }
        }
    }
}