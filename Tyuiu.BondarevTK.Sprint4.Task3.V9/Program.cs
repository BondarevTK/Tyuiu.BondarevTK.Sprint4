using Tyuiu.BondarevTK.Sprint4.Task3.V9.Lib;
namespace Tyuiu.BondarevTK.Sprint4.Task3.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[,] array = new int[,] { { 9, 6, 4, 5, 3 }, { 7, 4, 7, 5, 3 }, { 8, 5, 9, 9, 3 }, { 7, 8, 7, 9, 3 }, { 3, 7, 3, 7, 7, } };
            int res = ds.Calculate(array);
            Console.WriteLine(res);
        }
    }
}
