using Tyuiu.KimmelDS.Sprint1.Task0.V8.Lib;

namespace Tyuiu.KimmelDS.Sprint1.Task0.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckDataServiceValid()
        {
            var service = new DataService();
            var result = service.Calculate();
            Assert.AreEqual(1.875, result);
        }
    }
}