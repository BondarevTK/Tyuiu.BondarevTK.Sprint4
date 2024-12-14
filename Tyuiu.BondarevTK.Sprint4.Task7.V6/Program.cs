using Tyuiu.BondarevTK.Sprint4.Task7.V6.Lib;
namespace Tyuiu.BondarevTK.Sprint4.Task7.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string value = "458963214789";
            int n = 3;
            int m = 4;
            int res = ds.Calculate(n, m, value);
            Console.WriteLine(res);
        }
    }
}
