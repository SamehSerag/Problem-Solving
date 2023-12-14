using System;
using System.Linq;

namespace _16_The_Great_Kian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            long[] series = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);

            long sum;
            int i;
            for (i = 0; i < 3; i++)
            {
                sum = 0;
                for (int j = i; j < series.Length; j+=3)
                {
                    sum += series[j];
                }
                
                Console.Write($"{sum} ");
            }

            //long sum;
            //int i;
            //for (i = 0; i < size && i < 3; i++)
            //{
            //    sum = 0;
            //    sum+= series[i];
            //    if (i + 3 < size)
            //        sum += series[i + 3];
            //    if(i + 6 < size)
            //        sum += series[i + 6];

            //    Console.Write($"{sum} ");
            //}
            //while(i < 3)
            //{
            //    Console.Write("0 ");
            //    i++;

            //}
        }
    }
}