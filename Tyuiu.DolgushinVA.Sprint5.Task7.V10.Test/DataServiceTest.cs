﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.DolgushinVA.Sprint5.Task7.V10.Lib;
namespace Tyuiu.DolgushinVA.Sprint5.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\vadim\source\repos\Tyuiu.DolgushinVA.Sprint5\Tyuiu.DolgushinVA.Sprint5.Task7.V10\bin\Debug\OutPutFileTask7.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
