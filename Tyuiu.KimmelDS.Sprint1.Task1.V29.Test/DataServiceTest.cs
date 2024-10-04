using Tyuiu.KimmelDS.Sprint1.Task1.V29.Lib;

namespace Tyuiu.KimmelDS.Sprint1.Task1.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var service = new DataService();
            Assert.AreEqual(1, service.Calculate(1, 2, 3));
        }
    }
}