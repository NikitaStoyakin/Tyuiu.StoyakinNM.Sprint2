using Tyuiu.StoyakinNM.Sprint2.Task6.V6.Lib;
namespace Tyuiu.StoyakinNM.Sprint2.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardNameAndValue()
        {
            DataService ds = new DataService();

            string result1 = ds.FindCardNameAndValue(1, 6); 
            Assert.AreEqual("Шестерка пик", result1);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidSuit()
        {
            DataService ds = new DataService();
            ds.FindCardNameAndValue(5, 6); 
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidRank()
        {
            DataService ds = new DataService();
            ds.FindCardNameAndValue(1, 15); 
        }


    }
}