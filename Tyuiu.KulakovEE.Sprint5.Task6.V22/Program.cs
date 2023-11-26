using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.KulakovEE.Sprint5.Task6.V22.Lib;

namespace Tyuiu.KulakovEE.Sprint5.Task6.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5| Выполнил :  Кулаков Е.Е | АСОиУб-23-1";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* Спринт #5                                                  *");
            Console.WriteLine("* Тема:  Обработка текстовых файлов                          *");
            Console.WriteLine("* Задание #6                                                 *");
            Console.WriteLine("* Вариант #22                                                *");
            Console.WriteLine("* Выполнил :  Кулаков Егор Евгеньевич | АСОиУб-23-1          *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                   *");
            Console.WriteLine("* Создать папку в ручную С:DataSprint5                       *");
            Console.WriteLine("* в котором есть набор символьных данных.                    *");
            Console.WriteLine("* Найти количество удвоенных букв мм в заданной строке.      *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                           *");
            Console.WriteLine("**************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask6V22.txt";

            Console.WriteLine("File path: " + path);
            Console.WriteLine("data is: ");
            Console.WriteLine(File.ReadAllText(path));

            Console.WriteLine("**************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                 *");
            Console.WriteLine("**************************************************************");

            Console.WriteLine("мм count: ");
            Console.WriteLine(ds.LoadFromDataFile(path));




            Console.ReadKey();
        }
    }
}