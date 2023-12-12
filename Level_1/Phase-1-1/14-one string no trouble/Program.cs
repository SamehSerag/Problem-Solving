using System;

namespace _14_one_string_no_trouble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            Console.WriteLine(LongistGoodString(input));

        }

        static long LongistGoodString(string input)
        {
           
            int maxLength = 1;
            int length = 1;
           
            for (int i = 0; i < input.Length-1; i++)
            {
                if (input[i] != input[i + 1])
                    length++;
                else
                {
                    maxLength = Math.Max(maxLength, length);
                    length = 1;
                }
            }

            maxLength = Math.Max(maxLength, length);

            return maxLength;
        }
    }
}