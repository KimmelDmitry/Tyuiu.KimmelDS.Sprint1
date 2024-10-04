using Tyuiu.KimmelDS.Sprint1.Task3.V10.Lib;

namespace Tyuiu.KimmelDS.Sprint1.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckDataServiceValid()
        {
            var ds = new DataService();
            Assert.AreEqual(26.6, ds.NumberToMoney(26.6));
        }
    }
}