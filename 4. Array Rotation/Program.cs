using System;
using System.Linq;

namespace _4._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = Console.ReadLine()
                            .Split(" ")
                            .Select(int.Parse)
                            .ToArray();

            int numOfRotation = int.Parse(Console.ReadLine());
            for (int rotation = 0; rotation < numOfRotation; rotation++)
            {
                int firstIndex = array[0];
                int[] arrayRotated = new int[array.Length];
                for (int i = 0; i < arrayRotated.Length - 1; i++)
                {
                    arrayRotated[i] = array[i+1];
                }
                arrayRotated[arrayRotated.Length-1] = firstIndex;
                array = arrayRotated;
            }
            Console.WriteLine(String.Join(" ", array));
        }
    }
}
