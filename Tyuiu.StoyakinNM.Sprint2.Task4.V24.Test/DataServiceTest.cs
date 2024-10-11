using Tyuiu.StoyakinNM.Sprint2.Task4.V24.Lib;
namespace Tyuiu.StoyakinNM.Sprint2.Task4.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 24;
            double y = 1;   
            double res = ds.Calculate(x, y);
            double wait = 9438219722273.4;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 24;
            double y = 4;
            double res = ds.Calculate(x, y);
            double wait = 0.042;
            Assert.AreEqual(wait, res);
        }
    }
}