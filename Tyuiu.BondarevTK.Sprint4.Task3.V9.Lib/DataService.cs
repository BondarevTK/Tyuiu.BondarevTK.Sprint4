using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BondarevTK.Sprint4.Task3.V9.Lib
{
    public class DataService : ISprint4Task3V9
    {
        public int Calculate(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; i < array.GetLength(1); i++)
                {
                    if (array[i, j] == array[i,2])
                    {
                        sum += array[i, j];
                    }
                }
            }
            return sum;
        }
    }
}
