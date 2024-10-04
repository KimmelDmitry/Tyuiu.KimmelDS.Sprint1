using Tyuiu.KimmelDS.Sprint1.Task7.V26.Lib;

namespace Tyuiu.KimmelDS.Sprint1.Task7.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ds = new DataService();
            Assert.AreEqual(1.233, ds.Calculate(1, 2));
        }
    }
}