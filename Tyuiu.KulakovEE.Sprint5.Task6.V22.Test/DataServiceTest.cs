using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

using Tyuiu.KulakovEE.Sprint5.Task6.V22.Lib;

namespace Tyuiu.KulakovEE.Sprint5.Task6.V22.Test

{
    [TestClass]
    public class DataServiceTest
    {


        [TestMethod]
        public void FileExsistenceTest()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V22.txt";
            var res = ds.LoadFromDataFile(path);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CalculationTest()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V22.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
