using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MohnonogovaPV.Sprint2.Task5.V8.Lib
{
    public class DataService : ISprint2Task5V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            string res;

            switch (n)
            {
                case 1:
                    res = "01";
                    break;
                case 2:
                    res = "02";
                    break;
                case 3:
                    res = "03";
                    break;
                case 4:
                    res = "04";
                    break;
                case 5:
                    res = "05";
                    break;
                case 6:
                    res = "06";
                    break;
                case 7:
                    res = "07";
                    break;
                case 8:
                    res = "08";
                    break;
                case 9:
                    res = "09";
                    break;
                case 10:
                    res = "10";
                    break;
                case 11:
                    res = "11";
                    break;
                case 12:
                    res = "12";
                    break;
                default:
                    throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {n}");

            }
            if ((m > 1) && (m < 32))
            {
                m = m - 1;
            }
            else
            {
                Console.WriteLine("Число дня задано некорректно. Введите число от 2 до 31");
            }
            return m + "." + res;
        }
    }
}
