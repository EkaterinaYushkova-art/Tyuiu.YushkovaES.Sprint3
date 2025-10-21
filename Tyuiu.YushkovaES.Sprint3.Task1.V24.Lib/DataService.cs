using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.YushkovaES.Sprint3.Task1.V24.Lib
{
    public class DataService : ISprint3Task1V24
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sum = 0;
            int i = startValue;

            while (i <= stopValue)
            {
                double denominator = 6 + Math.Pow(value, i);
                double term = Math.Pow(2 / denominator, i);
                sum += term;
                i++;
            }

            return Math.Round(sum, 3);

        }
    }
}
