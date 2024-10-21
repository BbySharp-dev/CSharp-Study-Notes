namespace ArrayDemo.ErrorHandling
{
    public class ErrorHandlingInArrays
    {
        public static void Run()
        {
            try
            {
                int[] numbers = { 1, 2, 3 };
                // Intentional out-of-bound access
                Console.WriteLine(numbers[5]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Lỗi: Truy cập chỉ mục ngoài phạm vi của mảng. " + ex.Message);
            }

            try
            {
                int[] emptyArray = null;
                Console.WriteLine(emptyArray.Length);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Lỗi: Mảng null. " + ex.Message);
            }
        }
    }
}
