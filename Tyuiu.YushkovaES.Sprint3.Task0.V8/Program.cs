using Tyuiu.YushkovaES.Sprint3.Task0.V8.Lib;
namespace Tyuiu.YushkovaES.Sprint2.Task0.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Екатерина Е.С | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #3                                                              *");
            Console.WriteLine("* Тема: Оператор цикла for                                               *");
            Console.WriteLine("* Задание #0                                                             *");
            Console.WriteLine("* Вариант #8                                                             *");
            Console.WriteLine("* Выполнила: Екатерина Е.С | ИСПб-25-1                                   *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу используя цикл for,                                 *");
            Console.WriteLine("* которая вычисляет произведение ряда по формуле, при a = 0,25           *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            double value = 0.25;
            int startValue = 1;
            int stopValue = 10;
            Console.WriteLine("Переменная X" + value);
            Console.WriteLine("Старт шага" + startValue);
            Console.WriteLine("Конец шага" + stopValue);



            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("Сумма рада =" + ds.GetMultiplySeries(value, startValue, stopValue));



            Console.ReadKey();
        }
    }
}
