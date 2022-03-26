using System;
using System.Linq;

namespace _9._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int LenghtOfSequences = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int[] bestArray = new int[LenghtOfSequences];
            int bestSequences = 0, bestIndexStart = LenghtOfSequences,
                bestCounter1s = 0, arrayNumBest = 1, arrayNumber = 0;
            bool isSame = false;
            while (input != "Clone them!")
            {
                int[] array = input
                     .Split("!", StringSplitOptions.RemoveEmptyEntries)
                     .Select(int.Parse)
                     .ToArray();
                int sumOfOnes = 0;
                int currentSequences = 0, currentIndexStarting = LenghtOfSequences;
                arrayNumber++;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] == 1)
                    {
                        sumOfOnes++;
                    }
                }
                for (int i = 0; i < array.Length; i++)
                {

                    if (array[i] == 1)
                    {
                        currentSequences++;
                        //if (currentSequences == 2)
                        {
                            currentIndexStarting = i; //- 1;
                        }
                    }
                    else
                    {
                        currentSequences = 0;
                    }
                    if (currentSequences > bestSequences)
                    {
                        bestSequences = currentSequences;
                        bestIndexStart = currentIndexStarting;
                        arrayNumBest = arrayNumber;
                        bestArray = array;
                        bestCounter1s = sumOfOnes;
                    }
                    else if (currentSequences == bestSequences && bestIndexStart > currentIndexStarting)
                    {
                        bestSequences = currentSequences;
                        bestIndexStart = currentIndexStarting;
                        arrayNumBest = arrayNumber;
                        bestArray = array;
                        bestCounter1s = sumOfOnes;
                    }
                    if (currentSequences == bestSequences && bestIndexStart == currentIndexStarting && arrayNumBest != 0)
                    {
                        isSame = true;
                        if (sumOfOnes > bestCounter1s)
                        {
                            bestSequences = currentSequences;
                            bestIndexStart = currentIndexStarting;
                            arrayNumBest = arrayNumber;
                            bestArray = array;
                            bestCounter1s = sumOfOnes;
                        }

                    }
                }
                input = Console.ReadLine();
            }
            if (isSame)
            {
                Console.WriteLine($"Best DNA sample {arrayNumBest} with sum: {bestCounter1s}.");
                Console.WriteLine(String.Join(" ", bestArray));
            }
            else
            {
                Console.WriteLine($"Best DNA sample {arrayNumBest} with sum: {bestSequences}.");
                Console.WriteLine(String.Join(" ", bestArray));
            }
        }
    }
}
