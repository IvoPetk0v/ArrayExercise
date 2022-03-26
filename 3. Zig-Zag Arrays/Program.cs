using System;
using System.Linq;

namespace _3._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrayFirst = new int[n];
            int[] arraySecond = new int[n];
            for (int rowOfNum = 1; rowOfNum <= n; rowOfNum++)
            {

                int[] arrayOfInput = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

                if (rowOfNum % 2 == 0)
                {
                    arraySecond[rowOfNum - 1] = arrayOfInput[0];
                    arrayFirst[rowOfNum - 1] = arrayOfInput[1];
                }
                else
                {
                    arraySecond[rowOfNum - 1] = arrayOfInput[1];
                    arrayFirst[rowOfNum - 1] = arrayOfInput[0];
                }

            }
            Console.WriteLine(String.Join(" ", arrayFirst));
            Console.WriteLine(String.Join(" ", arraySecond));

        }
    }
}
