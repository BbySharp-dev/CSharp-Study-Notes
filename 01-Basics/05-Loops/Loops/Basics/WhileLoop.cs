namespace CSharpLoops.Basics
{
    public class WhileLoop
    {
        public static void Run()
        {
            /// <summary>
            /// Ví dụ về vòng lặp while.
            /// </summary>
            /// <remarks>
            /// Vòng lặp while lặp khi điều kiện còn đúng.
            /// </remarks>
            int i = 0;
            Console.WriteLine("Vòng lặp while từ 0 đến 4:");
            while (i < 5)
            {
                Console.WriteLine("Giá trị của i: " + i);
                i++;
            }
        }
    }
}
