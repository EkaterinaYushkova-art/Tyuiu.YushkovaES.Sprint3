﻿using Tyuiu.YushkovaES.Sprint3.Task4.V28.Lib;
namespace Tyuiu.YushkovaES.Sprint3.Task4.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);
            double wait = 1.924;
            Assert.AreEqual(wait, res);

        }
    }
}
