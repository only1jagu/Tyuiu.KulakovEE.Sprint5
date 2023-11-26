using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.IO;
using Tyuiu.KulakovEE.Sprint5.Task1.V1.Lib;

namespace Tyuiu.KulakovEE.Sprint5.Task1.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Кулаков Е.Е | АСОиУБ-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Запись набора данных в текстовый файл                             *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил:  Кулаков Е.Е | АСОиУБ-23-1                                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция, F(x) = ((5*x+2.5)/(Math.Sin(x)+2))+2*x+2 на заданном      *");
            Console.WriteLine("* диапазоне [-5;5] с шагом 1. Произвести проверку деления на ноль. При    *");
            Console.WriteLine("* делении на ноль вернуть значение 0. Результат сохранить в текстовый     *");
            Console.WriteLine("* файл OutPutFileTask1.txt и вывести на консоль. Округлить до двух знаков *");
            Console.WriteLine("* после запятой.                                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            string[] lines = File.ReadAllLines(res);
            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |    f(x)  |");
            Console.WriteLine("+----------+----------+");
            for (int i = 0; i <= lines.Length - 1; i++)
            {
                Console.WriteLine("|{0,5:d}     |  {1, 6:f2}  |", startValue, lines[i]);
                startValue++;
            }
            Console.WriteLine("+----------+----------+");
            Console.ReadKey();
        }
    }
}