using System;

namespace ITMO.FirstCourseProject.ExamAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 24;
            int S = 0;
            int i;

            for (i = 1; i <= n; i++)
            {
                Console.WriteLine(i + " Введите число от 1 до 100");
                int T = int.Parse(Console.ReadLine());

                if(T >= 1 && T <= 100)
                {
                    S = S + T;
                }
                else
                {
                    Console.WriteLine("Введенное число должно быть в диапазоне чисел от 1 до 100");
                    i--;
                }
            }
            int Mid = S / (i - 1);
            Console.WriteLine(Mid);
        }
    }
}
