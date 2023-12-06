using System;

namespace _08_Distribute_Chocolates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
                var splitedInput = Console.ReadLine().Split(' ');
                long chocolates = long.Parse(splitedInput[0]);
                int studentsNumber = int.Parse(splitedInput[1]);

                long totalDistributedChocolates = ((long)studentsNumber * (studentsNumber + 1)) / 2;

                if(totalDistributedChocolates > chocolates)
                {
                    Console.WriteLine(chocolates);
                    continue;
                }

                long remain = (chocolates - totalDistributedChocolates) % studentsNumber;
                Console.WriteLine(remain);

               
            }
        }
    }
}