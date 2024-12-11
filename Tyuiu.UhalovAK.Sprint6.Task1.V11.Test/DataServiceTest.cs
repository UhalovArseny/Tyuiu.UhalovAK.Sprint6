using Tyuiu.UhalovAK.Sprint6.Task1.V11.Lib;
namespace Tyuiu.UhalovAK.Sprint6.Task1.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidMassFunction()
        {
            DataService ds = new DataService();

            int startStep = -5;
            int stopStep = 5;
            int len = Math.Abs(startStep) + Math.Abs(stopStep) + 1;
            double[] array = new double[len];
            array[0] = -15.40;
            array[1] = -13.31;
            array[2] = -11.36;
            array[3] = -8.00;
            array[4] = -2.62;
            array[5] = 1.83;
            array[6] = 4.49;
            array[7] = 6.78;
            array[8] = 10.58;
            array[9] = 17.38;
            array[10] = 23.76;
            double[] res = ds.GetMassFunction(startStep, stopStep);
            CollectionAssert.AreEqual(array, res);

        }
    }
}