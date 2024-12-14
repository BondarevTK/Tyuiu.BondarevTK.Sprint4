using Tyuiu.BondarevTK.Sprint4.Task0.V13.Lib;
namespace Tyuiu.BondarevTK.Sprint4.Task0.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] array = new int[] { 2, 6, 2, 3, 4, 5, 4, 9, 7, 8 };
            DataService ds = new DataService();
            int res = ds.GetSumEvenArrEl(array);
            Assert.AreEqual(res, 26);
        }
    }
}