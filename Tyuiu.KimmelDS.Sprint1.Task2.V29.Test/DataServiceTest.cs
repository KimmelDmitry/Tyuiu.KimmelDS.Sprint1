using Tyuiu.KimmelDS.Sprint1.Task2.V29.Lib;

namespace Tyuiu.KimmelDS.Sprint1.Task2.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]    
        public void CheckDataServiceValid()
        {
            var service = new DataService();
            Assert.AreEqual(1, service.ConvertSecondsToHours(112));
        }
    }
}