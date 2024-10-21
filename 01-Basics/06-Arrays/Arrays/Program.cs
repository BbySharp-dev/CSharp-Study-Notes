using System;
using ArrayDemo.Basic;
using ArrayDemo.Operations;
using ArrayDemo.Advanced;
using ArrayDemo.Linq;
using ArrayDemo.ErrorHandling;
using ArrayDemo.Jagged;
using ArrayDemo.Multidimensional;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chọn bài tập để thực hiện (1-7): ");
            Console.WriteLine("1. Mảng cơ bản");
            Console.WriteLine("2. Các thao tác trên mảng");
            Console.WriteLine("3. Mảng nhiều chiều");
            Console.WriteLine("4. Mảng răng cưa");
            Console.WriteLine("5. Các phương thức nâng cao");
            Console.WriteLine("6. LINQ và xử lý lỗi trong mảng");
            Console.WriteLine("7. Thoát chương trình");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nBài tập 1: Mảng cơ bản");
                    BasicArray.Run();
                    break;
                case 2:
                    Console.WriteLine("\nBài tập 2: Các thao tác trên mảng");
                    ArrayOperations.Run();
                    break;
                case 3:
                    Console.WriteLine("\nBài tập 3: Mảng nhiều chiều");
                    MultidimensionalArray.Run();
                    break;
                case 4:
                    Console.WriteLine("\nBài tập 4: Mảng răng cưa");
                    JaggedArray.Run();
                    break;
                case 5:
                    Console.WriteLine("\nBài tập 5: Các phương thức nâng cao");
                    AdvancedArray.Run();
                    break;
                case 6:
                    Console.WriteLine("\nBài tập 6: LINQ và xử lý lỗi trong mảng");
                    Console.WriteLine("6.1 - LINQ trong mảng");
                    LinqArrayDemo.Run();
                    Console.WriteLine("6.2 - Xử lý lỗi trong mảng");
                    ErrorHandlingInArrays.Run();
                    break;
                case 7:
                    Console.WriteLine("Thoát chương trình.");
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn từ 1-7.");
                    break;
            }
        }
    }
}
