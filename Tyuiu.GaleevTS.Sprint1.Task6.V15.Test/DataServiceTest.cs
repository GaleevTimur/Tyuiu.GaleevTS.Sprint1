using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GaleevTS.Sprint1.Task6.V15.Lib;

namespace Tyuiu.GaleevTS.Sprint1.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            string strtest = "ABCDE!?><";
            DataService ds = new DataService();
            bool res = ds.CheckLettersCount(strtest);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
