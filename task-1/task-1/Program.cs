using System;
using System.Collections;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList numbers = new ArrayList();
            string input;
            int oddNumsSum = 0;
            int oddNumsCount = 0;
            bool checkNegativeNum = false;

            do
            {
                input = Console.ReadLine();
                if (input == "0") break;
                numbers.Add(Convert.ToInt32(input));
            } while (true);

            foreach (int number in numbers)
            {
                if (number % 2 == 1)
                {
                    oddNumsSum += number;
                    oddNumsCount++;
                }
                if (number < 0)
                {
                    checkNegativeNum = true;
                }
            }

            Console.WriteLine("Количество введенных чисел: "+ numbers.Count);
            Console.WriteLine("Cреднее арифметическое среди введенных нечетных чисел: " + ((double) oddNumsSum / oddNumsCount));

            if (checkNegativeNum)
            {
                Console.WriteLine("Присутствую отрицательные числа");
            }
        }
    }
}