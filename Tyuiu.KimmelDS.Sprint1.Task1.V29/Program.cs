﻿using Tyuiu.KimmelDS.Sprint1.Task1.V29.Lib;
namespace Tyuiu.KimmelDS.Sprint1.Task1.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Киммель Дмитрий Сергеевич | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Алгоритмы линейной структуры                                            *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Киммель Дмитрий Сергеевич | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
                                 
            Console.WriteLine("*Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("*вычисляет результат по формуле a* b*c / (a + b + c) и печатает его на экране.*");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* 1, 2, 3                                                                   *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.Calculate(1, 2, 3); 
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}