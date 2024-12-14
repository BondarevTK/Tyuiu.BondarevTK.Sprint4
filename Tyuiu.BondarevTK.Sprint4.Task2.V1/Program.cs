using Tyuiu.BondarevTK.Sprint4.Task2.V1.Lib;
namespace Tyuiu.BondarevTK.Sprint4.Task2.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();
            int len;
            len = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[len];
            for (int i = 0; i < len; i++)
            {
                array[i] = rnd.Next(1, 9);
            }
            Console.WriteLine(ds.Calculate(array));

        }
    }
}
