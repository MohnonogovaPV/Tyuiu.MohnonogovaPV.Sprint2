using Tyuiu.MohnonogovaPV.Sprint2.Task5.V8.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint2.Task5.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Мохноногова П. В. | АСОиУБ - 24-1";
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                *");
            Console.WriteLine("* Тема: Оператор switch                                                                    *");
            Console.WriteLine("* Задание #5                                                                               *");
            Console.WriteLine("* Вариант #8                                                                               *");
            Console.WriteLine("* Выполнила: Мохноногова Полина Викторовна | АСОиУБ - 24-1                                 *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,                  *");
            Console.WriteLine("* вычисляет, и печатает результат на экране.                                               *");
            Console.WriteLine("*                                                                                          *");

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine("Введите месяц:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите день: ");
            int m = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((n < 1) || (n > 12))
            {
                res = "Введенно неверное значение!";
            }
            else
            {
                res = "Дата предыдущего дня - " + ds.FindDateOfPreviousDay(m, n);
            }
            if ((m < 1) || (m > 32))
            {
                res = "Введенно неверное значение!";
            }
            else
            {
                res = "Дата предыдущего дня - " + ds.FindDateOfPreviousDay(m, n);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);
            Console.ReadKey();

        }
    }
}
