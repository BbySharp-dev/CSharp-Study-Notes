# Tổng hợp kiến thức và câu hỏi phỏng vấn về Conditional Statements trong C#

## 📚 Mục lục:

1. [Những kiến thức cần ghi nhớ về Conditional Statements](#những-kiến-thức-cần-ghi-nhớ-về-conditional-statements)
2. [Câu hỏi phỏng vấn từ cơ bản đến nâng cao](#câu-hỏi-phỏng-vấn-từ-cơ-bản-đến-nâng-cao)
3. [Câu hỏi tình huống và giải quyết vấn đề](#câu-hỏi-tình-huống-và-giải-quyết-vấn-đề)
4. [Tài liệu tham khảo](#tài-liệu-tham-khảo)

---

## Những kiến thức cần ghi nhớ về Conditional Statements

### 1. Conditional Statements là gì trong C#?

- **Conditional Statements** (Câu lệnh điều kiện) trong C# cho phép chương trình thực hiện các hành động khác nhau dựa trên các điều kiện. Thông thường, điều này được thực hiện với các câu lệnh như `if`, `else`, `else if`, và `switch`.

### 2. Các loại Conditional Statements phổ biến:

- **if**: Kiểm tra một điều kiện và thực thi mã nếu điều kiện là `true` (đúng).
- **else if**: Kiểm tra thêm một điều kiện nếu `if` ban đầu là `false`.
- **else**: Thực hiện hành động khi tất cả các điều kiện trước đó đều là `false`.
- **switch**: Lựa chọn một trong nhiều khối mã để thực thi, dựa trên giá trị của một biểu thức.

### 3. Ternary Operator:

- **Ternary Operator** (Toán tử ba ngôi) là một cú pháp ngắn gọn cho các câu lệnh điều kiện đơn giản. Nó có dạng: `condition ? trueResult : falseResult;`. Ví dụ: `int result = (a > b) ? a : b;` (nếu `a > b` thì `result` sẽ nhận giá trị của `a`, ngược lại nhận giá trị của `b`).

### 4. Sự khác biệt giữa if-else và switch:

- **if-else**: Dùng khi có các điều kiện phức tạp hoặc không cố định.
- **switch**: Dùng khi có nhiều nhánh điều kiện dựa trên cùng một biến hoặc biểu thức, và giá trị của biến này nằm trong một danh sách xác định trước.

### 5. Sử dụng break và default trong switch:

- **break**: Kết thúc việc kiểm tra và ngăn không cho chương trình tiếp tục kiểm tra các trường hợp còn lại trong `switch`.
- **default**: Xử lý giá trị không nằm trong các trường hợp đã được định nghĩa của `switch`.

### 6. Nested Conditions (Câu lệnh điều kiện lồng nhau):

- **Nested Conditions** (Câu lệnh điều kiện lồng nhau) là khi bạn sử dụng một câu lệnh điều kiện bên trong một câu lệnh điều kiện khác. Điều này thường dùng để xử lý các logic phức tạp hơn.

---

## Câu hỏi phỏng vấn từ cơ bản đến nâng cao

### 🔰 Cơ bản:

1. **Conditional Statements là gì trong C# và chúng được sử dụng để làm gì?**
2. **Cách khai báo và sử dụng câu lệnh `if` trong C#?**
3. **Sự khác biệt giữa `if`, `else if` và `else` là gì?**
4. **Câu lệnh `switch` là gì và khi nào nên dùng thay cho `if-else`?**
5. **Toán tử điều kiện ba ngôi (ternary operator) có cú pháp như thế nào?**
6. **Có thể sử dụng các điều kiện lồng nhau trong `if-else` không?**

### ⚙️ Trung bình:

1. **Ưu và nhược điểm của việc sử dụng `if-else` và `switch` trong C#?**
2. **Bạn có thể kiểm tra nhiều điều kiện trong cùng một câu lệnh `if` không?**
3. **Giải thích cách hoạt động của từ khóa `default` trong `switch`.**
4. **Điều gì sẽ xảy ra nếu không dùng `break` trong `switch`?**
5. **Làm thế nào để sử dụng toán tử logic `&&` và `||` trong các câu lệnh điều kiện?**
6. **Khi nào nên sử dụng `switch` thay vì `if-else` trong lập trình thực tế?**

### 🚀 Nâng cao:

1. **So sánh hiệu suất giữa việc sử dụng nhiều câu lệnh `if-else` và `switch`.**
2. **Làm thế nào để tối ưu hóa việc kiểm tra nhiều điều kiện trong các ứng dụng lớn?**
3. **Giải thích cách C# xử lý các điều kiện trong các câu lệnh điều kiện lồng nhau.**
4. **Tại sao chúng ta cần sử dụng từ khóa `break` trong `switch`, và điều gì sẽ xảy ra nếu không có nó?**
5. **Giới thiệu về Pattern Matching trong `switch` và cách sử dụng để cải thiện điều kiện phức tạp.**

---

## Câu hỏi tình huống và giải quyết vấn đề

### 1. Tình huống xử lý giảm giá trong ứng dụng mua sắm:

**Tình huống**: Bạn cần viết một chương trình áp dụng giảm giá cho khách hàng dựa trên tổng giá trị đơn hàng và trạng thái thành viên (VIP). Nếu tổng giá trị trên 500 đô la, giảm giá 10%. Nếu khách hàng là VIP, giảm thêm 5%. Làm thế nào bạn có thể viết các điều kiện để xử lý vấn đề này?

### 2. Tối ưu hóa điều kiện kiểm tra tuổi:

**Tình huống**: Bạn cần phát triển một chương trình phân loại người dùng dựa trên tuổi: dưới 18 là trẻ em, từ 18 đến 60 là người lớn, trên 60 là người cao tuổi. Hãy đảm bảo rằng chương trình có thể xử lý các đầu vào không hợp lệ như số âm hoặc các ký tự không phải số.

### 3. Quản lý tín hiệu đèn giao thông:

**Tình huống**: Bạn được yêu cầu tạo chương trình mô phỏng hệ thống đèn giao thông. Đèn có ba trạng thái: Đỏ, Vàng, và Xanh. Dựa trên từng trạng thái, chương trình sẽ in ra thông báo phù hợp. Bạn sẽ xử lý vấn đề này như thế nào?

---

## Tài liệu tham khảo

1. [Microsoft Documentation on Conditional Statements](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/conditional-statements)
2. [Pattern Matching in C#](https://learn.microsoft.com/en-us/dotnet/csharp/pattern-matching)
3. [Switch Statement Performance Optimization](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/switch)
4. [Ternary Operator Best Practices](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator)
