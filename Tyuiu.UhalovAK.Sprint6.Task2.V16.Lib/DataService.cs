using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.UhalovAK.Sprint6.Task2.V16.Lib
{
    public class DataService : ISprint6Task2V16
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            if (startValue > startValue)
            {
                int temp = startValue;
                stopValue = startValue;
                startValue = temp;
            }

            double[] resMass = new double[Math.Abs(stopValue - startValue) + 1];

            for (int i = 0; i < resMass.Length; i++)
            {
                if (double.IsInfinity(startValue) || double.IsNaN(startValue))
                {
                    resMass[i] = 0.0;
                    startValue++;
                    continue;
                }

                resMass[i] = Math.Cos(startValue) / (startValue - 0.4) + Math.Sin(startValue) * 8 * startValue + 2;
                resMass[i] = Math.Round(resMass[i], 2);
                startValue++;
            }

            return resMass;
        }
    }
}