﻿using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KimmelDS.Sprint1.Task6.V2.Lib
{
    public class DataService : ISprint1Task6V2
    {
        public bool CheckHello(string value) => value.Contains("Hello");
    }
}
