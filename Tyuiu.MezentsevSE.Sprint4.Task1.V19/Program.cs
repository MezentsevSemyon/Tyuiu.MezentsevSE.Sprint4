using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MezentsevSE.Sprint4.Task1.V19.Lib;

namespace Tyuiu.MezentsevSE.Sprint4.Task1.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Мезенцев С.Е. | ИИПБ-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Мезенцвев С.Е. | ИИПБ-23-2                                    *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив  заполненный значениями с клавиатуры*");
            Console.WriteLine("*,подсчитать сумму четных элементов массива.                              *");
            

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите количество элементов массива: ");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[len];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Введите значение: " + i + " элемента массива: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Введённый массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(array));
            Console.ReadKey();
        }
    }
}
