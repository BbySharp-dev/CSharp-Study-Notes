# Tổng hợp kiến thức và câu hỏi phỏng vấn về Operators trong C#

## 📚 Mục lục:
1. [Những kiến thức cần ghi nhớ về Operators](#những-kiến-thức-cần-ghi-nhớ-về-operators)
2. [Câu hỏi phỏng vấn từ cơ bản đến nâng cao](#câu-hỏi-phỏng-vấn-từ-cơ-bản-đến-nâng-cao)
3. [Câu hỏi tình huống và giải quyết vấn đề](#câu-hỏi-tình-huống-và-giải-quyết-vấn-đề)
4. [Tài liệu tham khảo](#tài-liệu-tham-khảo)

---

## Những kiến thức cần ghi nhớ về Operators

### 1. Operator là gì trong C#?
- **Operators** là các ký hiệu hoặc từ khóa dùng để thực hiện các phép toán trên các giá trị hoặc biến trong C#.
- Ví dụ, toán tử cộng (`+`) được dùng để cộng hai giá trị số.

### 2. Các loại operators phổ biến:
- **Arithmetic Operators**: Sử dụng cho các phép toán số học như cộng, trừ, nhân, chia, lấy phần dư.
    - `+` (Cộng), `-` (Trừ), `*` (Nhân), `/` (Chia), `%` (Lấy phần dư).
- **Assignment Operators**: Dùng để gán giá trị cho biến.
    - `=` (Gán), `+=` (Cộng và gán), `-=`, `*=`, `/=`, `%=`.
- **Comparison Operators**: Dùng để so sánh hai giá trị.
    - `==` (Bằng), `!=` (Không bằng), `>` (Lớn hơn), `<` (Nhỏ hơn), `>=`, `<=`.
- **Logical Operators**: Dùng để thực hiện các phép toán logic.
    - `&&` (AND), `||` (OR), `!` (NOT).
- **Unary Operators**: Là các toán tử áp dụng cho một toán hạng.
    - `+` (Dương), `-` (Âm), `++` (Tăng 1), `--` (Giảm 1), `!` (Phủ định).
- **Bitwise Operators**: Dùng để thực hiện các phép toán trên các bit.
    - `&` (AND), `|` (OR), `^` (XOR), `~` (NOT), `<<` (Shift left), `>>` (Shift right).
  
### 3. Tính kết hợp và thứ tự ưu tiên:
- Toán tử trong C# có **thứ tự ưu tiên** xác định toán tử nào được thực hiện trước trong biểu thức phức tạp.
- **Tính kết hợp** xác định hướng thực hiện toán tử (từ trái sang phải hoặc từ phải sang trái).

### 4. Null-coalescing và Null-conditional Operators:
- **Null-coalescing operator (`??`)**: Dùng để trả về giá trị mặc định khi một biến có giá trị `null`.
    - Ví dụ: `x = y ?? -1;` (Nếu `y` là `null`, `x` sẽ được gán giá trị `-1`).
- **Null-conditional operator (`?.`)**: Kiểm tra xem đối tượng có `null` hay không trước khi truy cập thành phần của nó.
    - Ví dụ: `int? length = obj?.Property?.Length;`.

### 5. Ternary Operator:
- **Ternary operator** (`?:`) là toán tử ba ngôi, thường được dùng để thay thế câu lệnh `if-else` đơn giản.
    - Cú pháp: `condition ? trueValue : falseValue;`
    - Ví dụ: `int max = (a > b) ? a : b;` (Nếu `a > b`, giá trị `max` sẽ là `a`, ngược lại là `b`).

### 6. Operator Overloading:
- **Operator Overloading** là khả năng của C# cho phép các toán tử được định nghĩa lại để hoạt động với các kiểu dữ liệu tùy chỉnh (classes).
    - Ví dụ: Toán tử `+` có thể được định nghĩa lại để cộng hai đối tượng của class `ComplexNumber`.

---

## Câu hỏi phỏng vấn từ cơ bản đến nâng cao

### 🔰 Cơ bản:
1. **Operators là gì và cho ví dụ về các loại operators trong C#?**
2. **Toán tử `==` và `.Equals()` khác nhau như thế nào trong C#?**
3. **Làm sao để kiểm tra một biến có giá trị `null` trước khi sử dụng?**
4. **Sự khác biệt giữa `&&` và `||` là gì?**

### ⚙️ Trung bình:
1. **Null-coalescing operator (`??`) được sử dụng như thế nào?**
2. **Làm thế nào để sử dụng toán tử `?:` (ternary operator)?**
3. **Toán tử `++` hoạt động như thế nào trong các biểu thức?**
4. **Bitwise operator là gì? Khi nào nên sử dụng nó?**

### 🚀 Nâng cao:
1. **Giải thích và cho ví dụ về operator overloading trong C#?**
2. **Null-conditional operator (`?.`) hoạt động như thế nào?**
3. **So sánh toán tử `&` và `&&`. Khi nào nên sử dụng mỗi loại?**
4. **Làm thế nào để định nghĩa toán tử `+` cho một class tùy chỉnh?**

---

## Câu hỏi tình huống và giải quyết vấn đề

### 1. Tối ưu hóa biểu thức toán học:
**Tình huống**: Trong một biểu thức tính toán phức tạp, bạn nhận thấy rằng chương trình chạy chậm. Làm thế nào bạn có thể tối ưu hóa hiệu năng của biểu thức này?
- **Gợi ý**: Sử dụng thứ tự ưu tiên toán tử và tính kết hợp hợp lý để tối ưu hóa các phép toán. Hạn chế sử dụng toán tử `+` với chuỗi, thay vào đó sử dụng `StringBuilder` để cải thiện hiệu suất.

### 2. Kiểm tra biến `null` trước khi truy cập:
**Tình huống**: Bạn cần kiểm tra nhiều cấp của đối tượng trước khi truy cập thuộc tính của nó. Làm sao bạn có thể làm điều này một cách ngắn gọn mà không cần nhiều câu lệnh `if` lồng nhau?
- **Gợi ý**: Sử dụng toán tử điều kiện `?.` để kiểm tra `null` trước khi truy cập thuộc tính của đối tượng.

### 3. Tự động xử lý giá trị mặc định:
**Tình huống**: Trong một hàm, bạn cần đảm bảo rằng nếu người dùng không nhập một giá trị cụ thể (tức là biến nhận giá trị `null`), giá trị mặc định sẽ được sử dụng. Làm thế nào bạn có thể xử lý điều này?
- **Gợi ý**: Sử dụng toán tử null-coalescing `??` để kiểm tra biến có `null` và trả về giá trị mặc định nếu cần thiết.

---

## Tài liệu tham khảo
1. [Microsoft Documentation on Operators](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/)
2. [Null-coalescing and Null-conditional operators](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator)
3. [Operator Overloading in C#](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/operator-overloading)
4. [Bitwise Operators in C#](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/and-operator)

