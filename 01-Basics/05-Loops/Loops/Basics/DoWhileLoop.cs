namespace CSharpLoopsDemo.Basics
{
    public class DoWhileLoop
    {
        public static void Run()
        {
            int i = 0;
            Console.WriteLine("Vòng lặp do...while từ 0 đến 4:");
            do
            {
                Console.WriteLine($"Giá trị của i: {i}");
                i++;
            } while (i < 5);
        }
    }
}
