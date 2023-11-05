using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MezentsevSE.Sprint4.Task2.V12.Lib;
namespace Tyuiu.MezentsevSE.Sprint4.Task2.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds =  new DataService();
            int[] nums = { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            int res = ds.Calculate(nums);
            int wait = 70;
            Assert.AreEqual(wait, res);
        }
    }
}
