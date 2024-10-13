using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.StoyakinNM.Sprint2.Task7.V12.Lib
{
    public class DataService : ISprint2Task7V12
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((y > 0) && (y >= Math.Pow(x, 2)) && (x <= Math.Pow(y, 2)) || (y > 0) && (y <= 2 - x) && (x >= Math.Pow(x, 2)))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
