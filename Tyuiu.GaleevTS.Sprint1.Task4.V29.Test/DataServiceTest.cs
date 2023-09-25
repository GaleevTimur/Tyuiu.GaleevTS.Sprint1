using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GaleevTS.Sprint1.Task4.V29.Lib;

namespace Tyuiu.GaleevTS.Sprint1.Task4.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 4;
            double y = 1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.167, res);

        }
    }
}
