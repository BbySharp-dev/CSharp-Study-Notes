namespace ArrayDemo.Basic
{
    public class BasicArray
    {
        public static void Run()
        {
            // Khai báo mảng 1 chiều
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Mảng số nguyên: ");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\nThay đổi phần tử đầu tiên thành 10.");
            numbers[0] = 10;
            Console.WriteLine("Mảng sau khi thay đổi: ");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
        }
    }
}
