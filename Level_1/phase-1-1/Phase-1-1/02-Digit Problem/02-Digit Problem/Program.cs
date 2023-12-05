using System;
using System.Text;

namespace _02_Digit_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder X = new StringBuilder (input.Split(' ')[0]);
            short K = short.Parse(input.Split(' ')[1]);

            short changes = 0;
            for (int i = 0; i < X?.Length && changes < K ; i++)
            {
                if(X[i] != '9')
                {
                    X[i] = '9';
                    changes++;
                }

            }

            Console.WriteLine(X);
        }
    }
}