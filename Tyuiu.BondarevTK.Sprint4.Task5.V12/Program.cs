using Tyuiu.BondarevTK.Sprint4.Task5.V12.Lib;
namespace Tyuiu.BondarevTK.Sprint4.Task5.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();
            int[,] matrix = new int[5, 5];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int x = rnd.Next(-6, 4);
                    matrix[i, j] = x;
                }
            }
            
            int res = ds.Calculate(matrix);
            Console.WriteLine(res);
        }
    }
}
