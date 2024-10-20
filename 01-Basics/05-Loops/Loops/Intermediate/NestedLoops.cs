namespace CSharpLoopsDemo.Intermediate
{
    public class NestedLoops
    {
        public static void Run()
        {
            Console.WriteLine("Sử dụng vòng lặp lồng nhau để in bảng nhân:");
            for (int i = 1; i <= 5; i++)  // Vòng lặp ngoài cho hàng
            {
                for (int j = 1; j <= 5; j++)  // Vòng lặp trong cho cột
                {
                    Console.Write($"{i * j}\t");  // In ra kết quả nhân giữa i và j
                }
                Console.WriteLine();  // Xuống dòng sau mỗi hàng
            }
        }
    }
}
