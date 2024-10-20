namespace CSharpLoops.Basics
{
    public class ForLoop
    {
        public static void Run()
        {
            /// <summary>
            /// Ví dụ về vòng lặp for.
            /// </summary>
            /// <remarks>
            /// Vòng lặp for dùng để lặp một đoạn mã với số lần lặp xác định trước.
            /// </remarks>
            Console.WriteLine("Vòng lặp for từ 0 đến 4:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Giá trị của i: " + i);
            }
        }
    }
}
