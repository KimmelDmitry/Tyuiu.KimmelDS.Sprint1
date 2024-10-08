﻿using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KimmelDS.Sprint1.Task4.V21.Lib
{
    public class DataService : ISprint1Task4V21
    {
        public double Calculate(double x, double y) => Math.Round(Math.Abs(Math.Pow(1 + x, 2) - y) / (x + y), 3);
    }
}
