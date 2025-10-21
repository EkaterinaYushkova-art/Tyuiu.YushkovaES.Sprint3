using Tyuiu.YushkovaES.Sprint3.Task2.V15.Lib;
namespace Tyuiu.YushkovaES.Sprint3.Task2.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Екатерина Е.С | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #3                                                              *");
            Console.WriteLine("* Тема: Оператор цикла while                                             *");
            Console.WriteLine("* Задание #2                                                             *");
            Console.WriteLine("* Вариант #15                                                            *");
            Console.WriteLine("* Выполнила: Екатерина Е.С | ИСПб-25-1                                   *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу используя цикл do...while                           *");
            Console.WriteLine("* которая вычисляет сумму ряда по формуле при a = 0.5                    *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            double value = 0.5;
            int startValue = 1;
            int stopValue = 20;
            Console.WriteLine("Переменная X" + value);
            Console.WriteLine("Старт шага" + startValue);
            Console.WriteLine("Конец шага" + stopValue);



            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            double result = ds.GetSumSeries(value, startValue, stopValue);
            Console.WriteLine("Сумма ряда: " + result);




            Console.ReadKey();
        }
    }
}
