using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KimmelDS.Sprint1.Task2.V29.Lib
{
    public class DataService : ISprint1Task2V29
    {
        public int ConvertSecondsToHours(int value)
        {
            if (value <= 0)
            {
                Console.WriteLine("недопустимое значение");
                return 0;
            }
            return value / 60;
        }
    }
}
