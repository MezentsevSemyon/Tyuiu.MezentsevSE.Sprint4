using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MezentsevSE.Sprint4.Task2.V12.Lib;
namespace Tyuiu.MezentsevSE.Sprint4.Task2.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Мезенцев С.Е. | ИИПБ-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Мезенцвев С.Е. | ИИПБ-23-2                                    *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив  заполненный случайными числами     *");
            Console.WriteLine("*,подсчитать сумму нечетных элементов массива.                            *");


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            Console.Write("Введите длину массива: ");
            int len = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[len];

            for (int i = 0; i < len; i++)
            {
                array[i] = rnd.Next(4, 10);
            }

            Console.WriteLine();

            Console.Write("Массив: {");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i != array.Length - 1) { Console.Write(", "); }
            }
            Console.WriteLine("}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(array);

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
