using System;
using System.Collections.Generic;
using System.Linq;

namespace _07__City_Travel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var splitedInput = Console.ReadLine().Split(' ');
            int distance = int.Parse(splitedInput[0]);
            double mostDistancePerDay = int.Parse(splitedInput[1]);
            int exceptions = int.Parse(splitedInput[2]);


            //int daysLeft = (int)Math.Ceiling(Convert.ToDouble(distance / mostDistancePerDay));
            double distanceLeft = distance;
            int minDays = 0;
            Dictionary<int,int> dictionary = new Dictionary<int, int>();

             
            for (int i = 0; i < exceptions; i++)
            {
                var splitedException = Console.ReadLine().Split(' ');
                int exceptionDays = int.Parse(splitedException[0]);
                int exceptionDistance = int.Parse(splitedException[1]);

                dictionary.Add(exceptionDays, exceptionDistance);
                
            }

            var dictionary2 = dictionary.OrderBy(x => x.Key);
            int oldKey = 0;
            foreach (var kvp in dictionary2)
            {
                if(kvp.Key - oldKey - 1 > 0  && distanceLeft > 0)
                {
                    if (distanceLeft < (kvp.Key - oldKey - 1) * mostDistancePerDay)
                    {
                        minDays += (int)Math.Ceiling(Convert.ToDouble((double)distanceLeft / mostDistancePerDay));
                    }
                    else
                        minDays += (kvp.Key - oldKey - 1);

                    distanceLeft -= (kvp.Key - oldKey -1) * mostDistancePerDay;
                }               
               
                if(distanceLeft <= 0)
                    break;
             
                distanceLeft -= kvp.Value;
                minDays++;
                oldKey = kvp.Key;
            }
            if (distanceLeft > 0)
                minDays += (int)Math.Ceiling(Convert.ToDouble((double)distanceLeft / mostDistancePerDay));
            Console.WriteLine(minDays);

            ////int daysLeft = (int)Math.Ceiling(Convert.ToDouble(distance / mostDistancePerDay));
            //int distanceLeft = distance;
            //int minDays = 0;
            //for (int i = 0; i < exceptions && distanceLeft > 0; i++)
            //{
            //    var splitedException = Console.ReadLine().Split(' ');
            //    int exceptionDays = int.Parse(splitedException[0]);
            //    int exceptionDistance = int.Parse(splitedException[1]);

            //    int daysToBeAdded = exceptionDays;
            //    if (exceptionDays * exceptionDistance > distanceLeft)
            //    {
            //        daysToBeAdded = (int)Math.Ceiling(Convert.ToDouble((double)distanceLeft / exceptionDistance));

            //    }

            //    distanceLeft -= exceptionDistance * daysToBeAdded;
            //    minDays += daysToBeAdded;
            //}
            //if (distanceLeft > 0)
            //    minDays += (int)Math.Ceiling(Convert.ToDouble((double)distanceLeft / mostDistancePerDay));
            //Console.WriteLine(minDays);

            //for (int i = 0; i < exceptions && distanceLeft > 0; i++)
            //{
            //    var splitedException = Console.ReadLine().Split(' ');
            //    int exceptionDays = int.Parse(splitedException[0]);
            //    int exceptionDistance = int.Parse(splitedException[1]);

            //    int daysToBeAdded = exceptionDays;
            //    if (exceptionDays > daysLeft)
            //    {
            //        daysToBeAdded = (int)Math.Ceiling(Convert.ToDouble((double)distanceLeft / exceptionDistance));
            //        //distanceLeft -= exceptionDistance * daysToBeAdded;
            //        //minDays += daysToBeAdded;
            //        //daysLeft -= daysToBeAdded;
            //    }
            //    //else
            //    //{
            //    //    distanceLeft -= exceptionDistance * exceptionDays;
            //    //    minDays += exceptionDays;
            //    //    daysLeft -= exceptionDays;
            //    //}
            //    distanceLeft -= exceptionDistance * daysToBeAdded;
            //    minDays += daysToBeAdded;
            //    daysLeft -= daysToBeAdded;
            //}
            //Console.WriteLine(minDays);
        }
    }
}