using System;
using System.Collections;

namespace task_2
{
    class Student
    {
        public string name;
        public int assessment;
        public int index;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int lengthStudents = 15;
            int[] range = new int[] { 1, 12 };

            object[] appraisals = new object[lengthStudents];


            int middleAssessment = 7;
            int sumAssessment = 0;
            int countMoreMiddleAssessment = 0;

            int maxAssessmentValue = 0;
            ArrayList maxAssessmentStudents = new ArrayList();

            bool checkNegativeAssessment = false;

            Random R = new Random();

            Console.WriteLine("Ученики:");

            for (int i = 0; i < appraisals.Length; i++)
            {
                Student newStudent = new Student {
                    name = "Ученик #"+ (i + 1),
                    assessment = R.Next(range[0], range[1]),
                    index = (i + 1)
                };

                sumAssessment += newStudent.assessment;

                if (newStudent.assessment >= middleAssessment)
                {
                    countMoreMiddleAssessment++;
                }

                if (newStudent.assessment > maxAssessmentValue)
                {
                    maxAssessmentValue = newStudent.assessment;
                }

                if (newStudent.assessment == 1)
                {
                    checkNegativeAssessment = true;
                }

                appraisals[i] = newStudent;

                Console.WriteLine("Имя: "+ newStudent.name +", Оценка: "+ newStudent.assessment);
            }

            foreach (Student item in appraisals)
            {
                if (item.assessment == maxAssessmentValue)
                {
                    maxAssessmentStudents.Add(item.index);
                }
            }

            Console.WriteLine("\n");
            Console.WriteLine("Cредний балл в группе: " + ((double)sumAssessment / lengthStudents));
            Console.WriteLine("Количество учеников, оценки которых выше среднего: " + countMoreMiddleAssessment);

            Console.WriteLine("\n");

            Console.WriteLine("Максимальный балл: " + maxAssessmentValue);
            Console.WriteLine("Номера учеников с максимальной оценкой: " + String.Join(", ", maxAssessmentStudents.ToArray()));

            Console.WriteLine("\n");

            if (checkNegativeAssessment)
            {
                Console.WriteLine("Среди оценок присутствуют единицы");
            }
        }
    }
}
