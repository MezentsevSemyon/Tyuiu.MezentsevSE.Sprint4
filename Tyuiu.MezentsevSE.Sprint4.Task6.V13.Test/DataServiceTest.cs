using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MezentsevSE.Sprint4.Task6.V13.Lib;

namespace Tyuiu.MezentsevSE.Sprint4.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] c = { "Ford", "Toyota", "Honda", "Chevrolet", "Mercedes", "BMW", "Audi" };
            Assert.AreEqual(4, ds.Calculate(c));
        }
    }
}
