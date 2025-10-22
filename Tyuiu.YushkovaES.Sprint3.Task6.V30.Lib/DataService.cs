using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.YushkovaES.Sprint3.Task6.V30.Lib
{
    public class DataService : ISprint3Task6V30
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int totalCount = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                int countDivisors = 0;

                // Находим все делители числа x и считаем их количество
                for (int i = 1; i <= x; i++)
                {
                    if (x % i == 0)
                    {
                        countDivisors++;
                    }
                }

                totalCount += countDivisors;
            }

            return totalCount;
        }
    }
}
