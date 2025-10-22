using Tyuiu.YushkovaES.Sprint3.Task7.V3.Lib;
namespace Tyuiu.YushkovaES.Sprint3.Task7.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            double[] res = ds.GetMassFunction(startValue, stopValue);

            // Проверяем размерность
            Assert.AreEqual(11, res.Length); // от -5 до 5 включительно = 11 значений

            // Проверяем что все значения округлены до 2 знаков
            for (int i = 0; i < res.Length; i++)
            {
                double value = res[i];
                double rounded = Math.Round(value, 2);
                Assert.AreEqual(rounded, value, 0.001);
            }

        }
    }

}
