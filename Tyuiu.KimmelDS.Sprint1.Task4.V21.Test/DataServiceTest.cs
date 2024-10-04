using Tyuiu.KimmelDS.Sprint1.Task4.V21.Lib;

namespace Tyuiu.KimmelDS.Sprint1.Task4.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ds = new DataService();
            Assert.AreEqual(0.667, ds.Calculate(1, 2));
        }
    }
}