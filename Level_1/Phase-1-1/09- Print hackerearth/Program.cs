using System;
using System.Linq;

namespace _09__Print_hackerearth
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();

            Console.WriteLine(getMaxHackerEarth(str));

        }

    
        public static int getMaxHackerEarth(string str)
        {
            const string hackerearth = "hackerearth";
            
            // h a e r >= 2 --- 4 
            int[] haer = new int[4];
            // c k t >= 1 --- 3
            int[] ckt = new int[3];

            if (str.Length < hackerearth.Length)
                return 0;

            for (int i = 0; i < str?.Length; i++)
            {
                switch (str[i])
                {
                    case 'h':
                        haer[0]++;
                        break;
                    case 'a':
                        haer[1]++;
                        break;
                    case 'c':
                        ckt[0]++;
                        break;
                    case 'k':
                        ckt[1]++;
                        break;
                    case 'e':
                        haer[2]++;
                        break;
                    case 'r':
                        haer[3]++;
                        break;
                    case 't':
                        ckt[2]++;
                        break;
                }
            }

            if (haer.Any(x => x < 2) || ckt.Any(x => x < 1))
                return 0;

            //haer[0] /= 2; haer[1] /= 2; haer[2] /= 2; haer[3] /= 2;
            //int minHaer = haer.Min(x => x);
            int minHaer = haer.Select(x => x /= 2).Min(x => x);

            if(ckt.All(x => x >= minHaer))
                return minHaer;
            else
                return ckt.Min(x => x);
              
        }
    }
}