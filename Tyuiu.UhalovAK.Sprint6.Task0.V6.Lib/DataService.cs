using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.UhalovAK.Sprint6.Task0.V6.Lib
{
    public class DataService : ISprint6Task0V6
    {
        public double Calculate(int x)
        {
            double res = Math.Round(x / (Math.Sqrt(Math.Pow(x, 2) + x)),3);
            return res;
        }
    }
}
