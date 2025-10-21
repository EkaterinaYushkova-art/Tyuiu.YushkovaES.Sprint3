using Tyuiu.YushkovaES.Sprint3.Task5.V26.Lib;
namespace Tyuiu.YushkovaES.Sprint3.Task5.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Екатерина Е.С | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #3                                                              *");
            Console.WriteLine("* Тема: Вложенные циклы                                                  *");
            Console.WriteLine("* Задание #5                                                             *");
            Console.WriteLine("* Вариант #26                                                            *");
            Console.WriteLine("* Выполнила: Екатерина Е.С | ИСПб-25-1                                   *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Вычислите с помощью вложенных циклов выражение при x = 2               *");
            Console.WriteLine("*   3   13                                                               *");
            Console.WriteLine("*   ∑   ∑  (x^k + sin(k))                                                *");
            Console.WriteLine("*  i=1 k=1                                                               *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");


            int x = 2;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 3;

            Console.WriteLine("Исходные данные:");
            Console.WriteLine("X = " + x);
            Console.WriteLine("Старт внешнего цикла: " + startValue1);
            Console.WriteLine("Конец внешнего цикла: " + stopValue1);
            Console.WriteLine("Старт внутреннего цикла: " + startValue2);
            Console.WriteLine("Конец внутреннего цикла: " + stopValue2);




            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            Console.WriteLine("Сумма = " + result);



            Console.ReadKey();
        }
    }
}



