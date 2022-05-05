using System;

namespace ITMO.FirstCourseProject.FirstCSApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 1 до 10 включительно");
            int num = int.Parse(Console.ReadLine());
            int i;

            if (num >= 1 && num <= 10)
            {
                i = num;
                while (i > 0)
                {
                    Console.WriteLine(i + " Hello world!");
                    i--;
                }
            }
            else
            {
                Console.WriteLine("Введенное число должно быть больше 0 и меньше 11");
            }
        }
    }
}
