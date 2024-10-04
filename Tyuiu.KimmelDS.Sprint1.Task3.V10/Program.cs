using Tyuiu.KimmelDS.Sprint1.Task3.V10.Lib;
namespace Tyuiu.KimmelDS.Sprint1.Task3.V10
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
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Киммель Дмитрий Сергеевич | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            
            Console.WriteLine("*Написать программу, которая преобразует введенное с клавиатуры дробное  *");
            Console.WriteLine("*число в денежный формат. Ответ округлите до 3 знаков после запятой.     *");

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
            double data = ds.NumberToMoney(23.6);

            var text = string.Format("{0:f2}", data).Split(',').Select(int.Parse).ToArray();

            int rubs = text[0];
            int kops = text[1];

            Console.WriteLine($"{data}pуб. - это {rubs} руб. {kops} коп.");
            Console.ReadKey();
        }
    }
}