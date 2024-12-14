using Tyuiu.BondarevTK.Sprint4.Task0.V13.Lib;
    namespace Tyuiu.BondarevTK.Sprint4.Task0.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[] array = new int[] { 2, 6, 2, 3, 4, 5, 4, 9, 7, 8 };
            Console.WriteLine(ds.GetSumEvenArrEl(array));
        }
    }
}
