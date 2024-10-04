using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KimmelDS.Sprint1.Task1.V29.Lib
{
    public class DataService : ISprint1Task1V29
    {
        public double Calculate(double a, double b, double c) => a * b * c / (a + b + c);
    }
}
