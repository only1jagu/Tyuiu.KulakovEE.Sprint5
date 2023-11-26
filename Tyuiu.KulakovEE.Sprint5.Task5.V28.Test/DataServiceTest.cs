using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KulakovEE.Sprint5.Task5.V28.Lib;

namespace Tyuiu.KulakovEE.Sprint5.Task5.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\Users\Аболтус\source\repos\Tyuiu.KulakovEE.Sprint5\Tyuiu.KulakovEE.Sprint5.Task5.V28\bin\Debug\InPutDataFileTask5V28.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            Assert.AreEqual(true, fileExists);
        }
    }
}