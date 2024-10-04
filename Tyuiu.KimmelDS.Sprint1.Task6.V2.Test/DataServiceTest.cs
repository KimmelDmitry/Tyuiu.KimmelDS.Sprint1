using Tyuiu.KimmelDS.Sprint1.Task6.V2.Lib;

namespace Tyuiu.KimmelDS.Sprint1.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckHelloTest()
        {
            DataService ds = new DataService();

            Assert.AreEqual(true, ds.CheckHello("Hello World!"));
        }
    }
}