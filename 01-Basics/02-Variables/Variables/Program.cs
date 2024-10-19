// ! 1. Biến là gì?
// Một biến là một tên đại diện cho một vùng nhớ mà bạn có thể lưu trữ dữ liệu. 
// Trong C#, tất cả các biến đều phải được khai báo với kiểu dữ liệu cụ thể.

// ! 2. Khai báo biến
// * Cú pháp khai báo biến: <kiểu dữ liệu> <tên biến> = <giá trị khởi tạo>;

// ? Ví dụ về các kiểu dữ liệu thông dụng trong C#:

// * Kiểu số nguyên (int) - lưu trữ số nguyên
int age = 25;

// * Kiểu số thực (double) - lưu trữ số thực có dấu chấm thập phân
double height = 1.75;

// * Kiểu chuỗi (string) - lưu trữ chuỗi ký tự
string name = "John Doe";

// * Kiểu ký tự (char) - lưu trữ một ký tự duy nhất
char initial = 'J';

// * Kiểu boolean (bool) - lưu trữ giá trị đúng hoặc sai (true/false)
bool isStudent = true;

// TODO: 3. In giá trị của các biến ra màn hình
Console.WriteLine("Name: " + name);
Console.WriteLine("Age: " + age);
Console.WriteLine("Height: " + height + " meters");
Console.WriteLine("Initial: " + initial);
Console.WriteLine("Is student: " + isStudent);

// ! 4. Các kiểu dữ liệu khác nhau:
// * C# hỗ trợ nhiều kiểu dữ liệu, bao gồm:
// int (số nguyên), double (số thực), char (ký tự), string (chuỗi ký tự), bool (boolean)

// ? Ví dụ về một số kiểu dữ liệu khác:
float weight = 70.5f; // * float yêu cầu thêm hậu tố 'f'
decimal salary = 3000.75m; // * decimal yêu cầu hậu tố 'm', dùng cho các giá trị tiền tệ
long population = 7800000000L; // * long yêu cầu hậu tố 'L' khi giá trị rất lớn
byte level = 10; // * byte có thể lưu trữ giá trị nguyên từ 0 đến 255

// TODO: In các kiểu dữ liệu khác
Console.WriteLine("Weight: " + weight + " kg");
Console.WriteLine("Salary: " + salary + " USD");
Console.WriteLine("World Population: " + population);
Console.WriteLine("Level: " + level);

// ! 5. Hằng số (Constants)
// * Hằng số là biến mà giá trị của nó không thể thay đổi sau khi đã được khởi tạo. 
// * Để khai báo một hằng số, sử dụng từ khóa `const`.
const double PI = 3.14159;
Console.WriteLine("Pi: " + PI);

// ! 6. Kiểu var (suy diễn kiểu)
// * Từ khóa `var` cho phép C# tự suy luận kiểu của biến dựa trên giá trị khởi tạo.
// ! Lưu ý rằng kiểu của biến không thay đổi sau khi được suy diễn.
var city = "New York";  // * Suy diễn là kiểu string
var temperature = 22.5; // * Suy diễn là kiểu double

Console.WriteLine("City: " + city);
Console.WriteLine("Temperature: " + temperature);

// ! 7. Biến Nullable (biến có thể nhận giá trị null)
// * Trong C#, các kiểu dữ liệu giá trị (như int, double) không thể lưu trữ giá trị null, 
// * nhưng ta có thể sử dụng dấu ? để cho phép biến nhận giá trị null.
int? nullableInt = null; // * Biến này có thể chứa giá trị null
Console.WriteLine("Nullable Int: " + nullableInt);

// ? Kiểm tra biến nullable trước khi sử dụng để tránh lỗi
if (nullableInt.HasValue)
{
    Console.WriteLine("Nullable Int has value: " + nullableInt.Value);
}
else
{
    Console.WriteLine("Nullable Int is null.");
}

// ! 8. Các phép gán và sử dụng biến
// * Sau khi khai báo, bạn có thể thay đổi giá trị của biến (trừ hằng số).
age = 30; // * Thay đổi giá trị của biến `age`
Console.WriteLine("Updated Age: " + age);

// ? Phép gán và phép toán cơ bản
age = age + 1; // * Tăng giá trị của `age` lên 1
age += 1;      // * Cú pháp rút gọn
Console.WriteLine("Age after increment: " + age);