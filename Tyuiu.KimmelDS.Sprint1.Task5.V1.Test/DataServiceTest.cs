using Tyuiu.KimmelDS.Sprint1.Task5.V1.Lib;

namespace Tyuiu.KimmelDS.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckDistanceBetweenDotsValid()
        {
            var ds = new DataService();
            
            Assert.AreEqual(1, ds.DistanceBetweenDots(1, 1, 2, 2));
        }
    }
}