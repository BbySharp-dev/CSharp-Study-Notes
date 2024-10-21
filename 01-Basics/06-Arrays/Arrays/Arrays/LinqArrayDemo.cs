using System.Linq;

namespace ArrayDemo.Linq
{
    public class LinqArrayDemo
    {
        public static void Run()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };

            var evenNumbers = numbers.Where(n => n % 2 == 0).ToArray();
            Console.WriteLine("Các số chẵn trong mảng: " + string.Join(", ", evenNumbers));

            var squaredNumbers = numbers.Select(n => n * n).ToArray();
            Console.WriteLine("Các số bình phương: " + string.Join(", ", squaredNumbers));
        }
    }
}
