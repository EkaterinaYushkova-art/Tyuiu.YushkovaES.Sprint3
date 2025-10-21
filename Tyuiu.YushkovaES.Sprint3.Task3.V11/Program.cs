using Tyuiu.YushkovaES.Sprint3.Task3.V11.Lib;
namespace Tyuiu.YushkovaES.Sprint3.Task3.V11
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
            Console.WriteLine("* Задание #3                                                             *");
            Console.WriteLine("* Вариант #11                                                            *");
            Console.WriteLine("* Выполнила: Екатерина Е.С | ИСПб-25-1                                   *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Используя цикл foreach заменить буквы q на цифру 7 в строке            *");
            Console.WriteLine("* sqwreq vqwqq q                                                         *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            
            string value = "sqwreq vqwqq q";
            char replaceable = 'q';
            char replacement = '7';

            Console.WriteLine("Исходные данные:");
            Console.WriteLine("Строка: " + value);
            Console.WriteLine("Заменяемый символ: " + replaceable);
            Console.WriteLine("Символ для замены: " + replacement);




            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            string result = ds.ReplaceCharOnNum(value, replaceable, replacement);
            Console.WriteLine("Результат: " + result);






            Console.ReadKey();
        }
    }
}

