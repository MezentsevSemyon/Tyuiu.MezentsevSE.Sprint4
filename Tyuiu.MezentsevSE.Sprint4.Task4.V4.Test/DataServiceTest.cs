﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MezentsevSE.Sprint4.Task4.V4.Lib;
namespace Tyuiu.MezentsevSE.Sprint4.Task4.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mass = new int[5, 5] { { 5, 9, 6, 8, 5 },
                                         { 6, 6, 7, 3, 8 },
                                         { 4, 3, 9, 8, 7 },
                                         { 3, 3, 6, 7, 7 },
                                         { 8, 3, 8, 6, 6 } };
            int[,] res = ds.Calculate(mass);
            int[,] wait = new int[5, 5] { { 5, 9, 1, 1, 5 },
                                         { 1, 1, 7, 3, 1 },
                                         { 1, 3, 9, 1, 7 },
                                         { 3, 3, 1, 7, 7 },
                                         { 1, 3, 1, 1, 1 } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
