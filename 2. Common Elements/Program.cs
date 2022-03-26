using System;
using System.Linq;

namespace _2._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] array = Console.ReadLine().Split(" ");

            string[] arraySecond = Console.ReadLine().Split(" ");
            string output = string.Empty;
            for (int i = 0; i < arraySecond.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (arraySecond[i] == array[j])
                    {
                        output += arraySecond[i] + " ";
                    }
                }
            }
            Console.WriteLine(output);

        }
    }
}
