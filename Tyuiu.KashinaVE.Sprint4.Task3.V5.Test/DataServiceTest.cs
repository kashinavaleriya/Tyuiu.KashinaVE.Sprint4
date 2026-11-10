using Tyuiu.KashinaVE.Sprint4.Task3.V5.Lib;

namespace Tyuiu.KashinaVE.Sprint4.Task3.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            // Тестовый массив
            int[,] array = new int[3, 3] {
                { 2, 5, 6 },
                { 4, 7, 8 },
                { 9, 1, 2 }
            };

            // Первый столбец: 2, 4, 9. Их сумма: 2 + 4 + 9 = 15
            int wait = 15;
            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }
    }
}
