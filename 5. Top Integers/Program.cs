using System;
using System.Linq;

namespace _5._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = Console.ReadLine()
                  .Split(" ")
                  .Select(int.Parse)
                  .ToArray();

            int[] arrayOfGreater = new int[array.Length];
            int indexCounter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int currentNum = array[i];
                bool isGreater = true;
                for (int j = i + 1; j < array.Length; j++)
                {
                    int nextNumber = array[j];

                    if (currentNum <= nextNumber)
                    {
                        isGreater = false;
                        break;
                    }
                }
                if (isGreater)
                {
                    arrayOfGreater[indexCounter] = array[i];
                    indexCounter++;
                }
            }
            for (int i = 0; i < indexCounter; i++)
            {
                Console.Write($"{arrayOfGreater[i]} ");
            }
        }
    }
}
