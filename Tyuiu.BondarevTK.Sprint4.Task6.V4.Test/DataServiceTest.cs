using Tyuiu.BondarevTK.Sprint4.Task6.V4.Lib;
namespace Tyuiu.BondarevTK.Sprint4.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string[] array = { "������", "����� ���������", "�����������", "������������", "������ ��������", "���������", "������" };
            string[] wait = { "������", "������" };
            DataService ds = new DataService();
            string[] res = ds.Calculate(array);
            CollectionAssert.AreEqual(res, wait);
        }
    }
}