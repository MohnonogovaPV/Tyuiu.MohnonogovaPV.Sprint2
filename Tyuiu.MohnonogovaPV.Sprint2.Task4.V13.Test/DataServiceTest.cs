using Tyuiu.MohnonogovaPV.Sprint2.Task4.V13.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint2.Task4.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 100;
            double y = 10;
            double res = ds.Calculate(x, y);
            double wait = 199.99;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 20;
            double res = ds.Calculate(x, y);
            double wait = 0.069;
            Assert.AreEqual(wait, res);
        }
    }
}
