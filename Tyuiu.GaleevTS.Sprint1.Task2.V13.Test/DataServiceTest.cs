using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GaleevTS.Sprint1.Task2.V13.Lib;

namespace Tyuiu.GaleevTS.Sprint1.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 2;
            var value = ds.ConvertMilesToKm(x);
            Assert.AreEqual(3.2, value);
        }
    }
}
