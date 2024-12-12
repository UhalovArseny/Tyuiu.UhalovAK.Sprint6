using Tyuiu.UhalovAK.Sprint6.Task2.V16.Lib;
namespace Tyuiu.UhalovAK.Sprint6.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            double[] res = ds.GetMassFunction(-1, 1);
            double[] wait = { 8.35, -0.5, 9.63 };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}