using Tyuiu.KashinaVE.Sprint4.Task7.V1.Lib;

namespace Tyuiu.KashinaVE.Sprint4.Task7.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #4 | Выполнила: Кашина В. Е. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнила: Кашина Валерия Евгеньевна | ИБКСб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать програму, котороя преобразует строку в матрицу 3 на 3, и       *");
            Console.WriteLine("* находит сумму четных элементов матрицы.                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите количевство строк матрицы: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количевство столбцов мтарицы: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите строку цифр: ");
            string value = Console.ReadLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Сумма четных цифр матрицы 3 на 3 составленной из строки равна:\n" +
                 $"{ds.Calculate(n, m, value)}");
            Console.ReadKey(); 

        }

    }
}