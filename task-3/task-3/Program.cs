using System;
using System.Linq;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 798;
            int[] intList = value.ToString().Select(digit => int.Parse(digit.ToString())).ToArray();

            if (intList[0] > intList[1])
            {
                Console.WriteLine("Цифра сотни больше цифры десятка");
            }

            if (intList[0] > intList[2])
            {
                Console.WriteLine("Цифра сотни больше цифры еденицы");
            }

            if (intList[1] > intList[0])
            {
                Console.WriteLine("Цифра десятка больше цифры сотни");
            }

            if (intList[1] > intList[2])
            {
                Console.WriteLine("Цифра десятка больше цифры еденицы");
            }

            if (intList[2] > intList[0])
            {
                Console.WriteLine("Цифра еденицы больше цифры сотни");
            }

            if (intList[2] > intList[1])
            {
                Console.WriteLine("Цифра еденицы больше цифры десятка");
            }
        }
    }
}