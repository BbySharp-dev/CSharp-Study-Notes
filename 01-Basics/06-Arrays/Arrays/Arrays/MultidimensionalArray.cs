namespace ArrayDemo.Multidimensional
{
    public class MultidimensionalArray
    {
        public static void Run()
        {
            int[,] matrix = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            Console.WriteLine("Mảng 2 chiều:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
