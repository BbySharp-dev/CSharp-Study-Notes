namespace ArrayDemo.Advanced
{
    public class AdvancedArray
    {
        public static void Run()
        {
            int[] original = { 1, 2, 3, 4, 5 };
            int[] clone = (int[])original.Clone();
            Console.WriteLine("Mảng gốc: " + string.Join(", ", original));
            Console.WriteLine("Mảng clone: " + string.Join(", ", clone));

            bool areEqual = original.Equals(clone);
            Console.WriteLine("Mảng gốc và mảng clone có bằng nhau không? " + areEqual);
        }
    }
}
