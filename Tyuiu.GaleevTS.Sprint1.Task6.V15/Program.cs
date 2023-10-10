﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GaleevTS.Sprint1.Task6.V15.Lib;

namespace Tyuiu.GaleevTS.Sprint1.Task6.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт №1 | Выполнил: Галеев Т. С. | ИИПб-23-3" ;
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                         *");
            Console.WriteLine("* Задания #Spint Review                                                    *");
            Console.WriteLine("* Вариант #9                                                               *");
            Console.WriteLine("* Выполнил: Галеев Тимур Серикович | ИИПб-23-3                             *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по        *");
            Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                    *");
            Console.WriteLine("*                           y^2 + cos(x) + 12*x*y - 3*x^2                  *");
            Console.WriteLine("*  Формула - Z = e^x -  -----------------------------------                *");
            Console.WriteLine("*                           cos(x^3 + 3) + 18y - 1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Введите строку: ");
            string value = Console.ReadLine();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine(ds.CheckLettersCount(value));
            Console.ReadKey();
        }
    }
}
