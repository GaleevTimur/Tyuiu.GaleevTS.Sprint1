using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tuyiu.GaleevTS.Sprint1.Task1.V5.Lib;

namespace Tuyiu.GaleevTS.Sprint1.Task1.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3.0;
            double y = 3.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(8, res);
        }
    }
}
