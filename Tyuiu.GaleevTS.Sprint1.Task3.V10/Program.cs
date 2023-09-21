using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GaleevTS.Sprint1.Task3.V10.Lib;

namespace Tyuiu.GaleevTS.Sprint1.Task3.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт №1 | Выполнил: Галеев Т. С. | ИИПб-23-3";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                         *");
            Console.WriteLine("* Задания #3                                                               *");
            Console.WriteLine("* Вариант #10                                                               *");
            Console.WriteLine("* Выполнил: Галеев Тимур Серикович | ИИПб-23-3                             *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,  *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.              *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                          *");
            Console.WriteLine("****************************************************************************");

            double number;
            Console.WriteLine("Введите дробное число ->");
            number = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            double cop = Math.Round(number % 1 * 100);
            double rub = number - (number % 1);


            Console.WriteLine(number + " руб - это " + rub + " руб. " + cop +" коп.");

            Console.ReadLine();
        }
    }
}
