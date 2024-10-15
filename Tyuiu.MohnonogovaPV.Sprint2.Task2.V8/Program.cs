using Tyuiu.MohnonogovaPV.Sprint2.Task2.V8.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint2.Task2.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Мохноногова П. В. | АСОиУБ - 24-1";
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                *");
            Console.WriteLine("* Тема: Операции сравнения                                                                 *");
            Console.WriteLine("* Задание #2                                                                               *");
            Console.WriteLine("* Вариант #8                                                                               *");
            Console.WriteLine("* Выполнила: Мохноногова Полина Викторовна | АСОиУБ - 24-1                                   *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
            Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры и вычисляет       *");
            Console.WriteLine("* находится ли точка с координатами X,Y в заштрихованной области.                          *");
            Console.WriteLine("*                                                                                          *");

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            int x = 0;
            int y = 0;

            Console.WriteLine("Введите значение x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение y: ");
            y = Convert.ToInt32(Console.ReadLine());


            bool res = true;
            res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}