using Tyuiu.KashinaVE.Sprint4.Task2.V6.Lib;

namespace Tyuiu.KashinaVE.Sprint4.Task2.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();

            Console.Title = "Спринт #3 | Выполнила: Кашина В. Е. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы. (ввод с клавиатуры)                           *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #6                                                             *");
            Console.WriteLine("* Выполнила: Кашина Валерия Евгеньевна | ИБКСб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 15 элементов                     *");
            Console.WriteLine("*  заполненный случайными в диапазоне от 2 до 8 подсчитать произведение   *");
            Console.WriteLine("* нечетных элементов массива.                                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int len = 15;
            int[] numsArray = new int[len];

            Random rdn = new Random();

            Console.Write("Массив: ");
            for (int i = 0; i < len; i++)
            {
                numsArray[i] = rnd.Next(2, 9);
                Console.Write(numsArray[i] + "\t");
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(numsArray);
            Console.WriteLine("Произведение нечетных элементов массива = " + res);

            Console.ReadKey();

        }
    }
}