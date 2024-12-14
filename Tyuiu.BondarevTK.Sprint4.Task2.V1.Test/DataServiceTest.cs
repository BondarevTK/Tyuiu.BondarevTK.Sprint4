using Tyuiu.BondarevTK.Sprint4.Task2.V1.Lib;
namespace Tyuiu.BondarevTK.Sprint4.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 2, 2 };
            int res = ds.Calculate(array);
            Assert.AreEqual(4, res);
        }
    }
}