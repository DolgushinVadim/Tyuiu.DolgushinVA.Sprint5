using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.DolgushinVA.Sprint5.Task5.V19.Lib;
namespace Tyuiu.DolgushinVA.Sprint5.Task5.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V19.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
