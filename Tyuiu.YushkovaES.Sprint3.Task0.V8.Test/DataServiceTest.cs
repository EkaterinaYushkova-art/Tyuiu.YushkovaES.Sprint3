using Tyuiu.YushkovaES.Sprint3.Task0.V8.Lib;
namespace Tyuiu.YushkovaES.Sprint3.Task0.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            double value = 0.25;
            int startValue = 1;
            int stopValue = 10;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = -6.101;
            Assert.AreEqual(wait, res);
        }
    }
}
