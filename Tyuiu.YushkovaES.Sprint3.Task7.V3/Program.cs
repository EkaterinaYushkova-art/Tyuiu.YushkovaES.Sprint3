using Tyuiu.YushkovaES.Sprint3.Task7.V3.Lib;
namespace Tyuiu.YushkovaES.Sprint3.Task7.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Екатерина Е.С | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #3                                                              *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                *");
            Console.WriteLine("* Задание #7                                                             *");
            Console.WriteLine("* Вариант #30                                                            *");
            Console.WriteLine("* Выполнила: Екатерина Е.С | ИСПб-25-1                                   *");
            Console.WriteLine("**************************************************************************");
            
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Исходные данные:");
            Console.WriteLine("Старт диапазона: " + startValue);
            Console.WriteLine("Конец диапазона: " + stopValue);
            Console.WriteLine("Шаг: 1");






            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            double[] resultArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("+-------+--------+");
            Console.WriteLine("|   X   |  F(X)  |");
            Console.WriteLine("+-------+--------+");

            int index = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                Console.WriteLine($"| {x,5} | {resultArray[index],6} |");
                index++;
            }

            Console.WriteLine("+-------+--------+");


            Console.ReadKey();

        }
    }
}


