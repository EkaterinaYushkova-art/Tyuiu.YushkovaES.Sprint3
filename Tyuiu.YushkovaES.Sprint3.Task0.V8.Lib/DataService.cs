using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.YushkovaES.Sprint3.Task0.V8.Lib
{
    public class DataService : ISprint3Task0V8
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double p = 1; // Для произведения начинаем с 1
            double cos4 = Math.Cos(4); // Вычисляем cos(4) один раз

            for (int i = startValue; i <= stopValue; i++)
            {
                p = p * (Math.Pow(value, i) + 1) * cos4;
            }

            return Math.Round(p, 3);


        }
    }
}
