using System;
using System.Linq;

namespace _6._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int elementIndex = 0;
            bool noElementFound = true;
            for (int i = 0; i < array.Length; i++)
            {
                int leftSum = 0, rightSum = 0;

                for (int j = i + 1; j < array.Length; j++)
                {
                    rightSum += array[j];
                }
                for (int k = i - 1; k >= 0; k--)
                {
                    leftSum += array[k];
                }
                if (leftSum == rightSum)
                {
                    noElementFound = false;
                    elementIndex = i;
                }
            }
            if (noElementFound)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine(elementIndex);
            }
        }
    }
}
