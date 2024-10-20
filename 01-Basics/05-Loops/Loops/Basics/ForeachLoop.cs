namespace CSharpLoopsDemo.Basics
{
    public class ForeachLoop
    {
        public static void Run()
        {
            string[] fruits = { "Apple", "Banana", "Cherry" };
            Console.WriteLine("Sử dụng vòng lặp foreach để in danh sách hoa quả:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
