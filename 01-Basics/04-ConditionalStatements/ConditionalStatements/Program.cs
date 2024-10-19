using System;

class Program
{
    static void Main(string[] args)
    {
        // 🎯 **Conditional Statements in C# (Câu lệnh điều kiện trong C#)**

        // 1️⃣ **If Statement (Câu lệnh If)**
        // ➡️ Câu lệnh if được sử dụng để kiểm tra điều kiện và thực hiện đoạn mã nếu điều kiện đó là true (đúng).
        Console.WriteLine("Example of If Statement:");
        int age = 20;
        if (age >= 18)
        {
            Console.WriteLine("Bạn đã đủ tuổi để bầu cử!");
        }

        // 2️⃣ **If-Else Statement (Câu lệnh If-Else)**
        // ➡️ Nếu điều kiện if không đúng, câu lệnh else sẽ được thực hiện.
        Console.WriteLine("\nExample of If-Else Statement:");
        age = 16;
        if (age >= 18)
        {
            Console.WriteLine("Bạn đã đủ tuổi để bầu cử.");
        }
        else
        {
            Console.WriteLine("Bạn chưa đủ tuổi để bầu cử.");
        }

        // 3️⃣ **If-Else If-Else (Câu lệnh If-Else If-Else)**
        // ➡️ Sử dụng khi cần kiểm tra nhiều điều kiện khác nhau.
        Console.WriteLine("\nExample of If-Else If-Else Statement:");
        int score = 75;
        if (score >= 90)
        {
            Console.WriteLine("Điểm: A");
        }
        else if (score >= 75)
        {
            Console.WriteLine("Điểm: B");
        }
        else
        {
            Console.WriteLine("Điểm: C");
        }

        // 4️⃣ **Nested If Statements (Câu lệnh If lồng nhau)**
        // ➡️ Cho phép lồng nhiều câu lệnh if bên trong nhau.
        Console.WriteLine("\nExample of Nested If Statements:");
        bool hasLicense = true;
        if (age >= 18)
        {
            if (hasLicense)
            {
                Console.WriteLine("Bạn có thể lái xe!");
            }
            else
            {
                Console.WriteLine("Bạn cần có giấy phép lái xe.");
            }
        }

        // 5️⃣ **Ternary Operator (Toán tử ba ngôi)**
        // ➡️ Một cách viết ngắn gọn của câu lệnh if-else.
        Console.WriteLine("\nExample of Ternary Operator:");
        string message = age >= 18 ? "Bạn là người trưởng thành." : "Bạn chưa trưởng thành.";
        Console.WriteLine(message);

        // 6️⃣ **Switch Case (Câu lệnh Switch)**
        // ➡️ Sử dụng khi có nhiều điều kiện cần kiểm tra dựa trên một biến duy nhất.
        Console.WriteLine("\nExample of Switch Case:");
        int day = 2;
        switch (day)
        {
            case 1:
                Console.WriteLine("Thứ Hai");
                break;
            case 2:
                Console.WriteLine("Thứ Ba");
                break;
            default:
                Console.WriteLine("Ngày không hợp lệ");
                break;
        }

        // 7️⃣ **Scenario: Xử lý kiểm tra đăng nhập**
        Console.WriteLine("\nScenario: Xử lý kiểm tra đăng nhập:");
        string username = "admin";
        string password = "12345";

        if (username == "admin")
        {
            if (password == "12345")
            {
                Console.WriteLine("Đăng nhập thành công!");
            }
            else
            {
                Console.WriteLine("Sai mật khẩu.");
            }
        }
        else
        {
            Console.WriteLine("Không tìm thấy tên người dùng.");
        }

        // 8️⃣ **Scenario: Tính thuế**
        Console.WriteLine("\nScenario: Tính thuế:");
        double salary = 6000000;
        double tax;

        if (salary <= 5000000)
        {
            tax = salary * 0.05;
        }
        else
        {
            tax = salary * 0.10;
        }
        Console.WriteLine($"Thuế phải nộp: {tax}");
    }
}
