using Tyuiu.YushkovaES.Sprint3.Task5.V26.Lib;
namespace Tyuiu.YushkovaES.Sprint3.Task5.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int x = 2;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 3;

            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            double wait = 0.965;
            Assert.AreEqual(wait, res);

        }
    }
}
