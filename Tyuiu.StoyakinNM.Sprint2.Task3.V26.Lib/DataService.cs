using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.StoyakinNM.Sprint2.Task3.V26.Lib
{
    public class DataService : ISprint2Task3V26
    {
        public double Calculate(double x)
        {
            double y = 0;
            double part1 = x + 1;
            double part2 = Math.Cos(Math.Pow(x, 2));
            

            if (x > 0)
            {
                y = x + Math.Pow((part1 / part2), x);
            }
            else
            {
                if (x == 0)
                {
                    y = 15 + x / Math.Pow(3,2) - Math.Sin(Math.Pow(x, 2));
                }
                else
                {
                    if ((x > -30) && (x < 0))
                    {
                        y = Math.Pow((Math.Sin(Math.Pow(x, 3)) / x + 5), x);
                    }
                    else
                    {
                        if (x < -30)
                        {
                            y = x = 7*x - (1 / x);
                        }
                    }
                }
            }
            return Math.Round(y, 3);
        }
    }
}
