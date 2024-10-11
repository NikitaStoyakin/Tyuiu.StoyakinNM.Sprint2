using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.StoyakinNM.Sprint2.Task4.V24.Lib
{
    public class DataService : ISprint2Task4V24
    {
        public double Calculate(double x, double y)
        {
            double part1 = Math.Pow(x, 2);
            double part2 = Math.Pow(y, 2);
            
            double z = x + 2 > y + 24 ? x*(Math.Pow((y+1/x+2), x)) : (Math.Pow(y, 2) + Math.Cos(part1) + 9) / (Math.Pow(x, 2) - Math.Sin(part2) + 12);
            return Math.Round(z, 3);
        }
    }
}
