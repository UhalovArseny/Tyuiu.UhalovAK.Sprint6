using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.UhalovAK.Sprint6.Task1.V11.Lib
{
    public class DataService : ISprint6Task1V11
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int count = 0;
            int len = Math.Abs(startValue) + Math.Abs(stopValue) + 1;
            double[] array = new double[len];
            for (int x = startValue; x <= stopValue; x++)
            {
                double y = ((5 * x + 2.5) / (Math.Sin(x) + 3)) + 2 * x + Math.Cos(x);
                y = Math.Round(y, 2);
                array[count] = y;
                count++;
            }
            return array;
        }
    }
}