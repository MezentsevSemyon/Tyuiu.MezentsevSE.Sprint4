using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MezentsevSE.Sprint4.Task5.V29.Lib;
namespace Tyuiu.MezentsevSE.Sprint4.Task5.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] { { -1, 2, 3, -4, 5 },
                                          { 6, 7, 8, 9, -1 },
                                          { -2, 3, 4, -5, 6 },
                                          { 7, -8, 9, -9, 1 },
                                          { -2, 3, 4, 5, -6} };
            int res = ds.Calculate(matrix);
            int wait = 16;

            Assert.AreEqual(wait, res);
        }
    }
}
