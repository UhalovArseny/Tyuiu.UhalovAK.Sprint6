using Tyuiu.UhalovAK.Sprint6.Task0.V6.Lib;

namespace Tyuiu.UhalovAK.Sprint6.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int x = 3;
            double res = ds.Calculate(x);
            double wait = 0.866;

            Assert.AreEqual(wait, res);
        }
    }
}