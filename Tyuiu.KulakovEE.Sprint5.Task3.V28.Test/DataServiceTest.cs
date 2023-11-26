using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KulakovEE.Sprint5.Task3.V28.Lib;
using System.IO;

namespace Tyuiu.KulakovEE.Sprint5.Task3.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Аболтус\source\repos\Tyuiu.KulakovEE.Sprint5\Tyuiu.KulakovEE.Sprint5.Task3.V28\bin\Debug\OutPutFileTask3.bin";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}