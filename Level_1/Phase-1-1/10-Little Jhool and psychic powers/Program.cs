using System;

namespace _10_Little_Jhool_and_psychic_powers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(BadOrGoodLife(Console.ReadLine()));
        }

        static string BadOrGoodLife(string input)
        {
            var arrInput = input.ToCharArray();
            const int windowLength = 6;
            const int zeroAscii = 48;
            int sequenceSum = 0;

            if(arrInput?.Length < 6)
                return "Good luck!";

            for (int i = 0; i < windowLength; i++)
                sequenceSum += arrInput[i] - zeroAscii; // getting int from char

            if (sequenceSum == 0 || sequenceSum == 6)
                return "Sorry, sorry!";            

            for (int i = windowLength; i < arrInput?.Length; i++)
            {
                
                sequenceSum += arrInput[i] - arrInput[i - windowLength];
                if ((sequenceSum == 0 || sequenceSum == 6))
                    return "Sorry, sorry!";

            }

            return "Good luck!";
        }

    }
}