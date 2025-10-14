using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.YushkovaES.Sprint3.Task0.V8.Lib
{
    public class DataService : ISprint3Task0V8
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double s = 0;
            int i;
            for (i = startValue; i < stopValue; i++)
            {
                s = s + (Math.Pow(value, i) + 1) * (Math.Cos(4));
            }
            return Math.Round(s, 3);

        }
    }
}
