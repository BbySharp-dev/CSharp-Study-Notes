namespace CSharpLoopsDemo.Advanced
{
    public class LoopOptimization
    {
        public static void Run()
        {
            // Ví dụ về tối ưu hóa vòng lặp với Parallel.For
            int[] largeArray = new int[1000000];
            Console.WriteLine("Sử dụng Parallel.For để xử lý mảng lớn:");
            Parallel.For(0, largeArray.Length, i =>
            {
                // Xử lý dữ liệu
                largeArray[i] = i;
            });
        }
    }
}
