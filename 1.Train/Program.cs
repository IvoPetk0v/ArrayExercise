using System;

namespace _1.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int sumOfArray = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                sumOfArray += array[i];
            }
            Console.WriteLine(String.Join(" ", array));
            Console.WriteLine(sumOfArray);
        }
    }
}
