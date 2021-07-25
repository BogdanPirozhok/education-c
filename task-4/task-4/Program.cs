using System;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 6;
            int middleLength = length / 2;
            int[] range = new int[] { 1, 20 };
            int[] array = new int[length];

            Random R = new Random();

            for (int i = 0; i < middleLength; i++)
            {
                array[i] = R.Next(range[0], range[1]);
                array[i + middleLength] = array[i];
            }

            Console.WriteLine($"Результирующий массив: [{String.Join(", ", array)}]");
        }
    }
}
