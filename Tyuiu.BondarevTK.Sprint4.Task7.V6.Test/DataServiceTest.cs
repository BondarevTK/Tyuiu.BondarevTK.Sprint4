using Tyuiu.BondarevTK.Sprint4.Task7.V6.Lib;
namespace Tyuiu.BondarevTK.Sprint4.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "458963214789";
            int n = 3;
            int m = 4;
            int res = ds.Calculate(n, m, value);
            Assert.AreEqual(34, res);
        }
    }
}