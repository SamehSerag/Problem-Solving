using System;
using System.Text;

namespace _15__Set_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCases; i++)
            {
                string k = Console.ReadLine();
                StringBuilder kBinary = new StringBuilder("");
                int kNum = int.Parse(k);
                long maxNumberWithSetBits = 0;

                while(kNum != 0)
                {
                    if(kNum % 2 == 0)
                        kBinary.Insert(0,"0");
                    else
                        kBinary.Insert(0,"1");
                    kNum/=2;
                }
                kNum = int.Parse(k);
                for (int j = 0; j < kBinary?.Length; j++)
                {
                    if (maxNumberWithSetBits + Math.Pow(2, j) <= kNum)
                        maxNumberWithSetBits += (long)Math.Pow(2, j);
                    else
                        break;
                }
                Console.WriteLine(maxNumberWithSetBits);
            }

        }
    }
}