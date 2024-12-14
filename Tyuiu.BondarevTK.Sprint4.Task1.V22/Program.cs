using Tyuiu.BondarevTK.Sprint4.Task1.V22.Lib;
namespace Tyuiu.BondarevTK.Sprint4.Task1.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int len;
            len = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[len];
            for (int i = 0; i < len; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(ds.Calculate(array));
        }
    }
}
