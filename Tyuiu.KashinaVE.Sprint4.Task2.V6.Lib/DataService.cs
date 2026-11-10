using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KashinaVE.Sprint4.Task2.V6.Lib
{
    public class DataService : ISprint4Task2V6
    {
        public int Calculate(int[] array)
        {
            int multiply = 1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    multiply *= array[i];
                }
            }

            return multiply;
        }
    }
}
