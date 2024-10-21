namespace ArrayDemo.Jagged
{
    public class JaggedArray
    {
        public static void Run()
        {
            int[][] jaggedArray = new int[2][];
            jaggedArray[0] = new int[] { 1, 2 };
            jaggedArray[1] = new int[] { 3, 4, 5 };

            Console.WriteLine("Mảng răng cưa:");
            foreach (var arr in jaggedArray)
            {
                foreach (var num in arr)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
