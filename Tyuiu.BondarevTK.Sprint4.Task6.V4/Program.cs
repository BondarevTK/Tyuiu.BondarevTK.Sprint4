using System.Runtime.ExceptionServices;
using Tyuiu.BondarevTK.Sprint4.Task6.V4.Lib;
namespace Tyuiu.BondarevTK.Sprint4.Task6.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "Москва", "Санкт Петербург", "Новосибирск", "Екатеринбург", "Нижний Новгород", "Казахстан", "Самара" };
            DataService ds = new DataService();
            string[] res = ds.Calculate(array);
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }    
        }
    }
}
