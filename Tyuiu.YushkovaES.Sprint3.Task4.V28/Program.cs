using Tyuiu.YushkovaES.Sprint3.Task4.V28.Lib;
namespace Tyuiu.YushkovaES.Sprint3.Task4.V28
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
            Console.WriteLine("* Задание #4                                                             *");
            Console.WriteLine("* Вариант #28                                                            *");
            Console.WriteLine("* Выполнила: Екатерина Е.С | ИСПб-25-1                                   *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Используя цикл foreach заменить буквы q на цифру 7 в строке            *");
            Console.WriteLine("* sqwreq vqwqq q                                                         *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            
            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Исходные данные:");
            Console.WriteLine("Старт диапазона: " + startValue);
            Console.WriteLine("Конец диапазона: " + stopValue);





            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            double result = ds.Calculate(startValue, stopValue);
            Console.WriteLine("Сумма значений функции: " + result);







            Console.ReadKey();
        }
    }
}


