using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KulakovEE.Sprint5.Task1.V1.Lib
{
    public class DataService : ISprint5Task1V1
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExist = fileinfo.Exists;
            if (fileExist)
            {
                File.Delete(path);
            }
            double y;
            string strY;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Sin(x) != -2)
                {
                    y = Math.Round(((5 * x + 2.5) / (Math.Sin(x) + 2)) + 2 * x + 2, 2);
                    strY = Convert.ToString(y);
                }
                else
                {
                    strY = "0";
                }

                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }
            return path;
        }
    }
}