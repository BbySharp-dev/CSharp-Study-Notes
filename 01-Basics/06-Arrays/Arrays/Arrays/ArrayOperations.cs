namespace ArrayDemo.Operations
{
    public class ArrayOperations
    {
        public static void Run()
        {
            int[] numbers = { 5, 1, 4, 2, 3 };
            Console.WriteLine("Mảng trước khi sắp xếp: " + string.Join(", ", numbers));
            Array.Sort(numbers);
            Console.WriteLine("Mảng sau khi sắp xếp: " + string.Join(", ", numbers));

            int index = Array.IndexOf(numbers, 3);
            Console.WriteLine("Vị trí của phần tử 3: " + index);

            Array.Reverse(numbers);
            Console.WriteLine("Mảng sau khi đảo ngược: " + string.Join(", ", numbers));
        }
    }
}
