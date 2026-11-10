using Tyuiu.KashinaVE.Sprint4.Task6.V25.Lib;

namespace Tyuiu.KashinaVE.Sprint4.Task6.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            var x = new string[] { "Òåííèñ", "Ôóòáîë", "Êðèêåò", "Áàñêåòáîë", "Áåéñáîë", "Ðåãáè", "Õîêêåé" };
            int res = ds.Calculate(x);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}
