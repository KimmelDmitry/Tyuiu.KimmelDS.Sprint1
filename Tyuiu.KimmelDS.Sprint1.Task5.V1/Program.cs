using Tyuiu.KimmelDS.Sprint1.Task5.V1.Lib;
namespace Tyuiu.KimmelDS.Sprint1.Task5.V1
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
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #1                                                            *");
            Console.WriteLine("* Выполнил: Киммель Дмитрий Сергеевич | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            

            
            Console.WriteLine("*Написать программу, которая решает следующую задачу:                    *");
            Console.WriteLine("*Найти расстояние между двумя точками с заданными координатами(x, y).    *");
            Console.WriteLine("*Ответ привести к целому с помощью класса Convert.                       *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.DistanceBetweenDots(2, 2, 1, 1);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}