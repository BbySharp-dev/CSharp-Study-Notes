using System;

namespace CSharpLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chọn bài học để ôn tập về Loops trong C# (1-7):");
            Console.WriteLine("1. Vòng lặp for");
            Console.WriteLine("2. Vòng lặp while");
            Console.WriteLine("3. Vòng lặp do...while");
            Console.WriteLine("4. Vòng lặp foreach");
            Console.WriteLine("5. break và continue");
            Console.WriteLine("6. Vòng lặp lồng nhau");
            Console.WriteLine("7. Tối ưu hóa vòng lặp");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Basics.ForLoop.Run();
                    break;
                case 2:
                    Basics.WhileLoop.Run();
                    break;
                case 3:
                    Basics.DoWhileLoop.Run();
                    break;
                case 4:
                    Basics.ForeachLoop.Run();
                    break;
                case 5:
                    Intermediate.BreakAndContinue.Run();
                    break;
                case 6:
                    Intermediate.NestedLoops.Run();
                    break;
                case 7:
                    Advanced.LoopOptimization.Run();
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    break;
            }
        }
    }
}
