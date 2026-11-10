using Tyuiu.KashinaVE.Sprint4.Task2.V6.Lib;

namespace Tyuiu.KashinaVE.Sprint4.Task2.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 2, 4, 3, 6, 5, 8, 7 };

            int expected = 105;

            int res = ds.Calculate(numsArray);

            Assert.AreEqual(expected, res);
        }
    }
}
