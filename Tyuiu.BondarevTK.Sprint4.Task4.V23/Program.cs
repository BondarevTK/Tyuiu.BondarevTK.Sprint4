using Tyuiu.BondarevTK.Sprint4.Task4.V23.Lib;
namespace Tyuiu.BondarevTK.Sprint4.Task4.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 5];
            for (int i = 0;  i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int x = Convert.ToInt32(Console.ReadLine());
                    matrix[i, j] = x;
                }
            }
            DataService ds = new DataService();
            int res = ds.Calculate(matrix);
            Console.WriteLine(res);
        }
    }
}
