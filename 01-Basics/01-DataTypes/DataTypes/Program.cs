//TODO Value Types (Kiểu giá trị): Các kiểu dữ liệu cơ bản lưu trữ trực tiếp giá trị trong bộ nhớ

// Số nguyên 32-bit
int age = 25;
Console.WriteLine(age);  // Output: 25

// Số thực 64-bit
double pi = 3.14159;
Console.WriteLine(pi);  // Output: 3.14159

// char (Ký tự Unicode 16-bit)
char grade = 'A';
Console.WriteLine(grade);  // Output: A

//bool (Kiểu boolean)
bool isOnline = true;
Console.WriteLine(isOnline);  // Output: True

//Struct (Cấu trúc): Struct là một kiểu dữ liệu có cấu trúc, được kết hợp từ các kiểu dữ liệu nguyên thuỷ do người lập trình định nghĩa để thuận tiện trong việc quản lý dữ liệu và lập trình.

//TODO Reference Types (Kiểu tham chiếu): Các kiểu dữ liệu lưu trữ tham chiếu tới vùng nhớ nơi giá trị thực tế được lưu trữ

// Chuỗi kí tự
string greeting = "Hello, World!";
Console.WriteLine(greeting);  // Output: Hello, World!

// Array (Mảng)
int[] numbers = { 1, 2, 3, 4, 5 };
Console.WriteLine(numbers[0]);  // Output: 1

//Class (Lớp)
/*
class Person
{
    public string Name;
    public int Age;
}

Person person = new Person();
person.Name = "John";
person.Age = 30;
Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");  // Output: Name: John, Age: 30
*/

//TODO Nullable Types (Kiểu dữ liệu cho phép null): Khi bạn muốn một kiểu dữ liệu value type có thể nhận giá trị null.

// Nullable int:
int? nullableInt = null;
if (nullableInt.HasValue)
    Console.WriteLine(nullableInt.Value);
else
    Console.WriteLine("The value is null.");  // Output: The value is null.

//TODO Conversions (Chuyển đổi kiểu dữ liệu): Chuyển đổi giữa các kiểu dữ liệu khác nhau

// Implicit Conversion (Chuyển đổi ngầm định)
int num = 10;
long bigNum = num;  // Implicit conversion from int to long
Console.WriteLine(bigNum);  // Output: 10

//Explicit Conversion (Chuyển đổi tường minh)
double d = 9.78;
int i = (int)d;  // Explicit conversion
Console.WriteLine(i);  // Output: 9

//TODO Type Inference (Suy luận kiểu dữ liệu): C# cho phép sử dụng từ khóa var để suy luận kiểu dựa trên giá trị

//Type Inference
var _age = 25;  // Inferred as int
var name = "Alice";  // Inferred as string
Console.WriteLine($"{name} is {age} years old.");  // Output: Alice is 25 years old.

//TODO Boxing và Unboxing: Boxing là quá trình chuyển từ kiểu giá trị sang kiểu tham chiếu, và unboxing là quá trình ngược lại

//Boxing 
int _num = 123;
object obj = _num;  // Boxing
Console.WriteLine(obj);  // Output: 123

//Unboxing
object _obj = 123;
int _numbers = (int)_obj;  // Unboxing
Console.WriteLine(_numbers);  // Output: 123

//TODO Const và ReadOnly

// const: Khai báo giá trị không thay đổi, được xác định tại thời điểm biên dịch
const double Pi = 3.14159;
Console.WriteLine(Pi);  // Output: 3.14159

// readonly: Biến chỉ được gán giá trị một lần duy nhất, thường được gán trong constructor.
class Circle
{
    public readonly double Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }
}

//TODO Dynamic Type: dynamic cho phép thay đổi kiểu dữ liệu tại thời điểm chạy (runtime).
/*
dynamic value = 10;
Console.WriteLine(value);  // Output: 10
value = "Hello";
Console.WriteLine(value);  // Output: Hello
*/

//TODO Enum Types: enum là tập hợp các hằng số có tên, đại diện cho một tập giá trị nhất định

// Enum Example
/*
enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }

Days today = Days.Monday;
Console.WriteLine(today);  // Output: Monday
*/




/**
* * Value types lưu trữ trực tiếp giá trị, trong khi Reference types lưu trữ địa chỉ của giá trị.
* * Nullable types cho phép các kiểu giá trị có thể nhận null.
* * Chuyển đổi kiểu dữ liệu có thể là ngầm định hoặc tường minh.
* * Type inference giúp code ngắn gọn hơn với var.
* * Boxing và unboxing giúp chuyển đổi giữa value type và reference type.
* * const và readonly đảm bảo giá trị không thay đổi.
* * dynamic linh hoạt trong việc xử lý các kiểu dữ liệu thay đổi tại runtime.
* * enum giúp tạo tập hợp hằng số rõ ràng và dễ hiểu.
*/