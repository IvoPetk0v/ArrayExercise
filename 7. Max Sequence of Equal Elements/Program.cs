using System;
using System.Linq;

namespace _7._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int maxSequence = 0, maxValue = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int counterSequence = 0;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        counterSequence++;
                        if (counterSequence > maxSequence)
                        {
                            maxValue = array[j];
                            maxSequence = counterSequence;
                        }
                    }
                    else
                    {
                        counterSequence = 0;
                        break;
                    }
                }
            }
            for (int maxValueNumber = 0; maxValueNumber <= maxSequence; maxValueNumber++)
            {
                Console.Write($"{maxValue} ");
            }
        }
    }
}
