using Tyuiu.KashinaVE.Sprint4.Task7.V1.Lib;

namespace Tyuiu.KashinaVE.Sprint4.Task7.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string value = "135792468";

            Assert.AreEqual(4, ds.Calculate(3, 3, value));
        }
    }
}
