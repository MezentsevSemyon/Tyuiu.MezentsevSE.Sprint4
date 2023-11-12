using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MezentsevSE.Sprint4.Task7.V29.Lib;
namespace Tyuiu.MezentsevSE.Sprint4.Task7.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService DataService = new DataService();
            Console.Title = "Спринт 4. Выполнил: Мезенцев С.Е. | ИИПб-23-2";
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* Спринт #4                                                     ");
            Console.WriteLine("* Тема: Двумерные массивы                                       ");
            Console.WriteLine("* Задание #7                                                    ");
            Console.WriteLine("* Вариант #29                                                   ");
            Console.WriteLine("* Выполнил: Мезенцев Семён Евгеньевич | ИИПб-23-2               ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      ");
            Console.WriteLine("Дана строка из одноразрядных цифр 983157642891. Преобразуйте    ");
            Console.WriteLine("* ее в матрицу 4 на 3 и подсчитайте сумму четных чисел.         *");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                            *\n");
            int[,] array = new int[4, 3];
            string value = "983157642891";
            Console.WriteLine("Матрица 4 на 3:\n");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = int.Parse(value[i * 3 + j].ToString());
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************\n");
            int res = DataService.Calculate(4, 3, value);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
