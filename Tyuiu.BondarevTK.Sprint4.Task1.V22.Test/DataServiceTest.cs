using Tyuiu.BondarevTK.Sprint4.Task1.V22.Lib;
namespace Tyuiu.BondarevTK.Sprint4.Task1.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 2, 2};
            int res = ds.Calculate(array);
            Assert.AreEqual(4, res);
        }
    }
}