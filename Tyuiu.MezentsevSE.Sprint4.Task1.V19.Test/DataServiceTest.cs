using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MezentsevSE.Sprint4.Task1.V19.Lib;
namespace Tyuiu.MezentsevSE.Sprint4.Task1.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] Array = { 6, 6, 9, 6, 9, 3, 8, 2, 9, 5, 7, 4 };
            int res = ds.Calculate(Array);
            int wait = 32;
            Assert.AreEqual(wait, res);
        }
    }
}
