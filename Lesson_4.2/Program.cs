using System;
using static System.Console;

namespace Lesson_4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int MinValue = int.MaxValue;

            WriteLine("Введите длинну последовательности");
            int Length = int.Parse(ReadLine());

            int[] arr = new int[Length];

            for (int i = 0; i < Length; i++)
            {
                WriteLine($"Введите {i + 1}-й элемент последовательности");
                arr[i] = int.Parse(ReadLine());
            }
            for (int i = 0; i < Length; i++)
            {
                if (arr[i] < MinValue)            
                {
                    MinValue = arr[i];
                }
            }
            WriteLine($"Наименьшее число: {MinValue}");
            ReadKey();
        }
    }
}
