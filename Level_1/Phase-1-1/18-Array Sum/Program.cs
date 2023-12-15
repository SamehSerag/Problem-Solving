using System;

namespace _18_Array_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            long[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
            long sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum+= arr[i];
            }
            Console.WriteLine(sum);
        }
    }
}