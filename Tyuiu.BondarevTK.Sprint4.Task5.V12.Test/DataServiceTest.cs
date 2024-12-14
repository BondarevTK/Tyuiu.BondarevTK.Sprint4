using Tyuiu.BondarevTK.Sprint4.Task5.V12.Lib;
namespace Tyuiu.BondarevTK.Sprint4.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[,] array = new int[,] { { -8, 7, 5, 8, 7 }, { -8, 3, 3, 6, 4 }, { -4, 4, 5, 5, 4 }, { -3, 4, 7, 7, 3 }, { -6, 8, 3, 6, 7 } };
            DataService ds = new DataService();
            int res = ds.Calculate(array);
            Assert.AreEqual(5, res);
        }
    }
}