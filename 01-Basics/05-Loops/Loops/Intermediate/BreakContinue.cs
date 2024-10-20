namespace CSharpLoopsDemo.Intermediate
{
    public class BreakContinue
    {
        public static void Run()
        {
            Console.WriteLine("Sử dụng break và continue trong vòng lặp for:");
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine("Break khi i = 5");
                    break;
                }
                if (i % 2 == 0)
                {
                    continue; // Bỏ qua số chẵn
                }
                Console.WriteLine($"Giá trị của i: {i}");
            }
        }
    }
}
