using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.YushkovaES.Sprint3.Task2.V15.Lib
{
    public class DataService : ISprint3Task2V15
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sum = 0;
            int k = startValue;

            do
            {
                double term = (Math.Pow(value, k) + 0.5) * Math.Cos(k);
                sum += term;
                k++;
            }
            while (k <= stopValue);

            return Math.Round(sum, 3);

        }
    }
}
