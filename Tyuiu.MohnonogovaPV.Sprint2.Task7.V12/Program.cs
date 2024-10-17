using Tyuiu.MohnonogovaPV.Sprint2.Task7.V12.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint2.Task7.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Мохноногова П. В. | АСОиУБ - 24-1";
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                                  *");
            Console.WriteLine("* Задание #7                                                                               *");
            Console.WriteLine("* Вариант #12                                                                              *");
            Console.WriteLine("* Выполнила: Мохноногова Полина Викторовна | АСОиУБ - 24-1                                 *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные (вещественные значения)    *");
            Console.WriteLine("* и вычисляет, находится ли точка с координатами X,Y в заштрихованной области.             *");
            Console.WriteLine("*                                                                                          *");

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            bool res = ds.CheckDotInShadedArea(x, y);
            if (res == true)
            {
                Console.WriteLine("Точка входит в указанную область!");
            }
            else
            {
                Console.WriteLine("Точка НЕ входит в указанную область!");
            }
            Console.ReadLine();
        }
    }
}
        
    

